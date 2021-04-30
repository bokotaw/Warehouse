using Microsoft.AspNet.SignalR.Infrastructure;
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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dtp_StockDate;
            cbx_Status.SelectedIndex = 0;
            LoadData();
            Search();
        }

        private void dtp_StockDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_ProductCode.Focus();
            }
        }

        private void txt_ProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_ProductCode.Text.Length > 0)
                {
                    txt_ProductCode.Text = dgv_SearchView.SelectedRows[0].Cells[0].Value.ToString();
                    txt_ProductName.Text = dgv_SearchView.SelectedRows[0].Cells[1].Value.ToString();
                    this.dgv_SearchView.Visible = true;
                    txt_Quantity.Focus();
                }
                else
                {
                    this.dgv_SearchView.Visible = false;
                }
            }
        }

        private void txt_ProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_ProductName.Text.Length > 0)
                {
                    txt_Quantity.Focus();
                }
                else
                {
                    txt_ProductName.Focus();
                }
            }
        }

        bool change = true;
        private void proCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (change)
            {
                change = false;
                txt_ProductCode.Text = dgv_SearchView.SelectedRows[0].Cells[0].Value.ToString();
                txt_ProductName.Text = dgv_SearchView.SelectedRows[0].Cells[1].Value.ToString();
                this.dgv_SearchView.Visible = false;
                txt_Quantity.Focus();
                change = true;
            }
        }

        private void txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Quantity.Text.Length > 0)
                {
                    cbx_Status.Focus();
                }
                else
                {
                    txt_Quantity.Focus();
                }
            }
        }

        private void cbx_Status_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbx_Status.SelectedIndex != -1)
                {
                    btn_Add.Focus();
                }
                else
                {
                    cbx_Status.Focus();
                }
            }
        }

        private void txt_ProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ResetRecords()
        {
            dtp_StockDate.Value = DateTime.Now;
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
            txt_Quantity.Clear();
            cbx_Status.SelectedIndex = -1;
            dtp_StockDate.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txt_ProductCode.Text))
            {
                erp_Stock.Clear();
                erp_Stock.SetError(txt_ProductCode, "Product Code Required");
            }
            else if (string.IsNullOrEmpty(txt_ProductName.Text))
            {
                erp_Stock.Clear();
                erp_Stock.SetError(txt_ProductName, "Product Name Required");
            }
            else if (string.IsNullOrEmpty(txt_Quantity.Text))
            {
                erp_Stock.Clear();
                erp_Stock.SetError(txt_Quantity, "Product Quantity Required");
            }
            else if(cbx_Status.SelectedIndex == -1)
            {
                erp_Stock.Clear();
                erp_Stock.SetError(cbx_Status, "Select Status");
            }
            else
            {
                erp_Stock.Clear();
                result = true;
            }
            return result;
        }

        private bool IfProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [dbo].[Stock] WHERE [Product_ID]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
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
                    sqlQuery = @"UPDATE [dbo].[Stock] SET [Product_ID] = '" +txt_ProductCode.Text+ "',[Product_Name] = '" + txt_ProductName.Text + "' ,[Quantity] = '" + txt_Quantity.Text + "' ,[Product_Status] = '" + status + "' WHERE [Product_ID] = '" + txt_ProductCode.Text + "'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO Stock (Product_ID, Product_Name, Transaction_Date, Quantity,Product_Status)
                                VALUES ('" + txt_ProductCode.Text + "','" + txt_ProductName.Text + "','" + dtp_StockDate.Value.ToString("MM/dd/yyyy") + "','" + txt_Quantity.Text + "','" + status + "')";
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully");
                LoadData();
                ResetRecords();
            }
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Stock]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_StockView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StockView.Rows.Add();
                dgv_StockView.Rows[n].Cells["clm_StockNo"].Value = n + 1;
                dgv_StockView.Rows[n].Cells["clm_ProductCode"].Value = item["Product_ID"].ToString();
                dgv_StockView.Rows[n].Cells["clm_ProductName"].Value = item["Product_Name"].ToString();
                dgv_StockView.Rows[n].Cells["clm_Quantity"].Value = float.Parse(item["Quantity"].ToString());
                dgv_StockView.Rows[n].Cells["clm_Date"].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/mm/yyyy");
                if ((bool)item["Product_Status"])
                {
                    dgv_StockView.Rows[n].Cells["clm_Status"].Value = "Active";
                }
                else
                {
                    dgv_StockView.Rows[n].Cells["clm_Status"].Value = "Deactive";
                }
            }

            if (dgv_StockView.Rows.Count > 0)
            {
                lbl_TotalProductNumber.Text = dgv_StockView.Rows.Count.ToString();
                float totQty = 0;
                for(int i = 0; i < dgv_StockView.Rows.Count; ++i)
                {
                    totQty += float.Parse(dgv_StockView.Rows[i].Cells["clm_Quantity"].Value.ToString());
                    lbl_TotalQuantityNumber.Text = totQty.ToString();
                }
            }
            else
            {
                lbl_TotalProductNumber.Text = "0";
                lbl_TotalQuantityNumber.Text = "0";
            }
        }

        private void dgv_StockView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_Add.Text = "Update";
            txt_ProductCode.Text = dgv_StockView.SelectedRows[0].Cells["clm_ProductCode"].Value.ToString();
            txt_ProductName.Text = dgv_StockView.SelectedRows[0].Cells["clm_ProductName"].Value.ToString();
            txt_Quantity.Text = dgv_StockView.SelectedRows[0].Cells["clm_Quantity"].Value.ToString();
            if (dgv_StockView.SelectedRows[0].Cells["clm_Status"].Value.ToString() == "Active")
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
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
                    var sqlQuery = "";
                    if (IfProductExists(con, txt_ProductCode.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [dbo].[Stock] WHERE [Product_ID] = '" + txt_ProductCode.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record does not exist");
                    }
                    LoadData();
                    ResetRecords();
                }
            }
        }
        private void txt_ProductCode_TextChanged(object sender, EventArgs e)
        {
            if (txt_ProductCode.Text.Length > 0)
            {
                this.dgv_SearchView.Visible = true;
                dgv_SearchView.BringToFront();
                Search(150, 105, 430, 200, "Pro Code,Pro Name", "100,0");
                this.dgv_SearchView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.proCode_MouseDoubleClick);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT TOP(100) Product_ID, Product_Name FROM [dbo].[Products] WHERE [Product_ID] LIKE '" + txt_ProductCode.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_SearchView.Rows.Clear();
                foreach(DataRow row in dt.Rows)
                {
                    int n = dgv_SearchView.Rows.Add();
                    dgv_SearchView.Rows[n].Cells[0].Value = row["Product_ID"].ToString();
                    dgv_SearchView.Rows[n].Cells[1].Value = row["Product_Name"].ToString();
                }
            }
            else
            {
                dgv_SearchView.Visible = false;
            }
        }

        private DataGridView dgv_SearchView;
        private DataGridViewTextBoxColumn clm_SearchProductCode;
        private DataGridViewTextBoxColumn clm_SearchProductName;

        void Search()
        {
            dgv_SearchView = new DataGridView();
            clm_SearchProductCode = new DataGridViewTextBoxColumn();
            clm_SearchProductName = new DataGridViewTextBoxColumn();
            this.dgv_SearchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.clm_SearchProductCode, this.clm_SearchProductName });
            this.dgv_SearchView.Name = "dgv_SearchView";
            dgv_SearchView.Visible = false;
            this.clm_SearchProductCode.Visible = false;
            this.clm_SearchProductName.Visible = false;
            this.dgv_SearchView.AllowUserToAddRows = false;
            this.dgv_SearchView.RowHeadersVisible = false;
            this.dgv_SearchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgv_SearchView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);

            this.Controls.Add(dgv_SearchView);
            this.dgv_SearchView.ReadOnly = true;
            dgv_SearchView.BringToFront();
        }

        void Search(int LX, int LY, int DW, int DH, string clm_Name, string clm_Size)
        {
            this.dgv_SearchView.Location = new System.Drawing.Point(LX, LY);
            this.dgv_SearchView.Size = new System.Drawing.Size(DW, DH);

            string[] ColSize = clm_Size.Split(',');
            //Size
            for(int i = 0; i < ColSize.Length; i++)
            {
                if (int.Parse(ColSize[i]) != 0)
                {
                    dgv_SearchView.Columns[i].Width = int.Parse(ColSize[i]);
                }
                else
                {
                    dgv_SearchView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            //Name
            string[] ColName = clm_Name.Split(',');

            for(int i = 0; i < ColName.Length; i++)
            {
                this.dgv_SearchView.Columns[i].HeaderText = ColName[i];
                this.dgv_SearchView.Columns[i].Visible = true;
            }
        }
    }
}
