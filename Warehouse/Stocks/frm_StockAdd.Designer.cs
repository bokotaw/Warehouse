
namespace Warehouse
{
    partial class FRM_StockAdd
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
            this.LBL_AddMSG = new System.Windows.Forms.Label();
            this.CBX_ProductName = new System.Windows.Forms.ComboBox();
            this.TXT_StockQuantity = new System.Windows.Forms.TextBox();
            this.LBL_StockQuantity = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.CBX_ProductCode = new System.Windows.Forms.ComboBox();
            this.ERP_StockAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ERP_StockAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_AddMSG
            // 
            this.LBL_AddMSG.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_AddMSG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_AddMSG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_AddMSG.Location = new System.Drawing.Point(0, 203);
            this.LBL_AddMSG.Name = "LBL_AddMSG";
            this.LBL_AddMSG.Size = new System.Drawing.Size(372, 20);
            this.LBL_AddMSG.TabIndex = 19;
            this.LBL_AddMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBX_ProductName
            // 
            this.CBX_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBX_ProductName.FormattingEnabled = true;
            this.CBX_ProductName.Location = new System.Drawing.Point(12, 101);
            this.CBX_ProductName.Name = "CBX_ProductName";
            this.CBX_ProductName.Size = new System.Drawing.Size(228, 25);
            this.CBX_ProductName.TabIndex = 18;
            // 
            // TXT_StockQuantity
            // 
            this.TXT_StockQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_StockQuantity.Location = new System.Drawing.Point(12, 161);
            this.TXT_StockQuantity.Name = "TXT_StockQuantity";
            this.TXT_StockQuantity.Size = new System.Drawing.Size(228, 25);
            this.TXT_StockQuantity.TabIndex = 17;
            this.TXT_StockQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_StockQuantity_KeyPress);
            // 
            // LBL_StockQuantity
            // 
            this.LBL_StockQuantity.AutoSize = true;
            this.LBL_StockQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_StockQuantity.Location = new System.Drawing.Point(12, 141);
            this.LBL_StockQuantity.Name = "LBL_StockQuantity";
            this.LBL_StockQuantity.Size = new System.Drawing.Size(59, 17);
            this.LBL_StockQuantity.TabIndex = 15;
            this.LBL_StockQuantity.Text = "Quantity:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(12, 81);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(95, 17);
            this.lbl_ProductName.TabIndex = 14;
            this.lbl_ProductName.Text = "Product Name:";
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductCode.Location = new System.Drawing.Point(12, 21);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(91, 17);
            this.lbl_ProductCode.TabIndex = 13;
            this.lbl_ProductCode.Text = "Product Code:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.Location = new System.Drawing.Point(274, 145);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 35);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(274, 90);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 35);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(274, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 35);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // CBX_ProductCode
            // 
            this.CBX_ProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_ProductCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBX_ProductCode.FormattingEnabled = true;
            this.CBX_ProductCode.Location = new System.Drawing.Point(12, 41);
            this.CBX_ProductCode.Name = "CBX_ProductCode";
            this.CBX_ProductCode.Size = new System.Drawing.Size(228, 25);
            this.CBX_ProductCode.TabIndex = 20;
            // 
            // ERP_StockAdd
            // 
            this.ERP_StockAdd.ContainerControl = this;
            // 
            // FRM_StockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 223);
            this.Controls.Add(this.CBX_ProductCode);
            this.Controls.Add(this.LBL_AddMSG);
            this.Controls.Add(this.CBX_ProductName);
            this.Controls.Add(this.TXT_StockQuantity);
            this.Controls.Add(this.LBL_StockQuantity);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductCode);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Name = "FRM_StockAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.FRM_StockAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ERP_StockAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_AddMSG;
        private System.Windows.Forms.ComboBox CBX_ProductName;
        private System.Windows.Forms.TextBox TXT_StockQuantity;
        private System.Windows.Forms.Label LBL_StockQuantity;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox CBX_ProductCode;
        private System.Windows.Forms.ErrorProvider ERP_StockAdd;
    }
}