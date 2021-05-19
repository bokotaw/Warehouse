
namespace Warehouse
{
    partial class frm_ProductReport
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
            this.dgv_ProRepView = new System.Windows.Forms.DataGridView();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProRepView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProRepView
            // 
            this.dgv_ProRepView.AllowUserToAddRows = false;
            this.dgv_ProRepView.AllowUserToDeleteRows = false;
            this.dgv_ProRepView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProRepView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProRepView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_ProductStatus});
            this.dgv_ProRepView.Location = new System.Drawing.Point(12, 99);
            this.dgv_ProRepView.Name = "dgv_ProRepView";
            this.dgv_ProRepView.ReadOnly = true;
            this.dgv_ProRepView.RowHeadersVisible = false;
            this.dgv_ProRepView.RowTemplate.Height = 25;
            this.dgv_ProRepView.Size = new System.Drawing.Size(755, 463);
            this.dgv_ProRepView.TabIndex = 0;
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
            // clm_ProductStatus
            // 
            this.clm_ProductStatus.HeaderText = "Status";
            this.clm_ProductStatus.Name = "clm_ProductStatus";
            this.clm_ProductStatus.ReadOnly = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(232, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 30);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.Location = new System.Drawing.Point(366, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 30);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductCode.Location = new System.Drawing.Point(54, 68);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(125, 25);
            this.txt_ProductCode.TabIndex = 3;
            this.txt_ProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductCode_KeyPress);
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductName.Location = new System.Drawing.Point(290, 68);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(125, 25);
            this.txt_ProductName.TabIndex = 4;
            this.txt_ProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductName_KeyPress);
            // 
            // cbx_Status
            // 
            this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbx_Status.Location = new System.Drawing.Point(529, 68);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(146, 25);
            this.cbx_Status.TabIndex = 5;
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(54, 47);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(95, 17);
            this.lbl_ProductCode.TabIndex = 6;
            this.lbl_ProductCode.Text = "Product Code :";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(290, 46);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(99, 17);
            this.lbl_ProductName.TabIndex = 7;
            this.lbl_ProductName.Text = "Product Name :";
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Status.Location = new System.Drawing.Point(529, 47);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(50, 17);
            this.txt_Status.TabIndex = 8;
            this.txt_Status.Text = "Status :";
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(662, 568);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(105, 30);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // frm_ProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 612);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_ProRepView);
            this.Name = "frm_ProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.frm_ProductReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProRepView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProRepView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductStatus;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label txt_Status;
        private System.Windows.Forms.Button btn_Export;
    }
}