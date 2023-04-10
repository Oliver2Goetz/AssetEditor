﻿namespace AlienPAK
{
    partial class Explorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkAllDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPAK2FromDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addFile = new System.Windows.Forms.Button();
            this.removeFile = new System.Windows.Forms.Button();
            this.importFile = new System.Windows.Forms.Button();
            this.exportFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FileTree = new System.Windows.Forms.TreeView();
            this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileContext = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.filePreviewImage = new System.Windows.Forms.PictureBox();
            this.filePreviewGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileTypeInfo = new System.Windows.Forms.Label();
            this.fileSizeInfo = new System.Windows.Forms.Label();
            this.fileNameInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.env_list = new System.Windows.Forms.ComboBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.explorerControlsWPF1 = new AlienPAK.ExplorerControlsWPF();
            this.menuStrip1.SuspendLayout();
            this.fileContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filePreviewImage)).BeginInit();
            this.filePreviewGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.importFileToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportAllFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openToolStripMenuItem.Text = "Open PAK";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.importFileToolStripMenuItem.Text = "Import Selected File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportFileToolStripMenuItem.Text = "Export Selected File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // exportAllFilesToolStripMenuItem
            // 
            this.exportAllFilesToolStripMenuItem.Name = "exportAllFilesToolStripMenuItem";
            this.exportAllFilesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exportAllFilesToolStripMenuItem.Text = "Export All Files";
            this.exportAllFilesToolStripMenuItem.Click += new System.EventHandler(this.exportAllFilesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllDirectoriesToolStripMenuItem,
            this.shrinkAllDirectoriesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // expandAllDirectoriesToolStripMenuItem
            // 
            this.expandAllDirectoriesToolStripMenuItem.Name = "expandAllDirectoriesToolStripMenuItem";
            this.expandAllDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.expandAllDirectoriesToolStripMenuItem.Text = "Expand All Directories";
            this.expandAllDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.expandAllDirectoriesToolStripMenuItem_Click);
            // 
            // shrinkAllDirectoriesToolStripMenuItem
            // 
            this.shrinkAllDirectoriesToolStripMenuItem.Name = "shrinkAllDirectoriesToolStripMenuItem";
            this.shrinkAllDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.shrinkAllDirectoriesToolStripMenuItem.Text = "Shrink All Directories";
            this.shrinkAllDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.shrinkAllDirectoriesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPAK2FromDirectoryToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createPAK2FromDirectoryToolStripMenuItem
            // 
            this.createPAK2FromDirectoryToolStripMenuItem.Name = "createPAK2FromDirectoryToolStripMenuItem";
            this.createPAK2FromDirectoryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.createPAK2FromDirectoryToolStripMenuItem.Text = "Create PAK2 From Directory";
            this.createPAK2FromDirectoryToolStripMenuItem.Click += new System.EventHandler(this.createPAK2FromDirectoryToolStripMenuItem_Click);
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(6, 21);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(265, 24);
            this.addFile.TabIndex = 0;
            this.addFile.Text = "Import New File";
            this.toolTip1.SetToolTip(this.addFile, "Add a new file to the current PAK archive.");
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.AddFileToArchive_Click);
            // 
            // removeFile
            // 
            this.removeFile.Enabled = false;
            this.removeFile.Location = new System.Drawing.Point(6, 51);
            this.removeFile.Name = "removeFile";
            this.removeFile.Size = new System.Drawing.Size(265, 24);
            this.removeFile.TabIndex = 1;
            this.removeFile.Text = "Delete Selected File";
            this.toolTip1.SetToolTip(this.removeFile, "With a file selected, press this button to delete it from the archive.");
            this.removeFile.UseVisualStyleBackColor = true;
            this.removeFile.Click += new System.EventHandler(this.RemoveFileFromArchive_Click);
            // 
            // importFile
            // 
            this.importFile.Enabled = false;
            this.importFile.Location = new System.Drawing.Point(139, 21);
            this.importFile.Name = "importFile";
            this.importFile.Size = new System.Drawing.Size(132, 24);
            this.importFile.TabIndex = 1;
            this.importFile.Text = "Replace Selected";
            this.toolTip1.SetToolTip(this.importFile, "With a file selected, press this button to replace it with a new file.");
            this.importFile.UseVisualStyleBackColor = true;
            this.importFile.Click += new System.EventHandler(this.importFile_Click);
            // 
            // exportFile
            // 
            this.exportFile.Enabled = false;
            this.exportFile.Location = new System.Drawing.Point(6, 21);
            this.exportFile.Name = "exportFile";
            this.exportFile.Size = new System.Drawing.Size(132, 24);
            this.exportFile.TabIndex = 0;
            this.exportFile.Text = "Export Selected";
            this.toolTip1.SetToolTip(this.exportFile, "With a file selected, press this to export it from the archive.");
            this.exportFile.UseVisualStyleBackColor = true;
            this.exportFile.Click += new System.EventHandler(this.exportFile_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(218, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.toolTip1.SetToolTip(this.button1, "With a file selected, press this button to delete it from the archive.");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FileTree
            // 
            this.FileTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileTree.Location = new System.Drawing.Point(-1, 24);
            this.FileTree.Name = "FileTree";
            this.FileTree.Size = new System.Drawing.Size(500, 679);
            this.FileTree.TabIndex = 5;
            this.FileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileTree_AfterSelect);
            // 
            // fileContextMenu
            // 
            this.fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileContext,
            this.exportFileContext});
            this.fileContextMenu.Name = "fileContextMenu";
            this.fileContextMenu.Size = new System.Drawing.Size(132, 48);
            // 
            // importFileContext
            // 
            this.importFileContext.Name = "importFileContext";
            this.importFileContext.Size = new System.Drawing.Size(131, 22);
            this.importFileContext.Text = "Import File";
            this.importFileContext.Click += new System.EventHandler(this.importFileContext_Click);
            // 
            // exportFileContext
            // 
            this.exportFileContext.Name = "exportFileContext";
            this.exportFileContext.Size = new System.Drawing.Size(131, 22);
            this.exportFileContext.Text = "Export File";
            this.exportFileContext.Click += new System.EventHandler(this.exportFileContext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "directory_icon.png");
            this.imageList1.Images.SetKeyName(1, "file_icon.png");
            this.imageList1.Images.SetKeyName(2, "text_icon.png");
            // 
            // filePreviewImage
            // 
            this.filePreviewImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filePreviewImage.Location = new System.Drawing.Point(6, 19);
            this.filePreviewImage.Name = "filePreviewImage";
            this.filePreviewImage.Size = new System.Drawing.Size(265, 242);
            this.filePreviewImage.TabIndex = 7;
            this.filePreviewImage.TabStop = false;
            // 
            // filePreviewGroup
            // 
            this.filePreviewGroup.Controls.Add(this.filePreviewImage);
            this.filePreviewGroup.Location = new System.Drawing.Point(505, 27);
            this.filePreviewGroup.Name = "filePreviewGroup";
            this.filePreviewGroup.Size = new System.Drawing.Size(277, 267);
            this.filePreviewGroup.TabIndex = 8;
            this.filePreviewGroup.TabStop = false;
            this.filePreviewGroup.Text = "File Preview";
            this.filePreviewGroup.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileTypeInfo);
            this.groupBox2.Controls.Add(this.fileSizeInfo);
            this.groupBox2.Controls.Add(this.fileNameInfo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(505, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Info";
            // 
            // fileTypeInfo
            // 
            this.fileTypeInfo.AutoSize = true;
            this.fileTypeInfo.Location = new System.Drawing.Point(55, 61);
            this.fileTypeInfo.Name = "fileTypeInfo";
            this.fileTypeInfo.Size = new System.Drawing.Size(0, 13);
            this.fileTypeInfo.TabIndex = 15;
            // 
            // fileSizeInfo
            // 
            this.fileSizeInfo.AutoSize = true;
            this.fileSizeInfo.Location = new System.Drawing.Point(55, 43);
            this.fileSizeInfo.Name = "fileSizeInfo";
            this.fileSizeInfo.Size = new System.Drawing.Size(0, 13);
            this.fileSizeInfo.TabIndex = 14;
            // 
            // fileNameInfo
            // 
            this.fileNameInfo.AutoSize = true;
            this.fileNameInfo.Location = new System.Drawing.Point(55, 26);
            this.fileNameInfo.Name = "fileNameInfo";
            this.fileNameInfo.Size = new System.Drawing.Size(0, 13);
            this.fileNameInfo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeFile);
            this.groupBox3.Controls.Add(this.addFile);
            this.groupBox3.Location = new System.Drawing.Point(505, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 82);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Archive Utilities";
            this.groupBox3.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.importFile);
            this.groupBox5.Controls.Add(this.exportFile);
            this.groupBox5.Location = new System.Drawing.Point(505, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 54);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "File Utilities";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.env_list);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(505, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 51);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Level";
            this.groupBox4.Visible = false;
            // 
            // env_list
            // 
            this.env_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.env_list.FormattingEnabled = true;
            this.env_list.Location = new System.Drawing.Point(6, 20);
            this.env_list.Name = "env_list";
            this.env_list.Size = new System.Drawing.Size(206, 21);
            this.env_list.TabIndex = 174;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(788, 27);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(277, 676);
            this.elementHost1.TabIndex = 17;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.explorerControlsWPF1;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 703);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.filePreviewGroup);
            this.Controls.Add(this.FileTree);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Explorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alien: Isolation PAK Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fileContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filePreviewImage)).EndInit();
            this.filePreviewGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkAllDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportFileContext;
        private System.Windows.Forms.ToolStripMenuItem importFileContext;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox filePreviewImage;
        private System.Windows.Forms.GroupBox filePreviewGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fileTypeInfo;
        private System.Windows.Forms.Label fileSizeInfo;
        private System.Windows.Forms.Label fileNameInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportAllFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPAK2FromDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button removeFile;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button importFile;
        private System.Windows.Forms.Button exportFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox env_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private ExplorerControlsWPF explorerControlsWPF1;
    }
}

