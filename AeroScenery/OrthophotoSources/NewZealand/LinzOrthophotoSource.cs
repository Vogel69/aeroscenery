﻿using AeroScenery.OrthoPhotoSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroScenery.OrthophotoSources.NewZealand
{
    public class LinzOrthophotoSource : GenericOrthophotoSource
    {
        public static string DefaultUrlTemplate = "http://koordinates-tiles-d.global.ssl.fastly.net/services;key=50721244e42045c58b2bbe2ee5487a9a/tiles/v4/layer=51769,style=auto;layer=88131,style=auto;layer=95497,style=auto/{zoom}/{x}/{y}.png";


        public LinzOrthophotoSource()
        {
            this.urlTemplate = DefaultUrlTemplate;
            Initialize();
        }

        public LinzOrthophotoSource(string urlTemplate)
        {
            this.urlTemplate = urlTemplate;
            Initialize();
        }

        private void Initialize()
        {
            this.width = 256;
            this.height = 256;
            this.imageExtension = "jpg";
            this.source = OrthophotoSourceDirectoryName.NZ_Linz;
            this.tiledWebMapType = TiledWebMapType.Google;
        }
    }
}
