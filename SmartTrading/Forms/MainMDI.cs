using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartTrading.Forms;
namespace SmartTrading
{
    public partial class MainMDI : Form
    {
        public MainMDI()
        {
            InitializeComponent();
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerMaster objCustomer = new frmCustomerMaster();
            objCustomer.ShowDialog();
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemMaster objItemMaster = new frmItemMaster();
            objItemMaster.Show();
        }

        private void shortformsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSingleFieldMaster objSGM = new frmSingleFieldMaster();
            objSGM.Show();
        }
    }
}
