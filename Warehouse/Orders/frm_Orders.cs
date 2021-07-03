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
    public partial class frm_Orders : Form
    {
        public frm_Orders()
        {
            InitializeComponent();
        }

        private void frm_Orders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new("SELECT * FROM [dbo].[Orders] LEFT JOIN [dbo].[Products] ON Orders.Product_ID = Products.Product_ID", con.Connection);
            DataTable dt = new();
            sda.Fill(dt);
            dgv_OrdersView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_OrdersView.Rows.Add();
                dgv_OrdersView.Rows[n].Cells[0].Value = item["Order_ID"].ToString();
                dgv_OrdersView.Rows[n].Cells[1].Value = item["Order_Nu"].ToString();
                dgv_OrdersView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_OrdersView.Rows[n].Cells[3].Value = item["Quantity"].ToString();

            }
            con.CloseCon();
        }


        private void BTN_add_Click(object sender, EventArgs e)
        {
            frm_OrderAdd orderAdd = new();
            orderAdd.Show();
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure want you to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgv_OrdersView.SelectedRows.Count > 0)
                {
                    ConnectionClass con = new ConnectionClass();
                    con.OpenCon();
                    string orderNumber = dgv_OrdersView.CurrentRow.Cells[0].Value.ToString();               
                    string sqlQuery = @"DELETE FROM [dbo].[Orders] WHERE [Order_ID] = '" + Convert.ToInt32(orderNumber) + "'";
                    SqlCommand cmd = new(sqlQuery, con.Connection);
                    cmd.ExecuteNonQuery();
                    con.CloseCon();
                    LoadData();
                }
            }
        }

        private void BTN_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
