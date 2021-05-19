
namespace Warehouse
{
    partial class frm_Stock
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
            this.dtp_StockDate = new System.Windows.Forms.DateTimePicker();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.dgv_StockView = new System.Windows.Forms.DataGridView();
            this.clm_StockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalProduct = new System.Windows.Forms.Label();
            this.lbl_TotalProductNumber = new System.Windows.Forms.Label();
            this.lbl_TotalQuantity = new System.Windows.Forms.Label();
            this.lbl_TotalQuantityNumber = new System.Windows.Forms.Label();
            this.erp_Stock = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_StockDate
            // 
            this.dtp_StockDate.CustomFormat = "dd/mm/yyyy";
            this.dtp_StockDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_StockDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StockDate.Location = new System.Drawing.Point(26, 70);
            this.dtp_StockDate.Name = "dtp_StockDate";
            this.dtp_StockDate.Size = new System.Drawing.Size(126, 25);
            this.dtp_StockDate.TabIndex = 0;
            this.dtp_StockDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_StockDate_KeyDown);
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductName.Location = new System.Drawing.Point(332, 70);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(126, 25);
            this.txt_ProductName.TabIndex = 1;
            this.txt_ProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductName_KeyDown);
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductCode.Location = new System.Drawing.Point(179, 70);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(126, 25);
            this.txt_ProductCode.TabIndex = 1;
            this.txt_ProductCode.TextChanged += new System.EventHandler(this.txt_ProductCode_TextChanged);
            this.txt_ProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductCode_KeyDown);
            this.txt_ProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductCode_KeyPress);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Quantity.Location = new System.Drawing.Point(485, 70);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(126, 25);
            this.txt_Quantity.TabIndex = 1;
            this.txt_Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quantity_KeyDown);
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(26, 36);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(35, 17);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(179, 36);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(88, 17);
            this.lbl_ProductCode.TabIndex = 4;
            this.lbl_ProductCode.Text = "Product Code";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(332, 36);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(92, 17);
            this.lbl_ProductName.TabIndex = 5;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(485, 36);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(56, 17);
            this.lbl_Quantity.TabIndex = 6;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(638, 36);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(43, 17);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(231, 118);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(83, 41);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(349, 118);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(83, 41);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(467, 117);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(83, 41);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cbx_Status
            // 
            this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbx_Status.Location = new System.Drawing.Point(638, 70);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(121, 23);
            this.cbx_Status.TabIndex = 11;
            this.cbx_Status.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Status_KeyDown);
            // 
            // dgv_StockView
            // 
            this.dgv_StockView.AllowUserToAddRows = false;
            this.dgv_StockView.AllowUserToResizeColumns = false;
            this.dgv_StockView.AllowUserToResizeRows = false;
            this.dgv_StockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StockView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_StockNo,
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_Quantity,
            this.clm_Date,
            this.clm_Status});
            this.dgv_StockView.Location = new System.Drawing.Point(26, 176);
            this.dgv_StockView.Name = "dgv_StockView";
            this.dgv_StockView.RowHeadersVisible = false;
            this.dgv_StockView.RowTemplate.Height = 25;
            this.dgv_StockView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_StockView.Size = new System.Drawing.Size(733, 217);
            this.dgv_StockView.TabIndex = 12;
            this.dgv_StockView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_StockView_MouseDoubleClick);
            // 
            // clm_StockNo
            // 
            this.clm_StockNo.HeaderText = "S.No";
            this.clm_StockNo.Name = "clm_StockNo";
            // 
            // clm_ProductCode
            // 
            this.clm_ProductCode.HeaderText = "Product Code";
            this.clm_ProductCode.Name = "clm_ProductCode";
            // 
            // clm_ProductName
            // 
            this.clm_ProductName.HeaderText = "Product Name";
            this.clm_ProductName.Name = "clm_ProductName";
            // 
            // clm_Quantity
            // 
            this.clm_Quantity.HeaderText = "Quantity";
            this.clm_Quantity.Name = "clm_Quantity";
            // 
            // clm_Date
            // 
            this.clm_Date.HeaderText = "Date";
            this.clm_Date.Name = "clm_Date";
            // 
            // clm_Status
            // 
            this.clm_Status.HeaderText = "Status";
            this.clm_Status.Name = "clm_Status";
            // 
            // lbl_TotalProduct
            // 
            this.lbl_TotalProduct.AutoSize = true;
            this.lbl_TotalProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalProduct.Location = new System.Drawing.Point(171, 410);
            this.lbl_TotalProduct.Name = "lbl_TotalProduct";
            this.lbl_TotalProduct.Size = new System.Drawing.Size(96, 17);
            this.lbl_TotalProduct.TabIndex = 13;
            this.lbl_TotalProduct.Text = "Total Product : ";
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
            // lbl_TotalQuantity
            // 
            this.lbl_TotalQuantity.AutoSize = true;
            this.lbl_TotalQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalQuantity.Location = new System.Drawing.Point(512, 410);
            this.lbl_TotalQuantity.Name = "lbl_TotalQuantity";
            this.lbl_TotalQuantity.Size = new System.Drawing.Size(99, 17);
            this.lbl_TotalQuantity.TabIndex = 15;
            this.lbl_TotalQuantity.Text = "Total Quantity : ";
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
            // frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 449);
            this.Controls.Add(this.lbl_TotalQuantityNumber);
            this.Controls.Add(this.lbl_TotalQuantity);
            this.Controls.Add(this.lbl_TotalProductNumber);
            this.Controls.Add(this.lbl_TotalProduct);
            this.Controls.Add(this.dgv_StockView);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.dtp_StockDate);
            this.Name = "frm_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_StockDate;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.DataGridView dgv_StockView;
        private System.Windows.Forms.Label lbl_TotalProduct;
        private System.Windows.Forms.Label lbl_TotalProductNumber;
        private System.Windows.Forms.Label lbl_TotalQuantity;
        private System.Windows.Forms.Label lbl_TotalQuantityNumber;
        private System.Windows.Forms.ErrorProvider erp_Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Status;
    }
}