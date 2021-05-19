
namespace Warehouse
{
    partial class frm_ProductAdd
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductStaus = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.cbx_ProductStatus = new System.Windows.Forms.ComboBox();
            this.erp_ProductsAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erp_ProductsAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(285, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 35);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(285, 94);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 35);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(285, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(23, 20);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(91, 17);
            this.lbl_ProductCode.TabIndex = 3;
            this.lbl_ProductCode.Text = "Product Code:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(23, 80);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(95, 17);
            this.lbl_ProductName.TabIndex = 4;
            this.lbl_ProductName.Text = "Product Name:";
            // 
            // lbl_ProductStaus
            // 
            this.lbl_ProductStaus.AutoSize = true;
            this.lbl_ProductStaus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductStaus.Location = new System.Drawing.Point(23, 140);
            this.lbl_ProductStaus.Name = "lbl_ProductStaus";
            this.lbl_ProductStaus.Size = new System.Drawing.Size(91, 17);
            this.lbl_ProductStaus.TabIndex = 5;
            this.lbl_ProductStaus.Text = "Product Staus:";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductCode.Location = new System.Drawing.Point(23, 40);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(228, 25);
            this.txt_ProductCode.TabIndex = 6;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductName.Location = new System.Drawing.Point(23, 100);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(228, 25);
            this.txt_ProductName.TabIndex = 7;
            // 
            // cbx_ProductStatus
            // 
            this.cbx_ProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_ProductStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_ProductStatus.FormattingEnabled = true;
            this.cbx_ProductStatus.Items.AddRange(new object[] {
            "active",
            "unactive"});
            this.cbx_ProductStatus.Location = new System.Drawing.Point(23, 160);
            this.cbx_ProductStatus.Name = "cbx_ProductStatus";
            this.cbx_ProductStatus.Size = new System.Drawing.Size(228, 25);
            this.cbx_ProductStatus.TabIndex = 8;
            // 
            // erp_ProductsAdd
            // 
            this.erp_ProductsAdd.ContainerControl = this;
            // 
            // frm_ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 220);
            this.Controls.Add(this.cbx_ProductStatus);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.txt_ProductCode);
            this.Controls.Add(this.lbl_ProductStaus);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Name = "frm_ProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            ((System.ComponentModel.ISupportInitialize)(this.erp_ProductsAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductStaus;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.ComboBox cbx_ProductStatus;
        private System.Windows.Forms.ErrorProvider erp_ProductsAdd;
    }
}