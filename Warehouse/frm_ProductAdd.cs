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
    public partial class frm_ProductAdd : Form
    {
        public frm_ProductAdd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
                con.Open();
                bool status = false;
                if (cbx_ProductStatus.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                var sqlQuery = "";
                if (IfProductExists(con, txt_ProductCode.Text))
                {
                    MessageBox.Show("Product with this code already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sqlQuery = @"INSERT INTO [dbo].[Products]
                                ([Product_ID],
                                [Product_Name],
                                [Product_Status])
                                VALUES
                                ('" + txt_ProductCode.Text + "','" + txt_ProductName.Text + "','" + status + "')";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


            }
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txt_ProductCode.Text))
            {
                erp_ProductsAdd.Clear();
                erp_ProductsAdd.SetError(txt_ProductCode, "Product ID Requried");
            }
            else if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                erp_ProductsAdd.Clear();
                erp_ProductsAdd.SetError(txt_ProductName, "Product name requried");
            }
            else if (cbx_ProductStatus.SelectedIndex == -1)
            {
                erp_ProductsAdd.Clear();
                erp_ProductsAdd.SetError(cbx_ProductStatus, "Select status");
            }
            else
            {
                result = true;
            }
            return result;
        }
        private bool IfProductExists(SqlConnection con, string Product_ID)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Products] WHERE [Product_ID] = '" + Product_ID + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ResetRecords()
        {
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
            cbx_ProductStatus.SelectedIndex = -1;
            txt_ProductCode.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }
    }
}
