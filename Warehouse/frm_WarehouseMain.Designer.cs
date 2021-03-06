
namespace Warehouse
{
    partial class FRM_WarehouseMain
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mst_MainTop = new System.Windows.Forms.MenuStrip();
            this.mst_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Orders = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ProductList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_StockList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.mst_MainTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mst_MainTop
            // 
            this.mst_MainTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mst_Products,
            this.mst_Stock,
            this.mst_Orders,
            this.mst_Report});
            this.mst_MainTop.Location = new System.Drawing.Point(0, 0);
            this.mst_MainTop.Name = "mst_MainTop";
            this.mst_MainTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mst_MainTop.Size = new System.Drawing.Size(737, 24);
            this.mst_MainTop.TabIndex = 4;
            this.mst_MainTop.Text = "menuStrip1";
            // 
            // mst_Products
            // 
            this.mst_Products.Name = "mst_Products";
            this.mst_Products.Size = new System.Drawing.Size(66, 20);
            this.mst_Products.Text = "Products";
            this.mst_Products.Click += new System.EventHandler(this.MST_Products_Click);
            // 
            // mst_Stock
            // 
            this.mst_Stock.Name = "mst_Stock";
            this.mst_Stock.Size = new System.Drawing.Size(48, 20);
            this.mst_Stock.Text = "Stock";
            this.mst_Stock.Click += new System.EventHandler(this.MST_Stock_Click);
            // 
            // mst_Orders
            // 
            this.mst_Orders.Name = "mst_Orders";
            this.mst_Orders.Size = new System.Drawing.Size(54, 20);
            this.mst_Orders.Text = "Orders";
            this.mst_Orders.Click += new System.EventHandler(this.TSM_Orders_Click);
            // 
            // mst_Report
            // 
            this.mst_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ProductList,
            this.tsm_StockList});
            this.mst_Report.Name = "mst_Report";
            this.mst_Report.Size = new System.Drawing.Size(54, 20);
            this.mst_Report.Text = "&Report";
            // 
            // tsm_ProductList
            // 
            this.tsm_ProductList.Name = "tsm_ProductList";
            this.tsm_ProductList.Size = new System.Drawing.Size(180, 22);
            this.tsm_ProductList.Text = "Product Report";
            this.tsm_ProductList.Click += new System.EventHandler(this.TSM_ProductList_Click);
            // 
            // tsm_StockList
            // 
            this.tsm_StockList.Name = "tsm_StockList";
            this.tsm_StockList.Size = new System.Drawing.Size(180, 22);
            this.tsm_StockList.Text = "Stock Report";
            this.tsm_StockList.Click += new System.EventHandler(this.tsm_StockList_Click);
            // 
            // FRM_WarehouseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mst_MainTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst_MainTop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRM_WarehouseMain";
            this.Text = "Warehouse Managnent System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_WarehouseMain_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mst_MainTop.ResumeLayout(false);
            this.mst_MainTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip mst_MainTop;
        private System.Windows.Forms.ToolStripMenuItem mst_Products;
        private System.Windows.Forms.ToolStripMenuItem mst_Stock;
        private System.Windows.Forms.ToolStripMenuItem mst_Report;
        private System.Windows.Forms.ToolStripMenuItem tsm_ProductList;
        private System.Windows.Forms.ToolStripMenuItem tsm_StockList;
        private System.Windows.Forms.ToolStripMenuItem mst_Orders;
    }
}



