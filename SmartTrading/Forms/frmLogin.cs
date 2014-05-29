using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SmartTrading.Helper;
using System.Management;
namespace SmartSMSSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool isLoggedIn;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            isLoggedIn = false;
           /* try
            {
                string path = Application.StartupPath + "\\xCode.dll";
                if (File.Exists(Application.StartupPath + "\\xCode.dll"))
                {
                    TextReader textReader = new StreamReader(path);
                    string strData = textReader.ReadToEnd();
                    DateTime storedDate = Convert.ToDateTime(clsCryptography.Decrypt1(strData, true));

                    int totDays = Convert.ToInt32((storedDate - DateTime.Now).TotalDays);
                    textReader.Close();
                    MessageBox.Show(storedDate+" = " + DateTime.Now);
                    if (storedDate < DateTime.Now)
                    {
                        TextWriter tw = new StreamWriter(path, false);
                        tw.Write("" + clsCryptography.Encrypt2(DateTime.Now.ToString("dd-MMM-yyyy"), true));
                        tw.Close();
                    }
                    else
                    {
                        if (totDays >= 0)
                        {
                            MessageBox.Show("System date is not uptodate");
                            Application.Exit();
                        }


                    }

                }
                else
                {
                    MessageBox.Show("Please purches license fron administrator");
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }*/
            try
            {
                if (fnValidateSerialNo())
                {
                   // if (!this.ObjclsUserDetails.fn_SetConnectionString())
                    {
                      //  frmError.SetError(butLogin, "Error Getting Connection string");
                        //MessageBox.Show("Error Getting Connection string", clsDeclarations.GBL_APPCAPTION, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    frmActivation objAct = new frmActivation();
                    objAct.str1 = fnGetSystemSerialNo1();
                    objAct.ShowDialog();
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to load application");
            }
        }
        public string fnGetSystemSerialNo1()
        {
            string startupPath = Application.StartupPath;
            string str = startupPath.Substring(0, 1);
            ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
            managementObject.Get();
            string strData = managementObject["VolumeSerialNumber"].ToString();
            return clsCryptography.Encrypt1(strData, true);
        }
        public string fnGetSystemSerialNo2()
        {
            string strData = "";
            try
            {
                string startupPath = Application.StartupPath;
                string str = startupPath.Substring(0, 1);
                ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
                managementObject.Get();
                strData = managementObject["VolumeSerialNumber"].ToString();
            }
            catch (Exception)
            {
            }
            return strData;
        }

        
        public bool fnValidateSerialNo()
        {
            bool result = false;
            if (File.Exists(Application.StartupPath + "\\xKey.dll"))
            {
                try
                {
                    //MessageBox.Show("Key checking");
                    TextReader textReader = new StreamReader(Application.StartupPath + "\\xKey.dll");
                    string[] strData = (textReader.ReadToEnd()).Split('#');
                    //MessageBox.Show("String contaisn " + strData.Length);
                    string text = clsCryptography.Decrypt1(strData[0], true);
                    //MessageBox.Show("String contaisn " + text);
                    //DateTime valDate = Convert.ToDateTime(clsCryptography.Decrypt1(strData[1], true));
                    //MessageBox.Show("String date " + valDate);
                    // MessageBox.Show(clsCryptography.Decrypt2(text, true) + "=" + fnGetSystemSerialNo2());
                    if (clsCryptography.Decrypt2(text, true) == fnGetSystemSerialNo2())
                    {
                        //if (DateTime.Now <= valDate)
                        {
                            result = true;
                        }
                        //else
                        {
                          //  result = false;
                        }
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Excepttion " + e.Message);
                }
            }
            else
            {
                MessageBox.Show("file not exist");
                result = false;
            }
            return result;
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

            string pass1 = "";//Convert.ToString(DBAccess.ExecuteScalar(String.Format("select password from user_master where user_name='{0}'", textBox1.Text)));
            string pass2 = textBox2.Text;
            int validpass = String.CompareOrdinal(pass1, pass2);
            if (validpass == 0)
            
            {
                isLoggedIn = true; 
                this.Close();
                  
                    
            }
            else
            {
                frmError.SetError(butLogin, "Please check username or password!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggedIn)
            {
                Application.Exit();
            }
        }

    }
}
