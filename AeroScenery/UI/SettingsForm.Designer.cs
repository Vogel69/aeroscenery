﻿namespace AeroScenery.UI
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.afsFolderButton = new System.Windows.Forms.Button();
            this.afsFolderTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sdkButton = new System.Windows.Forms.Button();
            this.aerosceneryDatabaseFolderButton = new System.Windows.Forms.Button();
            this.workingFolderButton = new System.Windows.Forms.Button();
            this.afsSDKFolderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aeroSceneryDatabaseFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.workingFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.downloadWaitRandomTextBox = new System.Windows.Forms.TextBox();
            this.downloadWaitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simultaneousDownloadsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userAgentTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxTilesPerStitchedImageInfoLabel = new System.Windows.Forms.Label();
            this.maxTilesPerStitchedImageTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gcWriteRawFilesComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gcWriteImagesWithMaskCombo = new System.Windows.Forms.ComboBox();
            this.gcDoMultipleSmallerRunsComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.afsFolderButton);
            this.groupBox1.Controls.Add(this.afsFolderTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.sdkButton);
            this.groupBox1.Controls.Add(this.aerosceneryDatabaseFolderButton);
            this.groupBox1.Controls.Add(this.workingFolderButton);
            this.groupBox1.Controls.Add(this.afsSDKFolderTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aeroSceneryDatabaseFolderTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.workingFolderTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folders";
            // 
            // afsFolderButton
            // 
            this.afsFolderButton.Location = new System.Drawing.Point(640, 123);
            this.afsFolderButton.Name = "afsFolderButton";
            this.afsFolderButton.Size = new System.Drawing.Size(33, 25);
            this.afsFolderButton.TabIndex = 11;
            this.afsFolderButton.Text = "...";
            this.afsFolderButton.UseVisualStyleBackColor = true;
            this.afsFolderButton.Click += new System.EventHandler(this.afsFolderButton_Click);
            // 
            // afsFolderTextBox
            // 
            this.afsFolderTextBox.Location = new System.Drawing.Point(216, 123);
            this.afsFolderTextBox.Name = "afsFolderTextBox";
            this.afsFolderTextBox.Size = new System.Drawing.Size(417, 25);
            this.afsFolderTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "AFS2 Folder";
            // 
            // sdkButton
            // 
            this.sdkButton.Location = new System.Drawing.Point(640, 91);
            this.sdkButton.Name = "sdkButton";
            this.sdkButton.Size = new System.Drawing.Size(33, 25);
            this.sdkButton.TabIndex = 8;
            this.sdkButton.Text = "...";
            this.sdkButton.UseVisualStyleBackColor = true;
            this.sdkButton.Click += new System.EventHandler(this.sdkButton_Click);
            // 
            // aerosceneryDatabaseFolderButton
            // 
            this.aerosceneryDatabaseFolderButton.Location = new System.Drawing.Point(640, 60);
            this.aerosceneryDatabaseFolderButton.Name = "aerosceneryDatabaseFolderButton";
            this.aerosceneryDatabaseFolderButton.Size = new System.Drawing.Size(33, 25);
            this.aerosceneryDatabaseFolderButton.TabIndex = 7;
            this.aerosceneryDatabaseFolderButton.Text = "...";
            this.aerosceneryDatabaseFolderButton.UseVisualStyleBackColor = true;
            this.aerosceneryDatabaseFolderButton.Click += new System.EventHandler(this.aerosceneryDatabaseFolderButton_Click);
            // 
            // workingFolderButton
            // 
            this.workingFolderButton.Location = new System.Drawing.Point(640, 29);
            this.workingFolderButton.Name = "workingFolderButton";
            this.workingFolderButton.Size = new System.Drawing.Size(33, 25);
            this.workingFolderButton.TabIndex = 6;
            this.workingFolderButton.Text = "...";
            this.workingFolderButton.UseVisualStyleBackColor = true;
            this.workingFolderButton.Click += new System.EventHandler(this.workingFolderButton_Click);
            // 
            // afsSDKFolderTextBox
            // 
            this.afsSDKFolderTextBox.Location = new System.Drawing.Point(216, 91);
            this.afsSDKFolderTextBox.Name = "afsSDKFolderTextBox";
            this.afsSDKFolderTextBox.Size = new System.Drawing.Size(417, 25);
            this.afsSDKFolderTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "AFS2 SDK Folder";
            // 
            // aeroSceneryDatabaseFolderTextBox
            // 
            this.aeroSceneryDatabaseFolderTextBox.Location = new System.Drawing.Point(216, 60);
            this.aeroSceneryDatabaseFolderTextBox.Name = "aeroSceneryDatabaseFolderTextBox";
            this.aeroSceneryDatabaseFolderTextBox.Size = new System.Drawing.Size(417, 25);
            this.aeroSceneryDatabaseFolderTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AeroScenery Database Folder";
            // 
            // workingFolderTextBox
            // 
            this.workingFolderTextBox.Location = new System.Drawing.Point(216, 29);
            this.workingFolderTextBox.Name = "workingFolderTextBox";
            this.workingFolderTextBox.Size = new System.Drawing.Size(417, 25);
            this.workingFolderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.downloadWaitRandomTextBox);
            this.groupBox2.Controls.Add(this.downloadWaitTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.simultaneousDownloadsComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.userAgentTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Downloads";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "randomize by + or -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(574, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ms";
            // 
            // downloadWaitRandomTextBox
            // 
            this.downloadWaitRandomTextBox.Location = new System.Drawing.Point(489, 98);
            this.downloadWaitRandomTextBox.Name = "downloadWaitRandomTextBox";
            this.downloadWaitRandomTextBox.Size = new System.Drawing.Size(79, 25);
            this.downloadWaitRandomTextBox.TabIndex = 6;
            this.downloadWaitRandomTextBox.TextChanged += new System.EventHandler(this.downloadWaitRandomTextBox_TextChanged);
            // 
            // downloadWaitTextBox
            // 
            this.downloadWaitTextBox.Location = new System.Drawing.Point(216, 98);
            this.downloadWaitTextBox.Name = "downloadWaitTextBox";
            this.downloadWaitTextBox.Size = new System.Drawing.Size(79, 25);
            this.downloadWaitTextBox.TabIndex = 5;
            this.downloadWaitTextBox.TextChanged += new System.EventHandler(this.downloadWaitTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wait Between Downloads";
            // 
            // simultaneousDownloadsComboBox
            // 
            this.simultaneousDownloadsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.simultaneousDownloadsComboBox.Enabled = false;
            this.simultaneousDownloadsComboBox.FormattingEnabled = true;
            this.simultaneousDownloadsComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.simultaneousDownloadsComboBox.Location = new System.Drawing.Point(216, 63);
            this.simultaneousDownloadsComboBox.Name = "simultaneousDownloadsComboBox";
            this.simultaneousDownloadsComboBox.Size = new System.Drawing.Size(417, 25);
            this.simultaneousDownloadsComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Simultaneous Downloads";
            // 
            // userAgentTextBox
            // 
            this.userAgentTextBox.Location = new System.Drawing.Point(216, 29);
            this.userAgentTextBox.Name = "userAgentTextBox";
            this.userAgentTextBox.Size = new System.Drawing.Size(417, 25);
            this.userAgentTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Agent";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(606, 592);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 32);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(509, 592);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 32);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxTilesPerStitchedImageInfoLabel);
            this.groupBox3.Controls.Add(this.maxTilesPerStitchedImageTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 70);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tile Stitching";
            // 
            // maxTilesPerStitchedImageInfoLabel
            // 
            this.maxTilesPerStitchedImageInfoLabel.AutoSize = true;
            this.maxTilesPerStitchedImageInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTilesPerStitchedImageInfoLabel.Location = new System.Drawing.Point(301, 29);
            this.maxTilesPerStitchedImageInfoLabel.Name = "maxTilesPerStitchedImageInfoLabel";
            this.maxTilesPerStitchedImageInfoLabel.Size = new System.Drawing.Size(199, 17);
            this.maxTilesPerStitchedImageInfoLabel.TabIndex = 10;
            this.maxTilesPerStitchedImageInfoLabel.Text = "tiles x 32 tiles. (8042px x 8042px)";
            // 
            // maxTilesPerStitchedImageTextBox
            // 
            this.maxTilesPerStitchedImageTextBox.Location = new System.Drawing.Point(216, 26);
            this.maxTilesPerStitchedImageTextBox.Name = "maxTilesPerStitchedImageTextBox";
            this.maxTilesPerStitchedImageTextBox.Size = new System.Drawing.Size(79, 25);
            this.maxTilesPerStitchedImageTextBox.TabIndex = 9;
            this.maxTilesPerStitchedImageTextBox.TextChanged += new System.EventHandler(this.maxTilesPerStitchedImageTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Max tiles per stitched image";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.gcDoMultipleSmallerRunsComboBox);
            this.groupBox4.Controls.Add(this.gcWriteImagesWithMaskCombo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.gcWriteRawFilesComboBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(690, 146);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GeoConvert";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Write Raw Files";
            // 
            // gcWriteRawFilesComboBox
            // 
            this.gcWriteRawFilesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcWriteRawFilesComboBox.FormattingEnabled = true;
            this.gcWriteRawFilesComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.gcWriteRawFilesComboBox.Location = new System.Drawing.Point(216, 29);
            this.gcWriteRawFilesComboBox.Name = "gcWriteRawFilesComboBox";
            this.gcWriteRawFilesComboBox.Size = new System.Drawing.Size(417, 25);
            this.gcWriteRawFilesComboBox.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Write Images With Mask";
            // 
            // gcWriteImagesWithMaskCombo
            // 
            this.gcWriteImagesWithMaskCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcWriteImagesWithMaskCombo.FormattingEnabled = true;
            this.gcWriteImagesWithMaskCombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.gcWriteImagesWithMaskCombo.Location = new System.Drawing.Point(216, 63);
            this.gcWriteImagesWithMaskCombo.Name = "gcWriteImagesWithMaskCombo";
            this.gcWriteImagesWithMaskCombo.Size = new System.Drawing.Size(417, 25);
            this.gcWriteImagesWithMaskCombo.TabIndex = 7;
            // 
            // gcDoMultipleSmallerRunsComboBox
            // 
            this.gcDoMultipleSmallerRunsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcDoMultipleSmallerRunsComboBox.FormattingEnabled = true;
            this.gcDoMultipleSmallerRunsComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.gcDoMultipleSmallerRunsComboBox.Location = new System.Drawing.Point(216, 98);
            this.gcDoMultipleSmallerRunsComboBox.Name = "gcDoMultipleSmallerRunsComboBox";
            this.gcDoMultipleSmallerRunsComboBox.Size = new System.Drawing.Size(417, 25);
            this.gcDoMultipleSmallerRunsComboBox.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Do Multiple Smaller Runs";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(714, 636);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox workingFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sdkButton;
        private System.Windows.Forms.Button aerosceneryDatabaseFolderButton;
        private System.Windows.Forms.Button workingFolderButton;
        private System.Windows.Forms.TextBox afsSDKFolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aeroSceneryDatabaseFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox downloadWaitRandomTextBox;
        private System.Windows.Forms.TextBox downloadWaitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox simultaneousDownloadsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userAgentTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button afsFolderButton;
        private System.Windows.Forms.TextBox afsFolderTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label maxTilesPerStitchedImageInfoLabel;
        private System.Windows.Forms.TextBox maxTilesPerStitchedImageTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox gcWriteRawFilesComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox gcDoMultipleSmallerRunsComboBox;
        private System.Windows.Forms.ComboBox gcWriteImagesWithMaskCombo;
    }
}