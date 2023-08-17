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
            btnImport = new System.Windows.Forms.Button();
            tabControlFiles = new System.Windows.Forms.TabControl();
            tabPageFileDynamicsColumns = new System.Windows.Forms.TabPage();
            txtbIgnoreColumn = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnDeleteIgnoreColumn = new System.Windows.Forms.Button();
            btnIgnoreColumn = new System.Windows.Forms.Button();
            lstbAdditionalColumn = new System.Windows.Forms.ListBox();
            imageList32x32 = new System.Windows.Forms.ImageList(components);
            panel1 = new System.Windows.Forms.Panel();
            tabControlMain = new System.Windows.Forms.TabControl();
            tabPageFiles = new System.Windows.Forms.TabPage();
            cbShowAllMetadataFields = new System.Windows.Forms.CheckBox();
            tabControlFiles.SuspendLayout();
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
            // tabControlFiles
            // 
            tabControlFiles.Controls.Add(tabPageFileDynamicsColumns);
            tabControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlFiles.ImageList = imageList32x32;
            tabControlFiles.Location = new System.Drawing.Point(3, 3);
            tabControlFiles.Name = "tabControlFiles";
            tabControlFiles.SelectedIndex = 0;
            tabControlFiles.Size = new System.Drawing.Size(711, 535);
            tabControlFiles.TabIndex = 49;
            // 
            // tabPageFileDynamicsColumns
            // 
            tabPageFileDynamicsColumns.Controls.Add(cbShowAllMetadataFields);
            tabPageFileDynamicsColumns.Controls.Add(txtbIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(label4);
            tabPageFileDynamicsColumns.Controls.Add(btnDeleteIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(btnIgnoreColumn);
            tabPageFileDynamicsColumns.Controls.Add(lstbAdditionalColumn);
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
            txtbIgnoreColumn.Location = new System.Drawing.Point(6, 81);
            txtbIgnoreColumn.Name = "txtbIgnoreColumn";
            txtbIgnoreColumn.Size = new System.Drawing.Size(635, 26);
            txtbIgnoreColumn.TabIndex = 63;
            // 
            // label4
            // 
            label4.AccessibleDescription = "";
            label4.AutoEllipsis = true;
            label4.Location = new System.Drawing.Point(3, 53);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(697, 24);
            label4.TabIndex = 62;
            label4.Text = "Show The following Columns from metadata Fields:";
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
            btnIgnoreColumn.Location = new System.Drawing.Point(647, 81);
            btnIgnoreColumn.Name = "btnIgnoreColumn";
            btnIgnoreColumn.Size = new System.Drawing.Size(47, 25);
            btnIgnoreColumn.TabIndex = 60;
            btnIgnoreColumn.Text = "Add";
            btnIgnoreColumn.UseVisualStyleBackColor = true;
            btnIgnoreColumn.Click += btnIgnoreColumn_Click;
            // 
            // lstbAdditionalColumn
            // 
            lstbAdditionalColumn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstbAdditionalColumn.FormattingEnabled = true;
            lstbAdditionalColumn.ItemHeight = 18;
            lstbAdditionalColumn.Location = new System.Drawing.Point(6, 114);
            lstbAdditionalColumn.Name = "lstbAdditionalColumn";
            lstbAdditionalColumn.Size = new System.Drawing.Size(589, 436);
            lstbAdditionalColumn.TabIndex = 59;
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
            tabPageFiles.Text = "ECS Settings";
            tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // cbShowAllMetadataFields
            // 
            cbShowAllMetadataFields.AutoSize = true;
            cbShowAllMetadataFields.Location = new System.Drawing.Point(10, 10);
            cbShowAllMetadataFields.Name = "cbShowAllMetadataFields";
            cbShowAllMetadataFields.Size = new System.Drawing.Size(186, 22);
            cbShowAllMetadataFields.TabIndex = 64;
            cbShowAllMetadataFields.Text = "Show all metadata fields";
            cbShowAllMetadataFields.UseVisualStyleBackColor = true;
            // 
            // ECSUCSettings
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
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TabControl tabControlFiles;
        private System.Windows.Forms.TabPage tabPageFileDynamicsColumns;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbIgnoreColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteIgnoreColumn;
        private System.Windows.Forms.Button btnIgnoreColumn;
        private System.Windows.Forms.ListBox lstbAdditionalColumn;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.ImageList imageList32x32;
        private System.Windows.Forms.CheckBox cbShowAllMetadataFields;
    }
}
