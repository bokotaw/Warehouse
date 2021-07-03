
namespace Warehouse
{
    partial class FRM_Login
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
            this.TXT_Username = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.TXT_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Username.Location = new System.Drawing.Point(108, 36);
            this.TXT_Username.Name = "txt_Username";
            this.TXT_Username.Size = new System.Drawing.Size(170, 25);
            this.TXT_Username.TabIndex = 0;
            this.TXT_Username.Text = "admin";
            // 
            // txt_Password
            // 
            this.TXT_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Password.Location = new System.Drawing.Point(108, 81);
            this.TXT_Password.Name = "txt_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.Size = new System.Drawing.Size(170, 25);
            this.TXT_Password.TabIndex = 1;
            this.TXT_Password.Text = "admin";
            // 
            // lbl_Username
            // 
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Username.Location = new System.Drawing.Point(12, 39);
            this.LBL_Username.Name = "lbl_Username";
            this.LBL_Username.Size = new System.Drawing.Size(81, 17);
            this.LBL_Username.TabIndex = 2;
            this.LBL_Username.Text = "User Name :";
            // 
            // lbl_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Password.Location = new System.Drawing.Point(22, 84);
            this.LBL_Password.Name = "lbl_Password";
            this.LBL_Password.Size = new System.Drawing.Size(71, 17);
            this.LBL_Password.TabIndex = 3;
            this.LBL_Password.Text = "Password :";
            // 
            // btn_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Clear.Location = new System.Drawing.Point(108, 121);
            this.BTN_Clear.Name = "btn_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(75, 23);
            this.BTN_Clear.TabIndex = 4;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // btn_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(203, 121);
            this.BTN_Login.Name = "btn_Login";
            this.BTN_Login.Size = new System.Drawing.Size(75, 23);
            this.BTN_Login.TabIndex = 5;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.BTN_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 164);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Username);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_Username);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Username;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_Login;
    }
}