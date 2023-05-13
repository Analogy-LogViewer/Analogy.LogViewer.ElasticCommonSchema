namespace Analogy.LogViewer.ElasticCommonSchema
{
    partial class ECSUCSettings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECSUCSettings));
            btnSave = new System.Windows.Forms.Button();
            btnExportSettings = new System.Windows.Forms.Button();
            txtbSupportedFiles = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnImport = new System.Windows.Forms.Button();
            txtbDirectory = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnOpenFolder = new System.Windows.Forms.Button();
            rbtnCLEF = new System.Windows.Forms.RadioButton();
            rbtnJsonPerLine = new System.Windows.Forms.RadioButton();
            txtbOpenFileFilters = new System.Windows.Forms.TextBox();
            lblOpenfilesFilters = new System.Windows.Forms.Label();
            btnTestFilter = new System.Windows.Forms.Button();
            tabControlFiles = new System.Windows.Forms.TabControl();
            tabPageFilesGeneral = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rbtnApplicationFolder = new System.Windows.Forms.RadioButton();
            rbtnPerUser = new System.Windows.Forms.RadioButton();
            tabPageFileParsingSettings = new System.Windows.Forms.TabPage();
            rbDetectionModeManual = new System.Windows.Forms.RadioButton();
            rbDetectionModeAutomatic = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbtnReset = new System.Windows.Forms.RadioButton();
            rbtnJsonFile = new System.Windows.Forms.RadioButton();
            rtxtExample = new System.Windows.Forms.RichTextBox();
            rbtnCompactJsonFile = new System.Windows.Forms.RadioButton();
            tabPageFileDynamicsColumns = new System.Windows.Forms.TabPage();
            txtbIgnoreColumn = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDeleteIgnoreColumn = new System.Windows.Forms.Button();
            btnIgnoreColumn = new System.Windows.Forms.Button();
            lstbIgnoreColumn = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            tabControlMain = new System.Windows.Forms.TabControl();
            tabPageFiles = new System.Windows.Forms.TabPage();
            tabPageMongoDB = new System.Windows.Forms.TabPage();
            imageList32x32 = new System.Windows.Forms.ImageList(components);
            tabControlFiles.SuspendLayout();
            tabPageFilesGeneral.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPageFileParsingSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPageFileDynamicsColumns.SuspendLayout();
            panel1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageFiles.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(579, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(133, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save Settings";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExportSettings
            // 
            btnExportSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExportSettings.Location = new System.Drawing.Point(440, 6);
            btnExportSettings.Name = "btnExportSettings";
            btnExportSettings.Size = new System.Drawing.Size(133, 47);
            btnExportSettings.TabIndex = 2;
            btnExportSettings.Text = "Export Settings";
            btnExportSettings.UseVisualStyleBackColor = true;
            btnExportSettings.Click += btnExportSettings_Click;
            // 
            // txtbSupportedFiles
            // 
            txtbSupportedFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbSupportedFiles.Location = new System.Drawing.Point(276, 67);
            txtbSupportedFiles.Name = "txtbSupportedFiles";
            txtbSupportedFiles.Size = new System.Drawing.Size(423, 26);
            txtbSupportedFiles.TabIndex = 9;
            txtbSupportedFiles.Text = "*.Clef";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Location = new System.Drawing.Point(9, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(261, 50);
            label2.TabIndex = 8;
            label2.Text = "Supported Log Formats (use ; as separator):";
            // 
            // btnImport
            // 
            btnImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnImport.Location = new System.Drawing.Point(297, 6);
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(137, 47);
            btnImport.TabIndex = 10;
            btnImport.Text = "Import settings";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtbDirectory
            // 
            txtbDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbDirectory.Location = new System.Drawing.Point(276, 3);
            txtbDirectory.Name = "txtbDirectory";
            txtbDirectory.Size = new System.Drawing.Size(362, 26);
            txtbDirectory.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 18);
            label3.TabIndex = 11;
            label3.Text = "Default Logs Location:";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpenFolder.Location = new System.Drawing.Point(644, 3);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new System.Drawing.Size(55, 26);
            btnOpenFolder.TabIndex = 13;
            btnOpenFolder.Text = "...";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // rbtnCLEF
            // 
            rbtnCLEF.AutoSize = true;
            rbtnCLEF.Checked = true;
            rbtnCLEF.Location = new System.Drawing.Point(6, 25);
            rbtnCLEF.Name = "rbtnCLEF";
            rbtnCLEF.Size = new System.Drawing.Size(219, 22);
            rbtnCLEF.TabIndex = 14;
            rbtnCLEF.TabStop = true;
            rbtnCLEF.Text = "Compact Format Per line/row";
            rbtnCLEF.UseVisualStyleBackColor = true;
            // 
            // rbtnJsonPerLine
            // 
            rbtnJsonPerLine.AutoSize = true;
            rbtnJsonPerLine.Location = new System.Drawing.Point(6, 50);
            rbtnJsonPerLine.Name = "rbtnJsonPerLine";
            rbtnJsonPerLine.Size = new System.Drawing.Size(250, 22);
            rbtnJsonPerLine.TabIndex = 15;
            rbtnJsonPerLine.Text = "Standard Json format per line/row";
            rbtnJsonPerLine.UseVisualStyleBackColor = true;
            // 
            // txtbOpenFileFilters
            // 
            txtbOpenFileFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbOpenFileFilters.Location = new System.Drawing.Point(276, 35);
            txtbOpenFileFilters.Name = "txtbOpenFileFilters";
            txtbOpenFileFilters.Size = new System.Drawing.Size(362, 26);
            txtbOpenFileFilters.TabIndex = 47;
            // 
            // lblOpenfilesFilters
            // 
            lblOpenfilesFilters.AutoEllipsis = true;
            lblOpenfilesFilters.Location = new System.Drawing.Point(13, 35);
            lblOpenfilesFilters.Name = "lblOpenfilesFilters";
            lblOpenfilesFilters.Size = new System.Drawing.Size(148, 22);
            lblOpenfilesFilters.TabIndex = 46;
            lblOpenfilesFilters.Text = "Open file Filter:";
            // 
            // btnTestFilter
            // 
            btnTestFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnTestFilter.Location = new System.Drawing.Point(644, 35);
            btnTestFilter.Name = "btnTestFilter";
            btnTestFilter.Size = new System.Drawing.Size(55, 25);
            btnTestFilter.TabIndex = 48;
            btnTestFilter.Text = "Test";
            btnTestFilter.UseVisualStyleBackColor = true;
            btnTestFilter.Click += btnTestFilter_Click;
            // 
            // tabControlFiles
            // 
            tabControlFiles.Controls.Add(tabPageFilesGeneral);
            tabControlFiles.Controls.Add(tabPageFileParsingSettings);
            tabControlFiles.Controls.Add(tabPageFileDynamicsColumns);
            tabControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlFiles.ImageList = imageList32x32;
            tabControlFiles.Location = new System.Drawing.Point(3, 3);
            tabControlFiles.Name = "tabControlFiles";
            tabControlFiles.SelectedIndex = 0;
            tabControlFiles.Size = new System.Drawing.Size(711, 535);
            tabControlFiles.TabIndex = 49;
            // 
            // tabPageFilesGeneral
            // 
            tabPageFilesGeneral.Controls.Add(groupBox2);
            tabPageFilesGeneral.ImageKey = "Technology_32x32.png";
            tabPageFilesGeneral.Location = new System.Drawing.Point(4, 39);
            tabPageFilesGeneral.Name = "tabPageFilesGeneral";
            tabPageFilesGeneral.Size = new System.Drawing.Size(703, 492);
            tabPageFilesGeneral.TabIndex = 2;
            tabPageFilesGeneral.Text = "General Settings";
            tabPageFilesGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnApplicationFolder);
            groupBox2.Controls.Add(rbtnPerUser);
            groupBox2.Location = new System.Drawing.Point(14, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(683, 94);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Storage and Location";
            // 
            // rbtnApplicationFolder
            // 
            rbtnApplicationFolder.AutoSize = true;
            rbtnApplicationFolder.Location = new System.Drawing.Point(14, 54);
            rbtnApplicationFolder.Name = "rbtnApplicationFolder";
            rbtnApplicationFolder.Size = new System.Drawing.Size(540, 22);
            rbtnApplicationFolder.TabIndex = 1;
            rbtnApplicationFolder.TabStop = true;
            rbtnApplicationFolder.Text = "Portable: Store settings in the Application Folder (May need folder permissions)";
            rbtnApplicationFolder.UseVisualStyleBackColor = true;
            // 
            // rbtnPerUser
            // 
            rbtnPerUser.AutoSize = true;
            rbtnPerUser.Location = new System.Drawing.Point(14, 22);
            rbtnPerUser.Name = "rbtnPerUser";
            rbtnPerUser.Size = new System.Drawing.Size(524, 22);
            rbtnPerUser.TabIndex = 0;
            rbtnPerUser.TabStop = true;
            rbtnPerUser.Text = "Per User: Store settings in: %userprofile%\\appdata\\local\\Analogy.LogViewer";
            rbtnPerUser.UseVisualStyleBackColor = true;
            // 
            // tabPageFileParsingSettings
            // 
            tabPageFileParsingSettings.Controls.Add(rbDetectionModeManual);
            tabPageFileParsingSettings.Controls.Add(rbDetectionModeAutomatic);
            tabPageFileParsingSettings.Controls.Add(label1);
            tabPageFileParsingSettings.Controls.Add(groupBox1);
            tabPageFileParsingSettings.Controls.Add(btnTestFilter);
            tabPageFileParsingSettings.Controls.Add(txtbOpenFileFilters);
            tabPageFileParsingSettings.Controls.Add(btnOpenFolder);
            tabPageFileParsingSettings.Controls.Add(lblOpenfilesFilters);
            tabPageFileParsingSettings.Controls.Add(txtbDirectory);
            tabPageFileParsingSettings.Controls.Add(txtbSupportedFiles);
            tabPageFileParsingSettings.Controls.Add(label2);
            tabPageFileParsingSettings.Controls.Add(label3);
            tabPageFileParsingSettings.ImageKey = "EmptyTableRowSeparator_32x32.png";
            tabPageFileParsingSettings.Location = new System.Drawing.Point(4, 39);
            tabPageFileParsingSettings.Name = "tabPageFileParsingSettings";
            tabPageFileParsingSettings.Padding = new System.Windows.Forms.Padding(3);
            tabPageFileParsingSettings.Size = new System.Drawing.Size(703, 492);
            tabPageFileParsingSettings.TabIndex = 0;
            tabPageFileParsingSettings.Text = "Parsing Settings";
            tabPageFileParsingSettings.UseVisualStyleBackColor = true;
            // 
            // rbDetectionModeManual
            // 
            rbDetectionModeManual.AutoSize = true;
            rbDetectionModeManual.Location = new System.Drawing.Point(447, 120);
            rbDetectionModeManual.Name = "rbDetectionModeManual";
            rbDetectionModeManual.Size = new System.Drawing.Size(75, 22);
            rbDetectionModeManual.TabIndex = 53;
            rbDetectionModeManual.Text = "Manual";
            rbDetectionModeManual.UseVisualStyleBackColor = true;
            // 
            // rbDetectionModeAutomatic
            // 
            rbDetectionModeAutomatic.AutoSize = true;
            rbDetectionModeAutomatic.Checked = true;
            rbDetectionModeAutomatic.Location = new System.Drawing.Point(276, 120);
            rbDetectionModeAutomatic.Name = "rbDetectionModeAutomatic";
            rbDetectionModeAutomatic.Size = new System.Drawing.Size(94, 22);
            rbDetectionModeAutomatic.TabIndex = 52;
            rbDetectionModeAutomatic.TabStop = true;
            rbDetectionModeAutomatic.Text = "Automatic";
            rbDetectionModeAutomatic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Location = new System.Drawing.Point(13, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(148, 22);
            label1.TabIndex = 51;
            label1.Text = "File Detection Mode:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(rbtnReset);
            groupBox1.Controls.Add(rbtnJsonFile);
            groupBox1.Controls.Add(rtxtExample);
            groupBox1.Controls.Add(rbtnCLEF);
            groupBox1.Controls.Add(rbtnCompactJsonFile);
            groupBox1.Controls.Add(rbtnJsonPerLine);
            groupBox1.Location = new System.Drawing.Point(13, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(681, 338);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Format:";
            // 
            // rbtnReset
            // 
            rbtnReset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rbtnReset.AutoSize = true;
            rbtnReset.Location = new System.Drawing.Point(509, 25);
            rbtnReset.Name = "rbtnReset";
            rbtnReset.Size = new System.Drawing.Size(148, 22);
            rbtnReset.TabIndex = 52;
            rbtnReset.Text = "Reset to Unknown";
            rbtnReset.UseVisualStyleBackColor = true;
            // 
            // rbtnJsonFile
            // 
            rbtnJsonFile.AutoSize = true;
            rbtnJsonFile.Location = new System.Drawing.Point(6, 106);
            rbtnJsonFile.Name = "rbtnJsonFile";
            rbtnJsonFile.Size = new System.Drawing.Size(214, 22);
            rbtnJsonFile.TabIndex = 51;
            rbtnJsonFile.Text = "Standard format full Json file";
            rbtnJsonFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            rbtnJsonFile.UseVisualStyleBackColor = true;
            // 
            // rtxtExample
            // 
            rtxtExample.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            rtxtExample.Location = new System.Drawing.Point(6, 147);
            rtxtExample.Name = "rtxtExample";
            rtxtExample.Size = new System.Drawing.Size(669, 184);
            rtxtExample.TabIndex = 50;
            rtxtExample.Text = "";
            // 
            // rbtnCompactJsonFile
            // 
            rbtnCompactJsonFile.AutoSize = true;
            rbtnCompactJsonFile.Location = new System.Drawing.Point(6, 78);
            rbtnCompactJsonFile.Name = "rbtnCompactJsonFile";
            rbtnCompactJsonFile.Size = new System.Drawing.Size(214, 22);
            rbtnCompactJsonFile.TabIndex = 49;
            rbtnCompactJsonFile.Text = "Compact format full Json file";
            rbtnCompactJsonFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
            rbtnCompactJsonFile.UseVisualStyleBackColor = true;
            // 
            // tabPageFileDynamicsColumns
            // 
            tabPageFileDynamicsColumns.Controls.Add(txtbIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(label4);
            tabPageFileDynamicsColumns.Controls.Add(btnDeleteIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(btnIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(lstbIgnoreColumn);
            tabPageFileDynamicsColumns.ImageKey = "GridColumnHeader_32x32.png";
            tabPageFileDynamicsColumns.Location = new System.Drawing.Point(4, 39);
            tabPageFileDynamicsColumns.Name = "tabPageFileDynamicsColumns";
            tabPageFileDynamicsColumns.Padding = new System.Windows.Forms.Padding(3);
            tabPageFileDynamicsColumns.Size = new System.Drawing.Size(703, 492);
            tabPageFileDynamicsColumns.TabIndex = 1;
            tabPageFileDynamicsColumns.Text = "Dynamic Columns";
            tabPageFileDynamicsColumns.UseVisualStyleBackColor = true;
            // 
            // txtbIgnoreColumn
            // 
            txtbIgnoreColumn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtbIgnoreColumn.Location = new System.Drawing.Point(6, 46);
            txtbIgnoreColumn.Name = "txtbIgnoreColumn";
            txtbIgnoreColumn.Size = new System.Drawing.Size(635, 26);
            txtbIgnoreColumn.TabIndex = 63;
            // 
            // label4
            // 
            label4.AccessibleDescription = "";
            label4.AutoEllipsis = true;
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.Location = new System.Drawing.Point(3, 3);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(697, 24);
            label4.TabIndex = 62;
            label4.Text = "Dynamic columns: Ignore the following entries in the dynamic columns generation:";
            // 
            // btnDeleteIgnoreColumn
            // 
            btnDeleteIgnoreColumn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteIgnoreColumn.Location = new System.Drawing.Point(601, 133);
            btnDeleteIgnoreColumn.Name = "btnDeleteIgnoreColumn";
            btnDeleteIgnoreColumn.Size = new System.Drawing.Size(93, 25);
            btnDeleteIgnoreColumn.TabIndex = 61;
            btnDeleteIgnoreColumn.Text = "Delete";
            btnDeleteIgnoreColumn.UseVisualStyleBackColor = true;
            btnDeleteIgnoreColumn.Click += btnDeleteIgnoreColumn_Click;
            // 
            // btnIgnoreColumn
            // 
            btnIgnoreColumn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnIgnoreColumn.Location = new System.Drawing.Point(647, 46);
            btnIgnoreColumn.Name = "btnIgnoreColumn";
            btnIgnoreColumn.Size = new System.Drawing.Size(47, 25);
            btnIgnoreColumn.TabIndex = 60;
            btnIgnoreColumn.Text = "Add";
            btnIgnoreColumn.UseVisualStyleBackColor = true;
            btnIgnoreColumn.Click += btnIgnoreColumn_Click;
            // 
            // lstbIgnoreColumn
            // 
            lstbIgnoreColumn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstbIgnoreColumn.FormattingEnabled = true;
            lstbIgnoreColumn.ItemHeight = 18;
            lstbIgnoreColumn.Location = new System.Drawing.Point(6, 78);
            lstbIgnoreColumn.Name = "lstbIgnoreColumn";
            lstbIgnoreColumn.Size = new System.Drawing.Size(589, 472);
            lstbIgnoreColumn.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnExportSettings);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 584);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(725, 56);
            panel1.TabIndex = 50;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageFiles);
            tabControlMain.Controls.Add(tabPageMongoDB);
            tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlMain.ImageList = imageList32x32;
            tabControlMain.Location = new System.Drawing.Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new System.Drawing.Size(725, 584);
            tabControlMain.TabIndex = 1;
            // 
            // tabPageFiles
            // 
            tabPageFiles.Controls.Add(tabControlFiles);
            tabPageFiles.ImageKey = "ListBox_32x32.png";
            tabPageFiles.Location = new System.Drawing.Point(4, 39);
            tabPageFiles.Name = "tabPageFiles";
            tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            tabPageFiles.Size = new System.Drawing.Size(717, 541);
            tabPageFiles.TabIndex = 0;
            tabPageFiles.Text = "File Settings";
            tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // tabPageMongoDB
            // 
            tabPageMongoDB.ImageKey = "ManageDatasource_32x32.png";
            tabPageMongoDB.Location = new System.Drawing.Point(4, 39);
            tabPageMongoDB.Name = "tabPageMongoDB";
            tabPageMongoDB.Padding = new System.Windows.Forms.Padding(3);
            tabPageMongoDB.Size = new System.Drawing.Size(717, 541);
            tabPageMongoDB.TabIndex = 1;
            tabPageMongoDB.Text = "MongoDB Settings";
            tabPageMongoDB.UseVisualStyleBackColor = true;
            // 
            // imageList32x32
            // 
            imageList32x32.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList32x32.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList32x32.ImageStream");
            imageList32x32.TransparentColor = System.Drawing.Color.Transparent;
            imageList32x32.Images.SetKeyName(0, "Technology_32x32.png");
            imageList32x32.Images.SetKeyName(1, "ListBox_32x32.png");
            imageList32x32.Images.SetKeyName(2, "GridColumnHeader_32x32.png");
            imageList32x32.Images.SetKeyName(3, "EmptyTableRowSeparator_32x32.png");
            imageList32x32.Images.SetKeyName(4, "ManageDatasource_32x32.png");
            // 
            // SerilogUCSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tabControlMain);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "ECSUCSettings";
            Size = new System.Drawing.Size(725, 640);
            Load += SerilogUCSettings_Load;
            tabControlFiles.ResumeLayout(false);
            tabPageFilesGeneral.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPageFileParsingSettings.ResumeLayout(false);
            tabPageFileParsingSettings.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPageFileDynamicsColumns.ResumeLayout(false);
            tabPageFileDynamicsColumns.PerformLayout();
            panel1.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.TextBox txtbSupportedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtbDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.RadioButton rbtnCLEF;
        private System.Windows.Forms.RadioButton rbtnJsonPerLine;
        private System.Windows.Forms.TextBox txtbOpenFileFilters;
        private System.Windows.Forms.Label lblOpenfilesFilters;
        private System.Windows.Forms.Button btnTestFilter;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.TabPage tabPageFileParsingSettings;
        private System.Windows.Forms.TabPage tabPageFileDynamicsColumns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbIgnoreColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteIgnoreColumn;
        private System.Windows.Forms.Button btnIgnoreColumn;
        private System.Windows.Forms.ListBox lstbIgnoreColumn;
        private System.Windows.Forms.RadioButton rbtnCompactJsonFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDetectionModeAutomatic;
        private System.Windows.Forms.RadioButton rbDetectionModeManual;
        private System.Windows.Forms.RadioButton rbtnJsonFile;
        private System.Windows.Forms.RadioButton rbtnReset;
        private System.Windows.Forms.TabPage tabPageFilesGeneral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnPerUser;
        private System.Windows.Forms.RadioButton rbtnApplicationFolder;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.TabPage tabPageMongoDB;
        private System.Windows.Forms.ImageList imageList32x32;
    }
}
