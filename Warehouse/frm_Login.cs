using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXT_Username.Clear();
            TXT_Password.Clear();
            TXT_Username.Focus();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new(@"SELECT * FROM [Warehouse].[dbo].[Users]
                                       WHERE Username = '" + TXT_Username.Text + "' AND Password = '" + TXT_Password.Text + "'", con.Connection);
            DataTable dt = new();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                FRM_WarehouseMain main = new();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTN_Clear_Click(sender, e);
            }
        }
    }
}
