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
    public partial class frm_StockReport : Form
    {
        public frm_StockReport()
        {
            InitializeComponent();
        }

        private void frm_StockReport_Load(object sender, EventArgs e)
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
            dgv_StoRepView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StoRepView.Rows.Add();
                dgv_StoRepView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StoRepView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StoRepView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StoRepView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StoRepView.Rows[n].Cells[4].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");

            }
            con.CloseCon();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_StockNumber.Clear();
            txt_ProductCode.Clear();
            txt_ProductName.Focus();
            LoadData();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ConnectionClass con = new ConnectionClass();
            con.OpenCon();
            DataTable dt = new();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StoRepView.Rows.Add();
                dgv_StoRepView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StoRepView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StoRepView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StoRepView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StoRepView.Rows[n].Cells[4].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");
            }


            SqlDataAdapter sda = new();
            if (txt_StockNumber.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE [Stock_Number] LIKE '%" + txt_StockNumber.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            else if (txt_ProductCode.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE [Products].[Product_ID] LIKE '%" + txt_ProductCode.Text + "%'", con.Connection);
                sda.Fill(dt);
            }
            else if (txt_ProductName.Text.Length > 0)
            {
                sda = new(@"SELECT * FROM [dbo].[Stocks] LEFT JOIN [dbo].[Products] ON Stocks.Product_ID = Products.Product_ID WHERE [Product_Name] LIKE '%" + txt_ProductName.Text + "%'", con.Connection);
                sda.Fill(dt);
            }


            dgv_StoRepView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv_StoRepView.Rows.Add();
                dgv_StoRepView.Rows[n].Cells[0].Value = item["Stock_Number"].ToString();
                dgv_StoRepView.Rows[n].Cells[1].Value = item["Product_ID"].ToString();
                dgv_StoRepView.Rows[n].Cells[2].Value = item["Product_Name"].ToString();
                dgv_StoRepView.Rows[n].Cells[3].Value = item["Quantity"].ToString();
                dgv_StoRepView.Rows[n].Cells[4].Value = Convert.ToDateTime(item["Transaction_Date"].ToString()).ToString("dd/MM/yyyy");
            }
            con.CloseCon();
        }

        private void txt_StockNumber_TextChanged(object sender, EventArgs e)
        {
            txt_ProductCode.Clear();
            txt_ProductName.Clear();
        }

        private void txt_ProductCode_TextChanged(object sender, EventArgs e)
        {
            txt_StockNumber.Clear();
            txt_ProductName.Clear();
        }

        private void txt_ProductName_TextChanged(object sender, EventArgs e)
        {
            txt_StockNumber.Clear();
            txt_ProductCode.Clear();
        }
        private void btn_Export_Click(object sender, EventArgs e)
        {
            sfd_Stock.ShowDialog();
        }
        private void sfd_Stock_FileOk(object sender, CancelEventArgs e)
        {
            sfd_Stock.Filter = "csv File (.csv)|*.csv";
            string name = sfd_Stock.FileName;
            string csv = string.Empty;

            foreach (DataGridViewColumn clm in dgv_StoRepView.Columns)
            {
                csv += clm.HeaderText + ',';
            }

            csv += "\r\n";

            foreach (DataGridViewRow row in dgv_StoRepView.Rows)
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

