using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SmartTrading.Helper;
using SmartTrading.Models;

namespace SmartTrading.Forms
{
    public partial class frmItemMaster : Form
    {
       
        public frmItemMaster()
        {
            InitializeComponent();
        }
        ItemMaster objItem;
        int unit;
        private void savebtn_Click(object sender, EventArgs e)
        {
             
            

            if ( Validator.isEmpty(ref txtitemname, ref err) || Validator.isEmpty(ref txtcurrentqty, ref err) || Validator.isEmpty(ref txtminqty, ref err) || Validator.isEmpty(ref txtmaxqty, ref err) || Validator.isEmpty(ref txtpurchase, ref err) || Validator.isEmpty(ref txtsalerate, ref err) || Validator.isEmpty(ref combovat, ref err))
            {
                return;
            }

            if (!Validator.isNumber(ref txtwidth, ref err) || !Validator.isNumber(ref txtheight, ref err) || !Validator.isNumber(ref txtweight, ref err) || !Validator.isNumber(ref txtcurrentqty, ref err) || !Validator.isNumber(ref txtminqty, ref err) || !Validator.isNumber(ref txtmaxqty, ref err) || !Validator.isNumber(ref txtpurchase, ref err) || !Validator.isNumber(ref txtsalerate, ref err))
            {
                return;
            }
            

            if (objItem == null)
            {
                
                ItemMaster objitem = new ItemMaster();

                objitem.name = txtitemname.Text;
                int type1;
                if (txttype1.Text.Length != 0)
                {
                     type1 = Convert.ToInt16(MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}' and type='item types'", txttype1.Text)));
                    if (type1 == 0)
                    {
                        err.SetError(txttype1, "This type does not exist!");
                        return;
                    }
                    else
                    {
                        err.SetError(txttype1, "");

                    }
                    objitem.type1 =type1;
                }
                

                int type2 = Convert.ToInt16(MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}'", txttype2.Text)));
                if (txttype2.Text.Length != 0)
                {
                    if (type2 == 0)
                    {
                        err.SetError(txttype2, "This type does not exist!");
                        return;
                    }
                    else
                    {
                        err.SetError(txttype2, "");
                    }
                    objitem.type2 = type2;
                }   
                if (txtwidth.Text.Length > 0)
                {
                    objitem.width = Convert.ToDouble(txtwidth.Text);
                    unit = Convert.ToInt16(MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}' and type='unit'", cmbWH.Text)));
                }
                if (txtwidth.Text.Length > 0)
                {

                    objitem.height = Convert.ToDouble(txtheight.Text);
                    unit = Convert.ToInt16(MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}' and type='unit'", cmbWH.Text)));
                }
                if (txtwidth.Text.Length > 0)
                {

                    objitem.weight = Convert.ToDouble(txtweight.Text);
                        unit = Convert.ToInt16(MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}' and type='unit'", cmbWeight.Text)));
                }
                    
                objitem.unit = unit;
                objitem.currentqty = Convert.ToInt16(txtcurrentqty.Text);
                objitem.saleqty = 0;
                objitem.minqty = Convert.ToInt16(txtminqty.Text);
                objitem.maxqty = Convert.ToInt16(txtmaxqty.Text);                   
                objitem.purchesrate = Convert.ToInt16(txtpurchase.Text);
                objitem.salerate = Convert.ToInt16(txtsalerate.Text);
                objitem.otherspacification1 = txtotherspecification1.Text;
                objitem.otherspacification2 = txtotherspecification2.Text;
                objitem.description = txtdescription.Text;
                objitem.vat = Convert.ToDouble(combovat.Text);
                if (rdbLose.Checked == true)
                {
                    objitem.saletype = 1;
                }
                else
                {
                    objitem.saletype = 2;
                }
                objitem.Save();

               
            }
            else
            {

                objItem.name = txtitemname.Text;
                

                objItem.Update();
                objItem = null;
            }
            MySqlGeneralFunction.fillGrid("select * from item_master", ref dggroup);
            dggroup.AutoResizeColumns();
            MessageBox.Show("Data is saved!");
            cleartext();
            
        }

        private void cbtnlear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        public void cleartext()
        {
          
            txtitemname.Clear();
            txttype1.Clear();
            txttype2.Clear();
            txtwidth.Clear();
            txtheight.Clear();
            txtweight.Clear();           
           txtcurrentqty.Clear();
           combovat.Text = "";
            txtminqty.Clear();
            txtmaxqty.Clear();
            txtpurchase.Clear();
            txtsalerate.Clear();
            txtotherspecification1.Clear();
            txtotherspecification2.Clear();
            txtdescription.Clear();     
          

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            MySqlGeneralFunction.fillGrid("select * from item_master", ref dggroup);
            dggroup.AutoResizeColumns();

            DataSet ds = MySqlGeneralFunction.ExecuteDataset("select name from singlefieldmaster where type='vat'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                combovat.Items.Add (dr["name"].ToString());

            }

             ds = MySqlGeneralFunction.ExecuteDataset("select name from singlefieldmaster where type='Unit'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmbWeight.Items.Add(dr["name"].ToString());

            }
            
        }

