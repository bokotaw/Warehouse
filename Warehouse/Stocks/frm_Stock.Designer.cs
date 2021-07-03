
namespace Warehouse
{
    partial class FRM_Stock
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
            this.dgv_StockView = new System.Windows.Forms.DataGridView();
            this.CLM_StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLM_Product_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLM_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLM_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLM_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalProductNumber = new System.Windows.Forms.Label();
            this.lbl_TotalQuantityNumber = new System.Windows.Forms.Label();
            this.erp_Stock = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TXT_StockNumber = new System.Windows.Forms.TextBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.TXT_ProductCode = new System.Windows.Forms.TextBox();
            this.TXT_ProductName = new System.Windows.Forms.TextBox();
            this.LBL_StockNumber = new System.Windows.Forms.Label();
            this.LBL_Product_ID = new System.Windows.Forms.Label();
            this.LBL_ProductName = new System.Windows.Forms.Label();
            this.LBL_StockMSG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_StockView
            // 
            this.dgv_StockView.AllowUserToAddRows = false;
            this.dgv_StockView.AllowUserToDeleteRows = false;
            this.dgv_StockView.AllowUserToResizeColumns = false;
            this.dgv_StockView.AllowUserToResizeRows = false;
            this.dgv_StockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLM_StockNumber,
            this.CLM_Product_Code,
            this.CLM_ProductName,
            this.CLM_Quantity,
            this.CLM_Date});
            this.dgv_StockView.Location = new System.Drawing.Point(26, 135);
            this.dgv_StockView.Name = "dgv_StockView";
            this.dgv_StockView.ReadOnly = true;
            this.dgv_StockView.RowHeadersVisible = false;
            this.dgv_StockView.RowTemplate.Height = 25;
            this.dgv_StockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StockView.Size = new System.Drawing.Size(733, 258);
            this.dgv_StockView.TabIndex = 12;
            // 
            // CLM_StockNumber
            // 
            this.CLM_StockNumber.HeaderText = "S.No";
            this.CLM_StockNumber.Name = "CLM_StockNumber";
            this.CLM_StockNumber.ReadOnly = true;
            // 
            // CLM_Product_Code
            // 
            this.CLM_Product_Code.HeaderText = "Product ID";
            this.CLM_Product_Code.Name = "CLM_Product_Code";
            this.CLM_Product_Code.ReadOnly = true;
            // 
            // CLM_ProductName
            // 
            this.CLM_ProductName.HeaderText = "Product Name";
            this.CLM_ProductName.Name = "CLM_ProductName";
            this.CLM_ProductName.ReadOnly = true;
            // 
            // CLM_Quantity
            // 
            this.CLM_Quantity.HeaderText = "Quantity";
            this.CLM_Quantity.Name = "CLM_Quantity";
            this.CLM_Quantity.ReadOnly = true;
            // 
            // CLM_Date
            // 
            this.CLM_Date.HeaderText = "Date";
            this.CLM_Date.Name = "CLM_Date";
            this.CLM_Date.ReadOnly = true;
            // 
            // lbl_TotalProductNumber
            // 
            this.lbl_TotalProductNumber.AutoSize = true;
            this.lbl_TotalProductNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalProductNumber.Location = new System.Drawing.Point(273, 410);
            this.lbl_TotalProductNumber.Name = "lbl_TotalProductNumber";
            this.lbl_TotalProductNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_TotalProductNumber.TabIndex = 14;
            // 
            // lbl_TotalQuantityNumber
            // 
            this.lbl_TotalQuantityNumber.AutoSize = true;
            this.lbl_TotalQuantityNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalQuantityNumber.Location = new System.Drawing.Point(617, 410);
            this.lbl_TotalQuantityNumber.Name = "lbl_TotalQuantityNumber";
            this.lbl_TotalQuantityNumber.Size = new System.Drawing.Size(0, 17);
            this.lbl_TotalQuantityNumber.TabIndex = 16;
            // 
            // erp_Stock
            // 
            this.erp_Stock.ContainerControl = this;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(167, 12);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(100, 65);
            this.BTN_Add.TabIndex = 17;
            this.BTN_Add.Text = "ADD";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(315, 12);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(100, 65);
            this.BTN_Delete.TabIndex = 20;
            this.BTN_Delete.Text = "DELETE";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(463, 12);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(100, 65);
            this.BTN_Refresh.TabIndex = 21;
            this.BTN_Refresh.Text = "REFRESH";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Search.Location = new System.Drawing.Point(547, 104);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(96, 25);
            this.BTN_Search.TabIndex = 24;
            this.BTN_Search.Text = "SEARCH";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TXT_StockNumber
            // 
            this.TXT_StockNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_StockNumber.Location = new System.Drawing.Point(26, 104);
            this.TXT_StockNumber.Name = "TXT_StockNumber";
            this.TXT_StockNumber.Size = new System.Drawing.Size(149, 25);
            this.TXT_StockNumber.TabIndex = 29;
            this.TXT_StockNumber.TextChanged += new System.EventHandler(this.TXT_StockNumber_TextChanged);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Clear.Location = new System.Drawing.Point(663, 103);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(96, 25);
            this.BTN_Clear.TabIndex = 30;
            this.BTN_Clear.Text = "CLEAR";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // TXT_ProductCode
            // 
            this.TXT_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_ProductCode.Location = new System.Drawing.Point(193, 104);
            this.TXT_ProductCode.Name = "TXT_ProductCode";
            this.TXT_ProductCode.Size = new System.Drawing.Size(149, 25);
            this.TXT_ProductCode.TabIndex = 31;
            this.TXT_ProductCode.TextChanged += new System.EventHandler(this.TXT_ProductCode_TextChanged);
            // 
            // TXT_ProductName
            // 
            this.TXT_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_ProductName.Location = new System.Drawing.Point(360, 104);
            this.TXT_ProductName.Name = "TXT_ProductName";
            this.TXT_ProductName.Size = new System.Drawing.Size(149, 25);
            this.TXT_ProductName.TabIndex = 32;
            this.TXT_ProductName.TextChanged += new System.EventHandler(this.TXT_ProductName_TextChanged);
            // 
            // LBL_StockNumber
            // 
            this.LBL_StockNumber.AutoSize = true;
            this.LBL_StockNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_StockNumber.Location = new System.Drawing.Point(26, 86);
            this.LBL_StockNumber.Name = "LBL_StockNumber";
            this.LBL_StockNumber.Size = new System.Drawing.Size(95, 17);
            this.LBL_StockNumber.TabIndex = 33;
            this.LBL_StockNumber.Text = "Stock number :";
            // 
            // LBL_Product_ID
            // 
            this.LBL_Product_ID.AutoSize = true;
            this.LBL_Product_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Product_ID.Location = new System.Drawing.Point(193, 86);
            this.LBL_Product_ID.Name = "LBL_Product_ID";
            this.LBL_Product_ID.Size = new System.Drawing.Size(93, 17);
            this.LBL_Product_ID.TabIndex = 34;
            this.LBL_Product_ID.Text = "Product code :";
            // 
            // LBL_ProductName
            // 
            this.LBL_ProductName.AutoSize = true;
            this.LBL_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_ProductName.Location = new System.Drawing.Point(360, 86);
            this.LBL_ProductName.Name = "LBL_ProductName";
            this.LBL_ProductName.Size = new System.Drawing.Size(96, 17);
            this.LBL_ProductName.TabIndex = 35;
            this.LBL_ProductName.Text = "Product name :";
            // 
            // LBL_StockMSG
            // 
            this.LBL_StockMSG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_StockMSG.Location = new System.Drawing.Point(0, 407);
            this.LBL_StockMSG.Name = "LBL_StockMSG";
            this.LBL_StockMSG.Size = new System.Drawing.Size(784, 20);
            this.LBL_StockMSG.TabIndex = 36;
            this.LBL_StockMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 427);
            this.Controls.Add(this.LBL_StockMSG);
            this.Controls.Add(this.LBL_ProductName);
            this.Controls.Add(this.LBL_Product_ID);
            this.Controls.Add(this.LBL_StockNumber);
            this.Controls.Add(this.TXT_ProductName);
            this.Controls.Add(this.TXT_ProductCode);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.TXT_StockNumber);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.lbl_TotalQuantityNumber);
            this.Controls.Add(this.lbl_TotalProductNumber);
            this.Controls.Add(this.dgv_StockView);
            this.Name = "FRM_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.FRM_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_StockView;
        private System.Windows.Forms.Label lbl_TotalProductNumber;
        private System.Windows.Forms.Label lbl_TotalQuantityNumber;
        private System.Windows.Forms.ErrorProvider erp_Stock;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TXT_StockNumber;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Label LBL_ProductName;
        private System.Windows.Forms.Label LBL_Product_ID;
        private System.Windows.Forms.Label LBL_StockNumber;
        private System.Windows.Forms.TextBox TXT_ProductName;
        private System.Windows.Forms.TextBox TXT_ProductCode;
        private System.Windows.Forms.Label LBL_StockMSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLM_StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLM_Product_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLM_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLM_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLM_Date;
    }
}