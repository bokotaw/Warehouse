
namespace Warehouse
{
    partial class FRM_Products
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
            this.dgv_ProductView = new System.Windows.Forms.DataGridView();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_edit = new System.Windows.Forms.Button();
            this.BTN_refresh = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.LBL_ProductMSG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductView
            // 
            this.dgv_ProductView.AllowUserToAddRows = false;
            this.dgv_ProductView.AllowUserToResizeColumns = false;
            this.dgv_ProductView.AllowUserToResizeRows = false;
            this.dgv_ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_Status});
            this.dgv_ProductView.Location = new System.Drawing.Point(12, 12);
            this.dgv_ProductView.Name = "dgv_ProductView";
            this.dgv_ProductView.RowHeadersVisible = false;
            this.dgv_ProductView.RowTemplate.Height = 25;
            this.dgv_ProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductView.Size = new System.Drawing.Size(630, 425);
            this.dgv_ProductView.TabIndex = 6;
            // 
            // clm_ProductCode
            // 
            this.clm_ProductCode.HeaderText = "Product Code";
            this.clm_ProductCode.Name = "clm_ProductCode";
            this.clm_ProductCode.Width = 113;
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
            this.clm_Status.Width = 68;
            // 
            // BTN_edit
            // 
            this.BTN_edit.Location = new System.Drawing.Point(661, 238);
            this.BTN_edit.Name = "BTN_edit";
            this.BTN_edit.Size = new System.Drawing.Size(85, 85);
            this.BTN_edit.TabIndex = 11;
            this.BTN_edit.Text = "EDIT";
            this.BTN_edit.UseVisualStyleBackColor = true;
            this.BTN_edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_refresh
            // 
            this.BTN_refresh.Location = new System.Drawing.Point(661, 351);
            this.BTN_refresh.Name = "BTN_refresh";
            this.BTN_refresh.Size = new System.Drawing.Size(85, 85);
            this.BTN_refresh.TabIndex = 13;
            this.BTN_refresh.Text = "REFRESH";
            this.BTN_refresh.UseVisualStyleBackColor = true;
            this.BTN_refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(661, 12);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(85, 85);
            this.BTN_add.TabIndex = 14;
            this.BTN_add.Text = "ADD";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Location = new System.Drawing.Point(661, 125);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(85, 85);
            this.BTN_delete.TabIndex = 15;
            this.BTN_delete.Text = "DELETE";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // LBL_ProductMSG
            // 
            this.LBL_ProductMSG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_ProductMSG.Location = new System.Drawing.Point(0, 441);
            this.LBL_ProductMSG.Name = "LBL_ProductMSG";
            this.LBL_ProductMSG.Size = new System.Drawing.Size(769, 20);
            this.LBL_ProductMSG.TabIndex = 16;
            this.LBL_ProductMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 461);
            this.Controls.Add(this.LBL_ProductMSG);
            this.Controls.Add(this.BTN_delete);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.BTN_refresh);
            this.Controls.Add(this.BTN_edit);
            this.Controls.Add(this.dgv_ProductView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FRM_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FRM_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ProductView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Status;
        private System.Windows.Forms.Button BTN_edit;
        private System.Windows.Forms.Button BTN_refresh;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Label LBL_ProductMSG;
    }
}