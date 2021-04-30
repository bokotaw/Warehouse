
namespace Warehouse
{
    partial class frm_Products
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
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.dgv_ProductView = new System.Windows.Forms.DataGridView();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.erp_Products = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(12, 39);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(88, 17);
            this.lbl_ProductCode.TabIndex = 0;
            this.lbl_ProductCode.Text = "Product Code";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(171, 39);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(92, 17);
            this.lbl_ProductName.TabIndex = 1;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(330, 39);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(43, 17);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Status";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Location = new System.Drawing.Point(12, 68);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(135, 25);
            this.txt_ProductCode.TabIndex = 3;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(171, 68);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(135, 25);
            this.txt_ProductName.TabIndex = 4;
            // 
            // cbx_Status
            // 
            this.cbx_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbx_Status.Location = new System.Drawing.Point(330, 68);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(135, 25);
            this.cbx_Status.TabIndex = 5;
            // 
            // dgv_ProductView
            // 
            this.dgv_ProductView.AllowUserToAddRows = false;
            this.dgv_ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_Status});
            this.dgv_ProductView.Location = new System.Drawing.Point(12, 120);
            this.dgv_ProductView.Name = "dgv_ProductView";
            this.dgv_ProductView.RowTemplate.Height = 25;
            this.dgv_ProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductView.Size = new System.Drawing.Size(776, 284);
            this.dgv_ProductView.TabIndex = 6;
            this.dgv_ProductView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_DataView_MouseDoubleClick);
            // 
            // clm_ProductCode
            // 
            this.clm_ProductCode.HeaderText = "Product Code";
            this.clm_ProductCode.Name = "clm_ProductCode";
            // 
            // clm_ProductName
            // 
            this.clm_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_ProductName.HeaderText = "Product Name";
            this.clm_ProductName.Name = "clm_ProductName";
            // 
            // clm_Status
            // 
            this.clm_Status.HeaderText = "Status";
            this.clm_Status.Name = "clm_Status";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(588, 68);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 26);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(687, 68);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 26);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // erp_Products
            // 
            this.erp_Products.ContainerControl = this;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(489, 68);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 26);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dgv_ProductView);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frm_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frm_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.DataGridView dgv_ProductView;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Status;
        private System.Windows.Forms.ErrorProvider erp_Products;
        private System.Windows.Forms.Button btn_Reset;
    }
}