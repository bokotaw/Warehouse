using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class frm_ProductReport : Form
    {
        public frm_ProductReport()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Products]", con.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_ProRepView.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dgv_ProRepView.Rows.Add();
                dgv_ProRepView.Rows[n].Cells[0].Value = item["Product_ID"].ToString();
                dgv_ProRepView.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                if ((bool)item["Product_Status"])
                {
                    dgv_ProRepView.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dgv_ProRepView.Rows[n].Cells[2].Value = "Deactive";
                }
            }
            con.CloseCon();
        }

        private void frm_ProductReport_Load(object sender, EventArgs e)
        {
            cbx_Status.SelectedIndex = -1;
            LoadData();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
            cbx_Status.SelectedIndex = -1;
            txt_ProductCode.Focus();
            LoadData();
        }

        private void txt_ProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

       

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            DataTable dt = new();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_ProRepView.Rows.Add();
                dgv_ProRepView.Rows[n].Cells[0].Value = item["Product_ID"].ToString();
                dgv_ProRepView.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                dgv_ProRepView.Rows[n].Cells[2].Value = item["Product_Status"].ToString();
            }


            SqlDataAdapter sda = new();
            if (txt_ProductCode.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Products] WHERE [Product_ID] LIKE '%" + txt_ProductCode.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            else if (txt_ProductName.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Products] WHERE [Product_Name] LIKE '%" + txt_ProductName.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            if (cbx_Status.SelectedIndex == 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Products] WHERE [Product_Status] = 1", con.Connection);
                sda.Fill(dt);
            }
            else
            {
                sda = new(@"SELECT * FROM [dbo].[Products] WHERE [Product_Status] = 0", con.Connection);
                sda.Fill(dt);
            }

            dgv_ProRepView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_ProRepView.Rows.Add();
                dgv_ProRepView.Rows[n].Cells[0].Value = item["Product_ID"].ToString();
                dgv_ProRepView.Rows[n].Cells[1].Value = item["Product_Name"].ToString();
                if ((bool)item["Product_Status"])
                {
                    dgv_ProRepView.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dgv_ProRepView.Rows[n].Cells[2].Value = "Deactive";
                }
            }
            con.CloseCon();
        }

        private void txt_ProductCode_TextChanged(object sender, EventArgs e)
        {
            txt_ProductName.Clear();
            cbx_Status.SelectedIndex = -1;
        }

        private void txt_ProductName_TextChanged(object sender, EventArgs e)
        {
            txt_ProductCode.Clear();
            cbx_Status.SelectedIndex = -1;
        }

        private void cbx_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            sfd_Products.ShowDialog();
        }

        private void svd_Products_FileOk(object sender, CancelEventArgs e)
        {
            sfd_Products.Filter = "csv File (.csv)|*.csv";
            string name = sfd_Products.FileName;     
            string csv = string.Empty;

            foreach (DataGridViewColumn clm in dgv_ProRepView.Columns)
            {
                csv += clm.HeaderText + ',';
            }

            csv += "\r\n";

            foreach (DataGridViewRow row in dgv_ProRepView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                csv += "\r\n";
            }

            File.WriteAllText(name, csv);
        }
    }
}