        private void txtunit_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void dggroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            objItem = DBItemMaster.getById(e.RowIndex + 1);
            if (objItem != null)
            {
                txtitemname.Text = objItem.name;
                string type1=MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT name FROM singlefieldmaster where  id='{0}'",txttype1.Text)).ToString();

                string type2 = MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT name FROM singlefieldmaster where  id='{0}'", txttype2.Text)).ToString();
                txtheight.Text = objItem.height.ToString();
                txtweight.Text = objItem.weight.ToString();
                txtwidth.Text = objItem.width.ToString();
                string unit = MySqlGeneralFunction.ExecuteScalar(String.Format("SELECT id FROM singlefieldmaster where name='{0}' and type='unit'", objItem.unit)).ToString();
                txtcurrentqty.Text = objItem.currentqty.ToString();
                txtminqty.Text = objItem.minqty.ToString();
                txtmaxqty.Text = objItem.maxqty.ToString();
                
                txtpurchase.Text = objItem.purchesrate.ToString();
                txtsalerate.Text = objItem.salerate.ToString();
                combovat.Text = objItem.vat.ToString();
                txtotherspecification1.Text = objItem.otherspacification1;
                txtotherspecification2.Text = objItem.otherspacification2;
                txtdescription.Text = objItem.description;
            }
        }
        private void clearWHQty()
        {
            txtwidth.Text = "";
            txtheight.Text = "";
            txtWHQty.Text = "";
            if (txtweight.Text.Length>0 && !Validator.isNumber(txtweight, err, "Enter valid weight"))
                return;
            if (txtWqty.Text.Length > 0 && !Validator.isNumber(txtWqty, err, "Enter valid quantity"))
                return;
            
            if (rdbLose.Checked == true)
            
            {
                
                    if (txtWqty.Text.Length == 0)
                    {
                        txtcurrentqty.Text = "";
                        Validator.isEmpty(txtWqty, err, "Please select quantity!");
                        return;
                    }
                txtcurrentqty.Text = (Convert.ToInt16(txtweight.Text) * Convert.ToInt16(txtWqty.Text))+"";
            }

        }
        private void clearWQty()
        {
            txtweight.Text = "";
            
            txtWqty.Text = "";
            if (txtheight.Text.Length > 0 && txtwidth.Text.Length <= 0)
                return;

            if (txtheight.Text.Length > 0 && !Validator.isNumber(txtheight, err, "Enter valid height"))
                return;
            if (txtwidth.Text.Length > 0 && !Validator.isNumber(txtwidth, err, "Enter valid weight"))
                return;
            if (txtWHQty.Text.Length > 0 && !Validator.isNumber(txtWHQty, err, "Enter valid quantity"))
                return;

            
            if (rdbLose.Checked == true)
            {
                if (txtWHQty.Text.Length == 0)
                {
                    txtcurrentqty.Text = "";
                    Validator.isEmpty(txtWHQty, err, "Please select quantity!");
                    return;
                }
                if (txtheight.Text.Length > 0 && txtwidth.Text.Length > 0)
                {
                    txtcurrentqty.Text = (Convert.ToInt16(txtheight.Text) *Convert.ToInt16(txtwidth.Text) * Convert.ToInt16(txtWHQty.Text)) + "";
                }
                else if (txtheight.Text.Length > 0)
                {
                    txtcurrentqty.Text = (Convert.ToInt16(txtheight.Text) *Convert.ToInt16(txtWHQty.Text)) + "";
                }
                else if (txtwidth.Text.Length > 0)
                {
                    txtcurrentqty.Text = (Convert.ToInt16(txtwidth.Text) * Convert.ToInt16(txtWHQty.Text)) + "";
                }
                               
                
            }
        }
        private void curentqtylbl_Click(object sender, EventArgs e)
        {

        }

        private void txtweight_TextChanged(object sender, EventArgs e)
        {
            clearWHQty();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clearWHQty();
        }

        private void rdbLose_CheckedChanged(object sender, EventArgs e)
        {
            txtcurrentqty.Text = "";
            txtWqty.Text = "";
            txtWHQty.Text = "";
            if (rdbLose.Checked == true)
            {
                txtcurrentqty.Enabled = false;
                txtWHQty.Enabled=true;
                txtWqty.Enabled=true;
            }
        }

        private void rdbQty_CheckedChanged(object sender, EventArgs e)
        {
            txtcurrentqty.Text = "";
            txtWqty.Text = "";
            txtWHQty.Text = "";
            if (rdbQty.Checked == true)
            {
                txtcurrentqty.Enabled = true;
                txtWHQty.Enabled = false;
                txtWqty.Enabled = false;
            }
        }

        private void txtwidth_TextChanged(object sender, EventArgs e)
        {
            clearWQty();
        }

        private void txtheight_TextChanged(object sender, EventArgs e)
        {
            clearWQty();
        }

        private void txtWHQty_TextChanged(object sender, EventArgs e)
        {
            clearWQty();
        }

        
    }
}
