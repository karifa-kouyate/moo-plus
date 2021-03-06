﻿namespace Moo
{
    partial class FBrunchBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBrunchBrowser));
            this.BrunchBrowserTree = new Moo.Controls.BrunchBrowser();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshBrunch = new System.Windows.Forms.ToolStripButton();
            this.AddBrunch = new System.Windows.Forms.ToolStripButton();
            this.EditBrunch = new System.Windows.Forms.ToolStripButton();
            this.InsertBrunch = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrunchBrowserTree
            // 
            this.BrunchBrowserTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BrunchBrowserTree.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BrunchBrowserTree.ImageIndex = 0;
            this.BrunchBrowserTree.Location = new System.Drawing.Point(0, 24);
            this.BrunchBrowserTree.Name = "BrunchBrowserTree";
            this.BrunchBrowserTree.SelectedImageIndex = 0;
            this.BrunchBrowserTree.ShowRootLines = false;
            this.BrunchBrowserTree.Size = new System.Drawing.Size(216, 240);
            this.BrunchBrowserTree.TabIndex = 1;
            this.BrunchBrowserTree.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.RequestInsertSelectedBrunchNode);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackgroundImage = global::Moo.Properties.Resources.Tbackground;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshBrunch,
            this.AddBrunch,
            this.EditBrunch,
            this.InsertBrunch});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(216, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // RefreshBrunch
            // 
            this.RefreshBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshBrunch.Image = global::Moo.Properties.Resources.Refresh;
            this.RefreshBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBrunch.Name = "RefreshBrunch";
            this.RefreshBrunch.Size = new System.Drawing.Size(23, 22);
            this.RefreshBrunch.Text = "Refresh View";
            this.RefreshBrunch.Click += new System.EventHandler(this.RefreshView);
            // 
            // AddBrunch
            // 
            this.AddBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddBrunch.Image = global::Moo.Properties.Resources.Add;
            this.AddBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBrunch.Name = "AddBrunch";
            this.AddBrunch.Size = new System.Drawing.Size(23, 22);
            this.AddBrunch.Text = "Add Brunch";
            this.AddBrunch.Click += new System.EventHandler(this.BrunchEditor);
            // 
            // EditBrunch
            // 
            this.EditBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditBrunch.Image = global::Moo.Properties.Resources.Edit;
            this.EditBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBrunch.Name = "EditBrunch";
            this.EditBrunch.Size = new System.Drawing.Size(23, 22);
            this.EditBrunch.Text = "Edit Brunch";
            this.EditBrunch.Click += new System.EventHandler(this.BrunchEditor);
            // 
            // InsertBrunch
            // 
            this.InsertBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.InsertBrunch.Image = global::Moo.Properties.Resources.Insert;
            this.InsertBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InsertBrunch.Name = "InsertBrunch";
            this.InsertBrunch.Size = new System.Drawing.Size(23, 22);
            this.InsertBrunch.Text = "Insert Brunch";
            this.InsertBrunch.Click += new System.EventHandler(this.InsertBrunchHandler);
            // 
            // FBrunchBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 264);
            this.Controls.Add(this.BrunchBrowserTree);
            this.Controls.Add(this.ToolStrip);
            this.DockAreas = ((Yalamo.Gui.Dock.DockAreas)(((Yalamo.Gui.Dock.DockAreas.Float | Yalamo.Gui.Dock.DockAreas.DockLeft)
                        | Yalamo.Gui.Dock.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBrunchBrowser";
            this.TabText = "Brunch Browser";
            this.Text = "Brunch Browser";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddBrunch;
        private System.Windows.Forms.ToolStripButton RefreshBrunch;
        private Moo.Controls.BrunchBrowser BrunchBrowserTree;
        private System.Windows.Forms.ToolStripButton EditBrunch;
        private System.Windows.Forms.ToolStripButton InsertBrunch;
    }
}