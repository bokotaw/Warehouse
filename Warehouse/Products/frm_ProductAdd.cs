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
    public partial class FRM_ProductAdd : Form
    {
        public FRM_ProductAdd()
        {
            InitializeComponent();
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {  
            string ProductCode = TXT_ProductCode.Text;
            string ProductName = TXT_ProductName.Text;
            int ProductStatus = CBX_ProductStatus.SelectedIndex;

            if (FRM_Products.Validation(ERP_ProductAdd, ProductCode, ProductName, ProductStatus, TXT_ProductCode, TXT_ProductName, CBX_ProductStatus))
            {
                ConnectionClass con = new ConnectionClass(); 
                con.OpenCon();
                bool status;
                if (CBX_ProductStatus.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                if (FRM_Products.IfProductExists(con.Connection, TXT_ProductCode.Text))
                {
                    FRM_Products.Show_MSG(LBL_AddMSG, "Product with this code already exists", Color.OrangeRed);
                }
                else
                {
                    string sqlQuery = @"INSERT INTO [dbo].[Products]
                                ([Product_ID],
                                [Product_Name],
                                [Product_Status])
                                VALUES
                                ('" + TXT_ProductCode.Text + "','" + TXT_ProductName.Text + "','" + status + "')";
                    SqlCommand cmd = new(sqlQuery, con.Connection);
                    cmd.ExecuteNonQuery();
                    con.CloseCon();
                    FRM_Products.Show_MSG(LBL_AddMSG, "Product added to list", Color.LightGreen);
                }

            }
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetRecords()
        {
            TXT_ProductCode.Clear();
            TXT_ProductName.Clear();
            CBX_ProductStatus.SelectedIndex = -1;
            TXT_ProductCode.Focus();
        }
    }
}
