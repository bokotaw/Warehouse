
namespace Warehouse
{
    partial class frm_Orders
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
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_refresh = new System.Windows.Forms.Button();
            this.dgv_OrdersView = new System.Windows.Forms.DataGridView();
            this.clm_Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrdersView)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_delete
            // 
            this.BTN_delete.Location = new System.Drawing.Point(648, 114);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(85, 85);
            this.BTN_delete.TabIndex = 21;
            this.BTN_delete.Text = "DELETE";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(648, 12);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(85, 85);
            this.BTN_add.TabIndex = 20;
            this.BTN_add.Text = "ADD";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_refresh
            // 
            this.BTN_refresh.Location = new System.Drawing.Point(648, 216);
            this.BTN_refresh.Name = "BTN_refresh";
            this.BTN_refresh.Size = new System.Drawing.Size(85, 85);
            this.BTN_refresh.TabIndex = 19;
            this.BTN_refresh.Text = "REFRESH";
            this.BTN_refresh.UseVisualStyleBackColor = true;
            this.BTN_refresh.Click += new System.EventHandler(this.BTN_refresh_Click);
            // 
            // dgv_OrdersView
            // 
            this.dgv_OrdersView.AllowUserToAddRows = false;
            this.dgv_OrdersView.AllowUserToResizeColumns = false;
            this.dgv_OrdersView.AllowUserToResizeRows = false;
            this.dgv_OrdersView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_OrdersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrdersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Order_ID,
            this.clm_OrderNumber,
            this.clm_ProductName,
            this.clm_Quantity});
            this.dgv_OrdersView.Location = new System.Drawing.Point(12, 12);
            this.dgv_OrdersView.Name = "dgv_OrdersView";
            this.dgv_OrdersView.RowHeadersVisible = false;
            this.dgv_OrdersView.RowTemplate.Height = 25;
            this.dgv_OrdersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrdersView.Size = new System.Drawing.Size(630, 289);
            this.dgv_OrdersView.TabIndex = 17;
            // 
            // clm_Order_ID
            // 
            this.clm_Order_ID.HeaderText = "Order ID";
            this.clm_Order_ID.Name = "clm_Order_ID";
            this.clm_Order_ID.Width = 76;
            // 
            // clm_OrderNumber
            // 
            this.clm_OrderNumber.HeaderText = "Order N.";
            this.clm_OrderNumber.Name = "clm_OrderNumber";
            this.clm_OrderNumber.Width = 77;
            // 
            // clm_ProductName
            // 
            this.clm_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_ProductName.HeaderText = "Product Name";
            this.clm_ProductName.Name = "clm_ProductName";
            // 
            // clm_Quantity
            // 
            this.clm_Quantity.HeaderText = "Quantity";
            this.clm_Quantity.Name = "clm_Quantity";
            this.clm_Quantity.Width = 78;
            // 
            // frm_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 313);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.BTN_refresh);
            this.Controls.Add(this.dgv_OrdersView);
            this.Name = "frm_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDERS";
            this.Load += new System.EventHandler(this.frm_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrdersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_refresh;
        private System.Windows.Forms.DataGridView dgv_OrdersView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Quantity;
    }
}