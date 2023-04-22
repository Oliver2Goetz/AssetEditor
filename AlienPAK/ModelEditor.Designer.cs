﻿namespace AlienPAK
{
    partial class ModelEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelEditor));
            this.FileTree = new System.Windows.Forms.TreeView();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.modelEditorControlsWPF1 = new AlienPAK.ModelEditorControlsWPF();
            this.SuspendLayout();
            // 
            // FileTree
            // 
            this.FileTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileTree.Location = new System.Drawing.Point(1, 1);
            this.FileTree.Name = "FileTree";
            this.FileTree.Size = new System.Drawing.Size(500, 679);
            this.FileTree.TabIndex = 6;
            this.FileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FileTree_AfterSelect);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(507, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(600, 676);
            this.elementHost1.TabIndex = 18;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.modelEditorControlsWPF1;
            // 
            // ModelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 681);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.FileTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModelEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private ModelEditorControlsWPF modelEditorControlsWPF1;
    }
}