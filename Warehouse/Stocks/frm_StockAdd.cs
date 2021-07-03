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
    public partial class FRM_StockAdd : Form
    {
        public FRM_StockAdd()
        {
            InitializeComponent();
        }

        private void FRM_StockAdd_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                ConnectionClass con = new ConnectionClass();
                con.OpenCon();
                string sqlQuery = @"INSERT INTO Stocks (Product_ID, Transaction_Date, Quantity)
                                VALUES ('" + CBX_ProductCode.Text + "', GETDATE(),'" + TXT_StockQuantity.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlQuery, con.Connection);
                cmd.ExecuteNonQuery();
                con.CloseCon();
                FRM_Products.Show_MSG(LBL_AddMSG, "Stock added", Color.Green);
            }
        }

        public void FillComboBox()
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Product_ID, Product_Name FROM [dbo].[Products] WHERE Product_Status = 1", con.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataRow row = dt.NewRow();
            row[0] = DBNull.Value;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            CBX_ProductCode.DataSource = dt;
            CBX_ProductCode.ValueMember = "Product_ID";
            CBX_ProductName.DataSource = dt;
            CBX_ProductName.DisplayMember = "Product_Name";
        }


        public bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(CBX_ProductCode.Text))
            {
                ERP_StockAdd.Clear();
                ERP_StockAdd.SetError(CBX_ProductCode, "Product Code Required");
            }
            else if (string.IsNullOrEmpty(CBX_ProductName.Text))
            {
                ERP_StockAdd.Clear();
                ERP_StockAdd.SetError(CBX_ProductName, "Product Name Required");
            }
            else if (string.IsNullOrEmpty(TXT_StockQuantity.Text))
            {
                ERP_StockAdd.Clear();
                ERP_StockAdd.SetError(TXT_StockQuantity, "Product Quantity Required");
            }
            else
            {
                ERP_StockAdd.Clear();
                result = true;
            }
            return result;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            CBX_ProductCode.SelectedIndex = 0;
            CBX_ProductName.SelectedIndex = 0;
            TXT_StockQuantity.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_StockQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
