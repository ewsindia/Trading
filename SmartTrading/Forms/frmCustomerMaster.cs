using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartTrading.Helper;
using SmartTrading.Models;

namespace SmartTrading.Forms
{
    public partial class frmCustomerMaster : Form
    {
        public frmCustomerMaster()
        {
            InitializeComponent();
        }
        CustomerMaster objCustomer;
        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void cbtnlear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtAddrs1.Clear();
            txtAddrs2.Clear();
            txtBal.Clear();
            txtMob.Clear();
            txtName.Clear();
            txtPh.Clear();

        }
        private void updateGrid()
        {
            MySqlGeneralFunction.fillGrid("select id,name,address1,phone,mobile from customer_master",ref dgCustomer);
            //MySqlGeneralFunction.fillGrid("select id,name,address1,phone,mobile from customer_master", ref dgCustomer);
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (Validator.isEmpty(txtName, err) || Validator.isEmpty(txtName, err) || Validator.isEmpty(txtAddrs1, err) || Validator.isEmpty(txtMob, err))
                return;
            if (!Validator.isMobile(txtMob, err) || !Validator.isNumber(txtBal, err))
                return;

            if (objCustomer == null)
            {
                objCustomer = new CustomerMaster();
                objCustomer.name = txtName.Text;
                objCustomer.address1 = txtAddrs1.Text;
                objCustomer.address2 = txtAddrs2.Text;
                objCustomer.balance = Convert.ToDouble(txtBal.Text);
                objCustomer.mobile =(long) Convert.ToInt64(txtMob.Text);
                objCustomer.phone = txtPh.Text;
                objCustomer.Save();

            }
            else
            {
                objCustomer.name = txtName.Text;
                objCustomer.address1 = txtAddrs1.Text;
                objCustomer.address2 = txtAddrs2.Text;
                objCustomer.balance = Convert.ToDouble(txtBal.Text);
                objCustomer.mobile = Convert.ToInt64(txtMob.Text);
                objCustomer.phone = txtPh.Text;
                objCustomer.Update();
                objCustomer = null;

            }
            clear();
            updateGrid();
        }

        private void txtBal_TextChanged(object sender, EventArgs e)
        {
            if (txtBal.Text.Length == 0)
                txtBal.Text = "0";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (! dgCustomer.Rows[e.RowIndex].IsNewRow)
            {
                CustomerMaster objCut = new CustomerMaster();
                objCustomer = objCut.GetById((int)dgCustomer.Rows[e.RowIndex].Cells[0].Value);
                txtName.Text = objCustomer.name;
                txtAddrs1.Text = objCustomer.address1;
                txtAddrs2.Text = objCustomer.address2;
                txtBal.Text = objCustomer.balance.ToString();
                txtMob.Text = objCustomer.mobile.ToString();
                txtPh.Text = objCustomer.phone;

                //MessageBox.Show("ok"+ dgCustomer.Rows[e.RowIndex]);
            }
        }

    }
}
