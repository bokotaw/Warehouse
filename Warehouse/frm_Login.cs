using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Username.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //To-do: Check login username & password
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                FROM[Warehouse].[dbo].[Login]
                WHERE Username = '"+txt_Username.Text+"' AND Password = '"+txt_Password.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count==1)
            {
                this.Hide();
                frm_WarehouseMain main = new frm_WarehouseMain();
                main.Show(); 
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btn_Clear_Click(sender, e);
            }
        }
    }
}
