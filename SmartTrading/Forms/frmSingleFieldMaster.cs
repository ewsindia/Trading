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
    public partial class frmSingleFieldMaster : Form
    {
        public frmSingleFieldMaster()
        {
            InitializeComponent();
        }
        SingleFieldMaster objSngleFieldMaster=null;
        private void frmSingleFieldMaster_Load(object sender, EventArgs e)
        {
            fillGrid();
        }
        private void fillGrid()
        {
            MySqlGeneralFunction.fillGrid("select * from singlefieldmaster where type='Item Types'", dgsinglefieldmaster);
        }
        private void clear()
        {
            txtName.Clear();
            txtDescripton.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbtnlear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (Validator.isEmpty(txtName, err) || Validator.isEmpty(txtDescripton, err))
                return;
            if (txtName.Text.IndexOf(" ") >= 0)
            {
                err.SetError(txtName, "Space is not allowed here!");
                return;

            }
            else
            {
                err.SetError(txtName, "");
            }
            if (objSngleFieldMaster == null)
            {
                objSngleFieldMaster = new SingleFieldMaster();
                objSngleFieldMaster.name = txtName.Text;
                objSngleFieldMaster.description = txtDescripton.Text;
                objSngleFieldMaster.type = "Item Types";
                objSngleFieldMaster.Save();
                objSngleFieldMaster = null;
            }
            else
            {
                objSngleFieldMaster.name = txtName.Text;
                objSngleFieldMaster.description = txtDescripton.Text;
                objSngleFieldMaster.Update();
                objSngleFieldMaster = null;
            }
            fillGrid();
        }

        private void dgsinglefieldmaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objSngleFieldMaster = new SingleFieldMaster();
            objSngleFieldMaster.GetById(10);
            txtDescripton.Text = objSngleFieldMaster.description;
            txtName.Text = objSngleFieldMaster.name;
        }
    }
}
