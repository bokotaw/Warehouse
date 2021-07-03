using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class FRM_WarehouseMain : Form
    {
        public FRM_WarehouseMain()
        {
            InitializeComponent();
        }

        bool close = true;
        private void FRM_WarehouseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void MST_Products_Click(object sender, EventArgs e)
        {
            FRM_Products pro = new();
            pro.MdiParent = this;
            pro.Show();
        }

        private void MST_Stock_Click(object sender, EventArgs e)
        {
            FRM_Stock stk = new();
            stk.MdiParent = this;
            stk.Show();
        }

        private void TSM_ProductList_Click(object sender, EventArgs e)
        {
            frm_ProductReport prep = new();
            prep.MdiParent = this;
            prep.Show();
        }

        private void TSM_Orders_Click(object sender, EventArgs e)
        {
            frm_Orders ord = new();
            ord.MdiParent = this;
            ord.Show();
        }

        private void tsm_StockList_Click(object sender, EventArgs e)
        {
            frm_StockReport srep = new();
            srep.MdiParent = this;
            srep.Show();
        }
    }
}
