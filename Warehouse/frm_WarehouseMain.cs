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
    public partial class frm_WarehouseMain : Form
    {
        public frm_WarehouseMain()
        {
            InitializeComponent();
        }

        bool close = true;
        private void frm_WarehouseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void mst_Products_Click(object sender, EventArgs e)
        {
            frm_Products pro = new frm_Products();
            pro.MdiParent = this;
            pro.Show();
        }

        private void mst_Stock_Click(object sender, EventArgs e)
        {
            Stock stk = new Stock();
            stk.MdiParent = this;
            stk.Show();
        }
    }
}
