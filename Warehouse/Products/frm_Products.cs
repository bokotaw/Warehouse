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
    public partial class FRM_Products : Form
    {
        public FRM_Products()
        {
            InitializeComponent();
        }
        private void FRM_Products_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            FRM_ProductAdd productAdd = new();
            productAdd.Show();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgv_ProductView.SelectedRows.Count > 0)
                {
                    ConnectionClass con = new ConnectionClass();
                    con.OpenCon();
                    string ProductCode = dgv_ProductView.CurrentRow.Cells[0].Value.ToString();
                    if (IfProductExists(con.Connection, ProductCode))
                    {
                        
                        string sqlQuery = @"DELETE FROM [dbo].[Products] WHERE [Product_ID] = '" + Convert.ToInt32(ProductCode) + "'";
                        SqlCommand cmd = new(sqlQuery, con.Connection);
                        cmd.ExecuteNonQuery();
                        con.CloseCon();
                        Show_MSG(LBL_ProductMSG, "Product deleted", Color.Red);
                    }
                    else
                    {
                        Show_MSG(LBL_ProductMSG, "Error!", Color.Red);
                    }
                    con.CloseCon();
                    LoadData();
                }
            }          
        }
        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            string ProductCode = dgv_ProductView.SelectedRows[0].Cells[0].Value.ToString();
            string ProductName = dgv_ProductView.SelectedRows[0].Cells[1].Value.ToString();
            bool ProductStatus;
            if ((bool)(dgv_ProductView.SelectedRows[0].Cells[2].Value.ToString() == "Active"))
            {
                ProductStatus = true;
            }
            else
            {
                ProductStatus = false;
            }
            FRM_ProductEdit productEdit = new(ProductCode, ProductName, ProductStatus);
            productEdit.Show();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            Show_MSG(LBL_ProductMSG, "Done!", Color.Green);
        }

        public static bool IfProductExists(SqlConnection con, string Product_ID)
        {
            
            SqlDataAdapter sda = new("SELECT * FROM [dbo].[Products] WHERE [Product_ID] = '" + Product_ID + "'", con);
            DataTable dt = new();
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
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new("SELECT * FROM [dbo].[Products]", con.Connection);
            DataTable dt = new();
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
            con.CloseCon();
        }

        public static bool Validation(ErrorProvider errorProvider, string ProductCode, string ProductName, int ProductStatus, TextBox txt_ProductCode, TextBox txt_ProductName, ComboBox cbx_ProductStatus)
        {
            bool result = false;
            if (string.IsNullOrEmpty(ProductCode))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ProductCode, "Product ID Requried");
            }
            else if (string.IsNullOrEmpty(ProductName))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ProductName, "Product name requried");
            }
            else if (ProductStatus == -1)
            {
                errorProvider.Clear();
                errorProvider.SetError(cbx_ProductStatus, "Select status");
            }
            else
            {
                result = true;
            }
            return result;
        }

        public static void Show_MSG(Label label, string msg, Color color)
        {
            label.Visible = true;
            label.Text = msg;
            label.BackColor = color;
            Timer timer = new();
            timer.Interval = 2000;
            timer.Tick += (object sender, EventArgs e) =>
            {
                label.Visible = false;
            };
            timer.Start();
        }

        public static void ResetRecords(TextBox ProductCode, TextBox ProductName, ComboBox ProductStatus)
        {
            ProductCode.Clear();
            ProductName.Clear();
            ProductStatus.SelectedIndex = -1;
            ProductCode.Focus();
        }


    }
}
