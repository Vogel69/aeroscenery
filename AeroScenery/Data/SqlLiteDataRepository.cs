﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroScenery.Common;
using AeroScenery.Data.Models;
using System.IO;
using System.Data.SQLite;
using Dapper;
using System.Globalization;

namespace AeroScenery.Data
{
    public class SqlLiteDataRepository : IDataRepository
    {
        private Settings settings;
        private string dbPath;

        public List<GridSquare> GetAllGridSquares()
        {
            using (var con = DbConnection())
            {
                var query = @"SELECT * FROM GridSquares ORDER BY Name";

                con.Open();
                List<GridSquare> result = con.Query<GridSquare>(query).ToList();

                return result;
            }
        }

        public void CreateGridSquare(GridSquare gridSquare)
        {
            gridSquare.Fixed = 1;

            using (var con = DbConnection())
            {
                var query = @"INSERT INTO GridSquares (Name, NorthLatitude, EastLongitude, WestLongitude, SouthLatitude, Level, Fixed) VALUES 
                            (@Name, @NorthLatitude, @EastLongitude, @WestLongitude, @SouthLatitude, @Level, @Fixed);
                            SELECT last_insert_rowid();";

                con.Open();
                gridSquare.GridSquareId = con.Query<long>(query, gridSquare).First();
            }
        }

        public void UpdateGridSquare(GridSquare gridSquare)
        {
            using (var con = DbConnection())
            {
                var query = @"UPDATE GridSquares SET
                            Name=@Name,
                            NorthLatitude=@NorthLatitude,
                            EastLongitude=@EastLongitude,
                            WestLongitude=@WestLongitude,
                            SouthLatitude=@SouthLatitude, 
                            Level=@Level,
                            Fixed=@Fixed
                            WHERE GridSquareId=@GridSquareId";

                con.Open();
                con.Query(query, gridSquare);
            }
        }



        public void DeleteGridSquare(GridSquare gridSquare)
        {
            using (var con = DbConnection())
            {
                var query = @"DELETE FROM GridSquares WHERE GridSquareId=@GridSquareId;";

                con.Open();
                con.Query(query, gridSquare);
            }
        }

        public void DeleteGridSquare(string gridSquareName)
        {
            using (var con = DbConnection())
            {
                var query = @"DELETE FROM GridSquares WHERE Name=@gridSquareName;";

                con.Open();
                con.Query(query, new { gridSquareName });
            }
        }

        public GridSquare FindGridSquare(string name)
        {
            using (var con = DbConnection())
            {
                var query = @"SELECT * FROM GridSquares WHERE Name = @name";

                con.Open();
                GridSquare result = con.Query<GridSquare>(query, new { name }).FirstOrDefault();
                return result;
            }
        }

        public IList<FSCloudPortAirport> GetAllFSCloudPortAirports()
        {
            using (var con = DbConnection())
            {
                var query = @"SELECT * FROM FSCloudPortAirports ORDER BY Latitude, Longitude";

                con.Open();
                List<FSCloudPortAirport> result = con.Query<FSCloudPortAirport>(query).ToList();

                return result;
            }
        }

        public DateTime GetFSCloudPortAirportsLastCachedDateTime()
        {
            // By default make the data in need of an update
            var result = DateTime.UtcNow.AddDays(-10);

            using (var con = DbConnection())
            {
                var query = @"SELECT LastCached FROM FSCloudPortAirports LiMIT 1";

                con.Open();
                var lastCachedStr = con.Query<string>(query).FirstOrDefault();

                if (!string.IsNullOrEmpty(lastCachedStr))
                {
                    result = DateTime.ParseExact(lastCachedStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                }
            }

            return result;
        }

        public void UpdateFSCloudPortAirports(IList<FSCloudPortAirport> airports)
        {
            using (var con = DbConnection())
            {
                var deleteQuery = @"DELETE FROM FSCloudPortAirports;";

                con.Open();
                con.Execute(deleteQuery);

                SQLiteTransaction transaction = con.BeginTransaction();

                try
                {
                    foreach (FSCloudPortAirport airport in airports)
                    {
                        airport.LastCachedDateTime = DateTime.UtcNow;

                        var insertQuery = @"INSERT INTO FSCloudPortAirports (ICAO, Latitude, Longitude, Runways, Buildings, StaticAircraft, Name, LastModified, LastCached, Url) VALUES 
                        (@ICAO, @Latitude, @Longitude, @Runways, @Buildings, @StaticAircraft, @Name, @LastModified, @LastCached, @Url);";

                        con.Execute(insertQuery, airport);
                    }

                    transaction.Commit();
                }
                catch (SQLiteException ex)
                {
                    transaction.Rollback();
                }

                int i = 0;
            }
        }

        public void UpgradeDatabase()
        {
            var oldDbPath = this.settings.AeroSceneryDBDirectory + @"\aerofly.db";
            var dbPath = this.settings.AeroSceneryDBDirectory + @"\aeroscenery.db";

            // The db files used to be called aerofly.db before
            if (File.Exists(oldDbPath))
            {
                File.Move(oldDbPath, dbPath);
            }

            if (!File.Exists(dbPath))
            {
                CreateDatabase();
            }

            this.UpgradeSchema();

        }

        public void CreateDatabase()
        {
            var dbPath = this.settings.AeroSceneryDBDirectory + @"\aeroscenery.db";

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                CreateSchema();
            }
        }

        private void CreateSchema()
        {
            using (var con = DbConnection())
            {
                con.Open();
                con.Execute(
                    @"create table GridSquares
                      (
                        GridSquareId         INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name                 TEXT,
                        NorthLatitude        REAL,
                        EastLongitude        REAL,
                        WestLongitude        REAL,
                        SouthLatitude        REAL
                      )");

                con.Execute(@"CREATE UNIQUE INDEX ix_GridSquare_Name ON GridSquares (Name ASC);");
            }
        }

        private void UpgradeSchema()
        {
            int databaseVersion = 1;

            using (var con = DbConnection())
            {

                con.Open();

                // The first version didn't have a DatabaseVersion table
                var databaseTableExistsQuery = @"SELECT name FROM sqlite_master WHERE type='table' AND name='DatabaseVersion';";

                if (con.Query(databaseTableExistsQuery).Count() == 0)
                {
                    con.Execute(
                      @"create table DatabaseVersion
                      (
                        DatabaseVersionId    INTEGER PRIMARY KEY,
                        UpgradedOn           TEXT
                      )");
                }
                else
                {
                    var databaseVersionQuery = @"SELECT MAX(DatabaseVersionId) FROM DatabaseVersion;";
                    databaseVersion = con.Query<int>(databaseVersionQuery).FirstOrDefault();
                }

                con.Close();
            }

            var schemaUpgrader = new SchemaUpgrader(dbPath);
            schemaUpgrader.UpgradeToLatestSchema(databaseVersion);

        }

        private SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("Data Source=" + dbPath);
        }

        public Settings Settings
        {
            get
            {
                return this.settings;
            }

            set
            {
                this.settings = value;
                this.dbPath = this.settings.AeroSceneryDBDirectory + @"\aeroscenery.db";
            }
        }

    }
}
