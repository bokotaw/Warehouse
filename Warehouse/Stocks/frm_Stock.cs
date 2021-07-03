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
    public partial class FRM_Stock : Form
    {

        public FRM_Stock()
        {
            InitializeComponent();
        }

        private void FRM_Stock_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(TXT_ProductCode.Text))
            {
                erp_Stock.Clear();
                erp_Stock.SetError(TXT_ProductCode, "Product Code Required");
            }
            else if (string.IsNullOrEmpty(TXT_ProductName.Text))
            {
                erp_Stock.Clear();
                erp_Stock.SetError(TXT_ProductName, "Product Name Required");
            }
            else
            {
                erp_Stock.Clear();
                result = true;
            }
            return result;
        }

        public static bool IfProductExists(SqlConnection con, string stockNumber)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [dbo].[Stocks] WHERE [Stock_Number]='" + stockNumber + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }


        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_StockAdd stockAdd = new();
            stockAdd.Show();
        }

        public void LoadData()
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new("SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID", con.Connection);
            DataTable dt = new();
            sda.Fill(dt);
            dgv_StockView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StockView.Rows.Add();
                dgv_StockView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StockView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StockView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StockView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StockView.Rows[n].Cells[4].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");

            }
            con.CloseCon();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            DataTable dt = new();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StockView.Rows.Add();
                dgv_StockView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StockView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StockView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StockView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StockView.Rows[n].Cells[5].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");

            }
            SqlDataAdapter sda = new();
            if (TXT_StockNumber.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE [Stock_Number] LIKE '%" + TXT_StockNumber.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            else if (TXT_ProductCode.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE Stocks.Product_ID LIKE '%" + TXT_ProductCode.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            else if(TXT_ProductName.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE Product_Name LIKE '%" + TXT_ProductName.Text + "%'", con.Connection);
                sda.Fill(dt);
            }

            dgv_StockView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StockView.Rows.Add();
                dgv_StockView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StockView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StockView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StockView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StockView.Rows[n].Cells[4].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");

            }
            con.CloseCon();
        }

        private void TXT_StockNumber_TextChanged(object sender, EventArgs e)
        {
            TXT_ProductCode.Clear();
            TXT_ProductName.Clear();
        }

        private void TXT_ProductCode_TextChanged(object sender, EventArgs e)
        {
            TXT_StockNumber.Clear();
            TXT_ProductName.Clear();
        }

        private void TXT_ProductName_TextChanged(object sender, EventArgs e)
        {
            TXT_StockNumber.Clear();
            TXT_ProductCode.Clear();
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            TXT_StockNumber.Clear();
            TXT_ProductCode.Clear();
            TXT_ProductName.Clear();
            LoadData();
            TXT_ProductCode.Focus();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure want you to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgv_StockView.SelectedRows.Count > 0)
                {
                    ConnectionClass con = new ConnectionClass();
                    con.OpenCon();
                    string stockNumber = dgv_StockView.CurrentRow.Cells[0].Value.ToString();
                    if (IfProductExists(con.Connection, stockNumber))
                    {
                        con.OpenCon();
                        string sqlQuery = @"DELETE FROM [dbo].[Stocks] WHERE [Stock_Number] = '" + Convert.ToInt32(stockNumber) + "'";
                        SqlCommand cmd = new(sqlQuery, con.Connection);
                        cmd.ExecuteNonQuery();
                        con.CloseCon();
                        FRM_Products.Show_MSG(LBL_StockMSG, "Record deleted", Color.Green);
                    }
                    else
                    {
                        FRM_Products.Show_MSG(LBL_StockMSG, "Error!", Color.Red);
                    }
                    LoadData();
                }
            }
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            FRM_Products.Show_MSG(LBL_StockMSG, "Done!", Color.Green);
        }

       

        

    }
}
