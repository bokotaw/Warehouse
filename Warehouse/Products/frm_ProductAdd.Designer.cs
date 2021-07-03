
namespace Warehouse
{
    partial class FRM_ProductAdd
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
            this.TXT_ProductCode = new System.Windows.Forms.TextBox();
            this.TXT_ProductName = new System.Windows.Forms.TextBox();
            this.CBX_ProductStatus = new System.Windows.Forms.ComboBox();
            this.ERP_ProductAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBL_AddMSG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ERP_ProductAdd)).BeginInit();
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
            this.btn_add.Click += new System.EventHandler(this.BTN_Add_Click);
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
            this.btn_reset.Click += new System.EventHandler(this.BTN_Reset_Click);
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
            this.btn_cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
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
            // TXT_ProductCode
            // 
            this.TXT_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_ProductCode.Location = new System.Drawing.Point(23, 40);
            this.TXT_ProductCode.Name = "TXT_ProductCode";
            this.TXT_ProductCode.Size = new System.Drawing.Size(228, 25);
            this.TXT_ProductCode.TabIndex = 6;
            // 
            // TXT_ProductName
            // 
            this.TXT_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_ProductName.Location = new System.Drawing.Point(23, 100);
            this.TXT_ProductName.Name = "TXT_ProductName";
            this.TXT_ProductName.Size = new System.Drawing.Size(228, 25);
            this.TXT_ProductName.TabIndex = 7;
            // 
            // CBX_ProductStatus
            // 
            this.CBX_ProductStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_ProductStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBX_ProductStatus.FormattingEnabled = true;
            this.CBX_ProductStatus.Items.AddRange(new object[] {
            "active",
            "unactive"});
            this.CBX_ProductStatus.Location = new System.Drawing.Point(23, 160);
            this.CBX_ProductStatus.Name = "CBX_ProductStatus";
            this.CBX_ProductStatus.Size = new System.Drawing.Size(228, 25);
            this.CBX_ProductStatus.TabIndex = 8;
            // 
            // erp_ProductsAdd
            // 
            this.ERP_ProductAdd.ContainerControl = this;
            // 
            // LBL_AddMSG
            // 
            this.LBL_AddMSG.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_AddMSG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_AddMSG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_AddMSG.Location = new System.Drawing.Point(0, 191);
            this.LBL_AddMSG.Name = "LBL_AddMSG";
            this.LBL_AddMSG.Size = new System.Drawing.Size(399, 20);
            this.LBL_AddMSG.TabIndex = 9;
            this.LBL_AddMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 211);
            this.Controls.Add(this.LBL_AddMSG);
            this.Controls.Add(this.CBX_ProductStatus);
            this.Controls.Add(this.TXT_ProductName);
            this.Controls.Add(this.TXT_ProductCode);
            this.Controls.Add(this.lbl_ProductStaus);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Name = "FRM_ProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            ((System.ComponentModel.ISupportInitialize)(this.ERP_ProductAdd)).EndInit();
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
        private System.Windows.Forms.TextBox TXT_ProductCode;
        private System.Windows.Forms.TextBox TXT_ProductName;
        private System.Windows.Forms.ComboBox CBX_ProductStatus;
        private System.Windows.Forms.ErrorProvider ERP_ProductAdd;
        private System.Windows.Forms.Label LBL_AddMSG;
    }
}