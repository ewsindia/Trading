namespace SmartTrading
{
    partial class MainMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasenctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchesMetarialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.trasenctionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMasterToolStripMenuItem,
            this.customerMasterToolStripMenuItem,
            this.vendorMasterToolStripMenuItem,
            this.shortformsToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // customerMasterToolStripMenuItem
            // 
            this.customerMasterToolStripMenuItem.Name = "customerMasterToolStripMenuItem";
            this.customerMasterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.customerMasterToolStripMenuItem.Text = "Customer Master";
            this.customerMasterToolStripMenuItem.Click += new System.EventHandler(this.customerMasterToolStripMenuItem_Click);
            // 
            // vendorMasterToolStripMenuItem
            // 
            this.vendorMasterToolStripMenuItem.Name = "vendorMasterToolStripMenuItem";
            this.vendorMasterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.vendorMasterToolStripMenuItem.Text = "Vendor Master";
            // 
            // shortformsToolStripMenuItem
            // 
            this.shortformsToolStripMenuItem.Name = "shortformsToolStripMenuItem";
            this.shortformsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.shortformsToolStripMenuItem.Text = "Shortforms";
            this.shortformsToolStripMenuItem.Click += new System.EventHandler(this.shortformsToolStripMenuItem_Click);
            // 
            // trasenctionsToolStripMenuItem
            // 
            this.trasenctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchesToolStripMenuItem});
            this.trasenctionsToolStripMenuItem.Name = "trasenctionsToolStripMenuItem";
            this.trasenctionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.trasenctionsToolStripMenuItem.Text = "Trasenctions";
            // 
            // purchesToolStripMenuItem
            // 
            this.purchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchesInvoiceToolStripMenuItem,
            this.purchesMetarialsToolStripMenuItem});
            this.purchesToolStripMenuItem.Name = "purchesToolStripMenuItem";
            this.purchesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.purchesToolStripMenuItem.Text = "Purches";
            // 
            // purchesInvoiceToolStripMenuItem
            // 
            this.purchesInvoiceToolStripMenuItem.Name = "purchesInvoiceToolStripMenuItem";
            this.purchesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.purchesInvoiceToolStripMenuItem.Text = "Purches Invoice";
            // 
            // purchesMetarialsToolStripMenuItem
            // 
            this.purchesMetarialsToolStripMenuItem.Name = "purchesMetarialsToolStripMenuItem";
            this.purchesMetarialsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.purchesMetarialsToolStripMenuItem.Text = "Purches Metarials";
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 356);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMDI";
            this.Text = "Smart Trading System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasenctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchesMetarialsToolStripMenuItem;
    }
}

