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
    public partial class frm_OrderAdd : Form
    {
        public frm_OrderAdd()
        {
            InitializeComponent();
        }

        private void frm_OrderAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new("SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID", con.Connection);
            DataTable dt = new();
            sda.Fill(dt);
            dgv_ProductView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_ProductView.Rows.Add();
                dgv_ProductView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_ProductView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_ProductView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_ProductView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
            }
            con.CloseCon();
        }

        List<int> selectedStockNumber = new List<int>();
        List<int> quantityList = new List<int>();
        List<int> productList = new List<int>();

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TXT_OrderNumber.Text)){
                FRM_Products.Show_MSG(LBL_AddMSG, "Insert order number", Color.Red);
            }
            else
            {
                selectedStockNumber.Clear();
                quantityList.Clear();
                productList.Clear();

                foreach (DataGridViewRow rows in dgv_ProductView.Rows)
                {
                    if (Convert.ToBoolean(rows.Cells["clm_Select"].Value))
                    {
                        selectedStockNumber.Add(Convert.ToInt32(rows.Cells["clm_StockNumber"].Value));
                        quantityList.Add(Convert.ToInt32(rows.Cells["clm_Quantity"].Value));
                        productList.Add(Convert.ToInt32(rows.Cells["clm_ProductCode"].Value));
                    }

                }
                ConnectionClass con = new ConnectionClass();
                con.OpenCon();
                int i = 0;
                foreach (var item in selectedStockNumber)
                {
                    string sqlQuery = @"INSERT INTO Orders (Order_Nu, Product_ID, Quantity, Stock_Number) VALUES ('" + TXT_OrderNumber.Text + "','" + productList[i] + "', '" + quantityList[i] + "','" + item + "') ";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con.Connection);
                    cmd.ExecuteNonQuery();
                    i++;
                }
                int n = 0;
                foreach (var item in selectedStockNumber)
                {
                    string sqlQuery = @"UPDATE [dbo].[Stocks] SET Quantity = Quantity - '" + quantityList[n] + "' WHERE Stock_Number = '" + selectedStockNumber[n] + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con.Connection);
                    cmd.ExecuteNonQuery();
                    n++;
                }
                FRM_Products.Show_MSG(LBL_AddMSG, "Order added", Color.Green);
                con.CloseCon();
            }
            
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
