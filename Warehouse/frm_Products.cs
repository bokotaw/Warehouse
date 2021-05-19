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
    public partial class frm_Products : Form
    {
        public frm_Products()
        {
            InitializeComponent();
        }
        private void frm_Products_Load(object sender, EventArgs e)
        {
            cbx_Status.SelectedIndex = -1;
            LoadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
                //insert logic
                con.Open();
                bool status = false;
                if (cbx_Status.SelectedIndex == 0)
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
                    sqlQuery = @"UPDATE [dbo].[Products] SET [Product_Name] = '" + txt_ProductName.Text + "',[Product_Status] = '" + status + "' WHERE [Product_ID] = '" + txt_ProductCode.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [dbo].[Products]
                ([Product_ID],
                [Product_Name],
                [Product_Status])
                VALUES
                ('" + txt_ProductCode.Text + "','" + txt_ProductName.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                //Reading Data
                LoadData();
            }
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

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_ProductView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_ProductView.Rows.Add();
                dgv_ProductView.Rows[n].Cells[0].Value = item["Product_ID"].ToString();
                dgv_ProductView.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                if ((bool)item["Product_Status"])
                {
                    dgv_ProductView.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dgv_ProductView.Rows[n].Cells[2].Value = "Deactive";
                }
            }
        }

        private void dgv_DataView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_ProductCode.Text = dgv_ProductView.SelectedRows[0].Cells[0].Value.ToString();
            txt_ProductName.Text = dgv_ProductView.SelectedRows[0].Cells[1].Value.ToString();
            if (dgv_ProductView.SelectedRows[0].Cells[2].Value.ToString()=="Active")
            {
                cbx_Status.SelectedIndex = 0;
            }
            else
            {
                cbx_Status.SelectedIndex = 1;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
                    var sqlQuery = "";
                    if (IfProductExists(con, txt_ProductCode.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [dbo].[Products] WHERE [Product_ID] = '" + txt_ProductCode.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                    ResetRecords();
                }
            }

        }

        private void ResetRecords()
        {
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
            cbx_Status.SelectedIndex = -1;
            txt_ProductCode.Focus();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txt_ProductCode.Text))
            {
                erp_Products.Clear();
                erp_Products.SetError(txt_ProductCode, "Product ID Requried");
            }
            else if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                erp_Products.Clear();
                erp_Products.SetError(txt_ProductName, "Product name requried");
            }
            else if (cbx_Status.SelectedIndex == -1)
            {
                erp_Products.Clear();
                erp_Products.SetError(cbx_Status, "Select status");
            }
            else
            {
                result = true;
            }
            return result;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            frm_ProductAdd productAdd = new frm_ProductAdd();
            //productAdd.MdiParent = this;
            productAdd.Show();
        }
    }
}
