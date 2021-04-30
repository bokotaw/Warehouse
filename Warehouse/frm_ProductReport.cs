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
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Products]", con);
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
        }

        private void txt_ProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Products] WHERE [Product_ID] = '"+txt_ProductCode.Text+"'", con);
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
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            string csv = string.Empty;

            foreach(DataGridViewColumn clm in dgv_ProRepView.Columns)
            {
                csv += clm.HeaderText + ',';
            }

            csv += "\r\n";

            foreach(DataGridViewRow row in dgv_ProRepView.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    csv += cell.Value.ToString().Replace(",", ";") + ',';
                }

                csv += "\r\n";
            }

            string folderPath = "D:\\STUDIA\\";
            File.WriteAllText(folderPath + "Product Report.csv", csv);
        }
    }
}
