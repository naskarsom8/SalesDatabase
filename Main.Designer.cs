using System;

namespace Sales_Commission
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mStrip_Main = new System.Windows.Forms.MenuStrip();
            this.cntxtMenuStrp_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelUploadsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hierarchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flexibleUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesExtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hierarchyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip_Main.SuspendLayout();
            this.cntxtMenuStrp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip_Main
            // 
            this.mStrip_Main.ContextMenuStrip = this.cntxtMenuStrp_Main;
            this.mStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.uploadsToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.mStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.mStrip_Main.Name = "mStrip_Main";
            this.mStrip_Main.Size = new System.Drawing.Size(757, 24);
            this.mStrip_Main.TabIndex = 0;
            this.mStrip_Main.Text = "Main Menu Strip";
            // 
            // cntxtMenuStrp_Main
            // 
            this.cntxtMenuStrp_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem1,
            this.uploadsToolStripMenuItem1,
            this.manageToolStripMenuItem1});
            this.cntxtMenuStrp_Main.Name = "cntxtMenuStrp_Main";
            this.cntxtMenuStrp_Main.Size = new System.Drawing.Size(153, 92);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjustmentsToolStripMenuItem,
            this.extractsToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // adjustmentsToolStripMenuItem
            // 
            this.adjustmentsToolStripMenuItem.Name = "adjustmentsToolStripMenuItem";
            this.adjustmentsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.adjustmentsToolStripMenuItem.Text = "Adjustments";
            this.adjustmentsToolStripMenuItem.Click += new System.EventHandler(this.adjustmentsToolStripMenuItem_Click);
            // 
            // extractsToolStripMenuItem
            // 
            this.extractsToolStripMenuItem.Name = "extractsToolStripMenuItem";
            this.extractsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.extractsToolStripMenuItem.Text = "Extracts";
            this.extractsToolStripMenuItem.Click += new System.EventHandler(this.extractsToolStripMenuItem_Click);
            // 
            // uploadsToolStripMenuItem1
            // 
            this.uploadsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelUploadsToolStripMenuItem1});
            this.uploadsToolStripMenuItem1.Name = "uploadsToolStripMenuItem1";
            this.uploadsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.uploadsToolStripMenuItem1.Text = "Uploads";
            // 
            // excelUploadsToolStripMenuItem1
            // 
            this.excelUploadsToolStripMenuItem1.Name = "excelUploadsToolStripMenuItem1";
            this.excelUploadsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.excelUploadsToolStripMenuItem1.Text = "Excel Uploads";
            this.excelUploadsToolStripMenuItem1.Click += new System.EventHandler(this.excelUploadsToolStripMenuItem1_Click);
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissionsToolStripMenuItem,
            this.associatesToolStripMenuItem1,
            this.hierarchyToolStripMenuItem,
            this.ordersToolStripMenuItem1});
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.manageToolStripMenuItem1.Text = "Manage";
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions";
            // 
            // associatesToolStripMenuItem1
            // 
            this.associatesToolStripMenuItem1.Name = "associatesToolStripMenuItem1";
            this.associatesToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.associatesToolStripMenuItem1.Text = "Associates";
            // 
            // hierarchyToolStripMenuItem
            // 
            this.hierarchyToolStripMenuItem.Name = "hierarchyToolStripMenuItem";
            this.hierarchyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hierarchyToolStripMenuItem.Text = "Hierarchy";
            this.hierarchyToolStripMenuItem.Click += new System.EventHandler(this.hierarchyToolStripMenuItem_Click_1);
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ordersToolStripMenuItem1.Text = "Orders";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.ordersToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flexibleUploadToolStripMenuItem,
            this.salesExtractToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportsToolStripMenuItem.Image")));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // flexibleUploadToolStripMenuItem
            // 
            this.flexibleUploadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flexibleUploadToolStripMenuItem.Image")));
            this.flexibleUploadToolStripMenuItem.Name = "flexibleUploadToolStripMenuItem";
            this.flexibleUploadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.flexibleUploadToolStripMenuItem.Text = "Adjustments";
            this.flexibleUploadToolStripMenuItem.Click += new System.EventHandler(this.flexibleUploadToolStripMenuItem_Click);
            // 
            // salesExtractToolStripMenuItem
            // 
            this.salesExtractToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salesExtractToolStripMenuItem.Image")));
            this.salesExtractToolStripMenuItem.Name = "salesExtractToolStripMenuItem";
            this.salesExtractToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.salesExtractToolStripMenuItem.Text = "Extracts";
            this.salesExtractToolStripMenuItem.Click += new System.EventHandler(this.salesExtractToolStripMenuItem_Click);
            // 
            // uploadsToolStripMenuItem
            // 
            this.uploadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem});
            this.uploadsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uploadsToolStripMenuItem.Image")));
            this.uploadsToolStripMenuItem.Name = "uploadsToolStripMenuItem";
            this.uploadsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.uploadsToolStripMenuItem.Text = "&Uploads";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("browseToolStripMenuItem.Image")));
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.browseToolStripMenuItem.Text = "&Excel Uploads";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associatesToolStripMenuItem,
            this.updatesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.hierarchyToolStripMenuItem1});
            this.manageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageToolStripMenuItem.Image")));
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // associatesToolStripMenuItem
            // 
            this.associatesToolStripMenuItem.Name = "associatesToolStripMenuItem";
            this.associatesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.associatesToolStripMenuItem.Text = "Permissions";
            this.associatesToolStripMenuItem.Click += new System.EventHandler(this.associatesToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updatesToolStripMenuItem.Text = "Associates";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // hierarchyToolStripMenuItem1
            // 
            this.hierarchyToolStripMenuItem1.Name = "hierarchyToolStripMenuItem1";
            this.hierarchyToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.hierarchyToolStripMenuItem1.Text = "Hierarchy";
            this.hierarchyToolStripMenuItem1.Click += new System.EventHandler(this.hierarchyToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 498);
            this.ContextMenuStrip = this.cntxtMenuStrp_Main;
            this.Controls.Add(this.mStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip_Main;
            this.Name = "Main";
            this.Text = "Sales Commission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mStrip_Main.ResumeLayout(false);
            this.mStrip_Main.PerformLayout();
            this.cntxtMenuStrp_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void hierarchyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flexibleUploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        internal System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesExtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxtMenuStrp_Main;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adjustmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associatesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hierarchyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelUploadsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hierarchyToolStripMenuItem1;
    }
}

