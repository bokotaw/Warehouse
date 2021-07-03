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
    public partial class FRM_ProductEdit : Form
    {
        public FRM_ProductEdit(string ProductCode, string ProductName, bool ProductStatus)
        {
            InitializeComponent();
            TXT_ProductCode.Text = ProductCode;
            TXT_ProductName.Text = ProductName;
            if (ProductStatus == true)
            {
                CBX_ProductStatus.SelectedIndex = 0;
            }
            else
            {
                CBX_ProductStatus.SelectedIndex = 1;
            }
        }

        private void BTN_edit_Click(object sender, EventArgs e)
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
                string sqlQuery = @"UPDATE [dbo].[Products] SET [Product_Name] = '" + TXT_ProductName.Text + "',[Product_Status] = '" + status + "' " +
                                   "WHERE [Product_ID] = '" + TXT_ProductCode.Text + "'";
                FRM_Products.Show_MSG(LBL_AddMSG, "Porduct updated", Color.Green);

                SqlCommand cmd = new(sqlQuery, con.Connection);
                cmd.ExecuteNonQuery();
                con.CloseCon();
            }
            else
            {
                FRM_Products.Show_MSG(LBL_AddMSG, "Error", Color.Red);
            }
        }

        public void BTN_Reset_Click(object sender, EventArgs e)
        {
            FRM_Products.ResetRecords(TXT_ProductCode,TXT_ProductName,CBX_ProductStatus);
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

   
