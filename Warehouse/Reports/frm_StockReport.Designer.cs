
namespace Warehouse
{
    partial class frm_StockReport
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
            this.btn_Export = new System.Windows.Forms.Button();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_StockNumber = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_StockNumber = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_StoRepView = new System.Windows.Forms.DataGridView();
            this.clm_StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Qunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.sfd_Stock = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StoRepView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(663, 563);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(105, 30);
            this.btn_Export.TabIndex = 19;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(488, 42);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(99, 17);
            this.lbl_ProductName.TabIndex = 17;
            this.lbl_ProductName.Text = "Product Name :";
            // 
            // lbl_StockNumber
            // 
            this.lbl_StockNumber.AutoSize = true;
            this.lbl_StockNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_StockNumber.Location = new System.Drawing.Point(96, 42);
            this.lbl_StockNumber.Name = "lbl_StockNumber";
            this.lbl_StockNumber.Size = new System.Drawing.Size(98, 17);
            this.lbl_StockNumber.TabIndex = 16;
            this.lbl_StockNumber.Text = "Stock Number :";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductName.Location = new System.Drawing.Point(488, 63);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(125, 25);
            this.txt_ProductName.TabIndex = 14;
            this.txt_ProductName.TextChanged += new System.EventHandler(this.txt_ProductName_TextChanged);
            // 
            // txt_StockNumber
            // 
            this.txt_StockNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_StockNumber.Location = new System.Drawing.Point(96, 63);
            this.txt_StockNumber.Name = "txt_StockNumber";
            this.txt_StockNumber.Size = new System.Drawing.Size(125, 25);
            this.txt_StockNumber.TabIndex = 13;
            this.txt_StockNumber.TextChanged += new System.EventHandler(this.txt_StockNumber_TextChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(367, 7);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 30);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(233, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 30);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_StoRepView
            // 
            this.dgv_StoRepView.AllowUserToAddRows = false;
            this.dgv_StoRepView.AllowUserToDeleteRows = false;
            this.dgv_StoRepView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StoRepView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StoRepView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_StockNumber,
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_Qunatity,
            this.clm_Date});
            this.dgv_StoRepView.Location = new System.Drawing.Point(13, 94);
            this.dgv_StoRepView.Name = "dgv_StoRepView";
            this.dgv_StoRepView.ReadOnly = true;
            this.dgv_StoRepView.RowHeadersVisible = false;
            this.dgv_StoRepView.RowTemplate.Height = 25;
            this.dgv_StoRepView.Size = new System.Drawing.Size(755, 463);
            this.dgv_StoRepView.TabIndex = 10;
            // 
            // clm_StockNumber
            // 
            this.clm_StockNumber.HeaderText = "Stock N.";
            this.clm_StockNumber.Name = "clm_StockNumber";
            this.clm_StockNumber.ReadOnly = true;
            // 
            // clm_ProductCode
            // 
            this.clm_ProductCode.HeaderText = "Product Code";
            this.clm_ProductCode.Name = "clm_ProductCode";
            this.clm_ProductCode.ReadOnly = true;
            // 
            // clm_ProductName
            // 
            this.clm_ProductName.HeaderText = "Product Name";
            this.clm_ProductName.Name = "clm_ProductName";
            this.clm_ProductName.ReadOnly = true;
            // 
            // clm_Qunatity
            // 
            this.clm_Qunatity.HeaderText = "Qunatity";
            this.clm_Qunatity.Name = "clm_Qunatity";
            this.clm_Qunatity.ReadOnly = true;
            // 
            // clm_Date
            // 
            this.clm_Date.HeaderText = "Transaction Date";
            this.clm_Date.Name = "clm_Date";
            this.clm_Date.ReadOnly = true;
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(292, 43);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(95, 17);
            this.lbl_ProductCode.TabIndex = 22;
            this.lbl_ProductCode.Text = "Product Code :";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductCode.Location = new System.Drawing.Point(292, 63);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(125, 25);
            this.txt_ProductCode.TabIndex = 21;
            this.txt_ProductCode.TextChanged += new System.EventHandler(this.txt_ProductCode_TextChanged);
            // 
            // sfd_Stock
            // 
            this.sfd_Stock.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_Stock_FileOk);
            // 
            // frm_StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 599);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_StockNumber);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_StockNumber);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_StoRepView);
            this.Name = "frm_StockReport";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.frm_StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StoRepView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_StockNumber;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_StockNumber;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_StoRepView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Qunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Date;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.SaveFileDialog sfd_Stock;
    }
}