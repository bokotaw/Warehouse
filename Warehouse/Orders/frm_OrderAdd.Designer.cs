
namespace Warehouse
{
    partial class frm_OrderAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ProductView = new System.Windows.Forms.DataGridView();
            this.clm_StockNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Quantity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clm_Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LBL_Info = new System.Windows.Forms.Label();
            this.TXT_OrderNumber = new System.Windows.Forms.TextBox();
            this.LBL_AddMSG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductView
            // 
            this.dgv_ProductView.AllowUserToAddRows = false;
            this.dgv_ProductView.AllowUserToResizeColumns = false;
            this.dgv_ProductView.AllowUserToResizeRows = false;
            this.dgv_ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ProductView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_StockNumber,
            this.clm_ProductCode,
            this.clm_ProductName,
            this.clm_Available,
            this.clm_Quantity,
            this.clm_Select});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ProductView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProductView.Location = new System.Drawing.Point(12, 43);
            this.dgv_ProductView.Name = "dgv_ProductView";
            this.dgv_ProductView.RowHeadersVisible = false;
            this.dgv_ProductView.RowTemplate.Height = 25;
            this.dgv_ProductView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProductView.Size = new System.Drawing.Size(420, 236);
            this.dgv_ProductView.TabIndex = 18;
            // 
            // clm_StockNumber
            // 
            this.clm_StockNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clm_StockNumber.Frozen = true;
            this.clm_StockNumber.HeaderText = "Stock N.";
            this.clm_StockNumber.Name = "clm_StockNumber";
            this.clm_StockNumber.ReadOnly = true;
            this.clm_StockNumber.Width = 76;
            // 
            // clm_ProductCode
            // 
            this.clm_ProductCode.HeaderText = "Product Code";
            this.clm_ProductCode.Name = "clm_ProductCode";
            this.clm_ProductCode.ReadOnly = true;
            // 
            // clm_ProductName
            // 
            this.clm_ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_ProductName.HeaderText = "Product Name";
            this.clm_ProductName.Name = "clm_ProductName";
            this.clm_ProductName.ReadOnly = true;
            // 
            // clm_Available
            // 
            this.clm_Available.HeaderText = "Available";
            this.clm_Available.Name = "clm_Available";
            this.clm_Available.ReadOnly = true;
            this.clm_Available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clm_Quantity
            // 
            this.clm_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clm_Quantity.HeaderText = "Quantity";
            this.clm_Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.clm_Quantity.Name = "clm_Quantity";
            this.clm_Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clm_Quantity.Width = 78;
            // 
            // clm_Select
            // 
            this.clm_Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clm_Select.HeaderText = "Select";
            this.clm_Select.Name = "clm_Select";
            this.clm_Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clm_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clm_Select.Width = 63;
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(438, 67);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(85, 85);
            this.BTN_add.TabIndex = 22;
            this.BTN_add.Text = "ADD";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(438, 172);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(85, 85);
            this.BTN_Cancel.TabIndex = 24;
            this.BTN_Cancel.Text = "CANCEL";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // LBL_Info
            // 
            this.LBL_Info.AutoSize = true;
            this.LBL_Info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Info.Location = new System.Drawing.Point(12, 15);
            this.LBL_Info.Name = "LBL_Info";
            this.LBL_Info.Size = new System.Drawing.Size(129, 17);
            this.LBL_Info.TabIndex = 25;
            this.LBL_Info.Text = "Insert order number:";
            // 
            // TXT_OrderNumber
            // 
            this.TXT_OrderNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_OrderNumber.Location = new System.Drawing.Point(163, 12);
            this.TXT_OrderNumber.Name = "TXT_OrderNumber";
            this.TXT_OrderNumber.Size = new System.Drawing.Size(252, 25);
            this.TXT_OrderNumber.TabIndex = 26;
            // 
            // LBL_AddMSG
            // 
            this.LBL_AddMSG.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_AddMSG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_AddMSG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_AddMSG.Location = new System.Drawing.Point(0, 283);
            this.LBL_AddMSG.Name = "LBL_AddMSG";
            this.LBL_AddMSG.Size = new System.Drawing.Size(537, 20);
            this.LBL_AddMSG.TabIndex = 27;
            this.LBL_AddMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.LBL_AddMSG);
            this.Controls.Add(this.TXT_OrderNumber);
            this.Controls.Add(this.LBL_Info);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.dgv_ProductView);
            this.Name = "frm_OrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.frm_OrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ProductView;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LBL_Info;
        private System.Windows.Forms.TextBox TXT_OrderNumber;
        private System.Windows.Forms.Label LBL_AddMSG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StockNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Available;
        private System.Windows.Forms.DataGridViewComboBoxColumn clm_Quantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clm_Select;
    }
}