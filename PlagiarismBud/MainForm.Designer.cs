namespace PlagiarismBud
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lvFiles = new BrightIdeasSoftware.FastObjectListView();
            this.olvFileName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFileLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFileCreated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvFileModified = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmsFileSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbCreated = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnImportPCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lvFiles)).BeginInit();
            this.cmsFileSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(146, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lvFiles
            // 
            this.lvFiles.AllColumns.Add(this.olvFileName);
            this.lvFiles.AllColumns.Add(this.olvFileLocation);
            this.lvFiles.AllColumns.Add(this.olvFileCreated);
            this.lvFiles.AllColumns.Add(this.olvFileModified);
            this.lvFiles.CellEditUseWholeCell = false;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvFileName,
            this.olvFileLocation,
            this.olvFileCreated,
            this.olvFileModified});
            this.lvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(12, 41);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.ShowGroups = false;
            this.lvFiles.Size = new System.Drawing.Size(450, 112);
            this.lvFiles.TabIndex = 1;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.VirtualMode = true;
            // 
            // olvFileName
            // 
            this.olvFileName.AspectName = "FileName";
            this.olvFileName.Text = "File Name";
            this.olvFileName.Width = 93;
            // 
            // olvFileLocation
            // 
            this.olvFileLocation.AspectName = "FileLocation";
            this.olvFileLocation.Text = "File Location";
            this.olvFileLocation.Width = 91;
            // 
            // olvFileCreated
            // 
            this.olvFileCreated.AspectName = "FileCreatedS";
            this.olvFileCreated.Text = "Date Created";
            this.olvFileCreated.Width = 114;
            // 
            // olvFileModified
            // 
            this.olvFileModified.AspectName = "FileModifiedS";
            this.olvFileModified.Text = "Date Modified";
            this.olvFileModified.Width = 124;
            // 
            // cmsFileSettings
            // 
            this.cmsFileSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.extractToolStripMenuItem});
            this.cmsFileSettings.Name = "cmsFileSettings";
            this.cmsFileSettings.Size = new System.Drawing.Size(114, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.selectedToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.filesToolStripMenuItem.Text = "Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.fileToolStripMenuItem.Text = "File/s";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPagesToolStripMenuItem,
            this.currentPageToolStripMenuItem});
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.extractToolStripMenuItem.Text = "Extract ";
            // 
            // allPagesToolStripMenuItem
            // 
            this.allPagesToolStripMenuItem.Name = "allPagesToolStripMenuItem";
            this.allPagesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allPagesToolStripMenuItem.Text = "All Pages";
            this.allPagesToolStripMenuItem.Click += new System.EventHandler(this.allPagesToolStripMenuItem_Click);
            // 
            // currentPageToolStripMenuItem
            // 
            this.currentPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedEntriesToolStripMenuItem,
            this.allEntriesToolStripMenuItem});
            this.currentPageToolStripMenuItem.Name = "currentPageToolStripMenuItem";
            this.currentPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentPageToolStripMenuItem.Text = "Current Page";
            // 
            // selectedEntriesToolStripMenuItem
            // 
            this.selectedEntriesToolStripMenuItem.Name = "selectedEntriesToolStripMenuItem";
            this.selectedEntriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectedEntriesToolStripMenuItem.Text = "Selected Entries";
            this.selectedEntriesToolStripMenuItem.Click += new System.EventHandler(this.selectedEntriesToolStripMenuItem_Click);
            // 
            // allEntriesToolStripMenuItem
            // 
            this.allEntriesToolStripMenuItem.Name = "allEntriesToolStripMenuItem";
            this.allEntriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allEntriesToolStripMenuItem.Text = "All Entries";
            this.allEntriesToolStripMenuItem.Click += new System.EventHandler(this.allEntriesToolStripMenuItem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(358, 159);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "[Page 0] Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Location = new System.Drawing.Point(12, 164);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(228, 13);
            this.lbCreated.TabIndex = 3;
            this.lbCreated.Text = "Oscar Evans (C) 2019 / Github.com [GNU v3]";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(248, 159);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(104, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "[Page 0] Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Visible = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(164, 12);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(146, 23);
            this.btnSelectFiles.TabIndex = 5;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnImportPCheck
            // 
            this.btnImportPCheck.Location = new System.Drawing.Point(316, 12);
            this.btnImportPCheck.Name = "btnImportPCheck";
            this.btnImportPCheck.Size = new System.Drawing.Size(146, 23);
            this.btnImportPCheck.TabIndex = 6;
            this.btnImportPCheck.Text = "Import PCheck";
            this.btnImportPCheck.UseVisualStyleBackColor = true;
            this.btnImportPCheck.Click += new System.EventHandler(this.btnImportPCheck_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 188);
            this.Controls.Add(this.btnImportPCheck);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnSelectFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Plagiarism Checker";
            ((System.ComponentModel.ISupportInitialize)(this.lvFiles)).EndInit();
            this.cmsFileSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private BrightIdeasSoftware.FastObjectListView lvFiles;
        private BrightIdeasSoftware.OLVColumn olvFileName;
        private BrightIdeasSoftware.OLVColumn olvFileLocation;
        private BrightIdeasSoftware.OLVColumn olvFileCreated;
        private BrightIdeasSoftware.OLVColumn olvFileModified;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ContextMenuStrip cmsFileSettings;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEntriesToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Button btnImportPCheck;
    }
}

