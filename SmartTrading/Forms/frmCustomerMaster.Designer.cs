namespace SmartTrading.Forms
{
    partial class frmCustomerMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.cbtnlear = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.txtMob = new System.Windows.Forms.TextBox();
            this.txtPh = new System.Windows.Forms.TextBox();
            this.txtAddrs2 = new System.Windows.Forms.TextBox();
            this.txtAddrs1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.cbtnlear);
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.txtBal);
            this.panel1.Controls.Add(this.txtMob);
            this.panel1.Controls.Add(this.txtPh);
            this.panel1.Controls.Add(this.txtAddrs2);
            this.panel1.Controls.Add(this.txtAddrs1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 371);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Master";
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(237, 318);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 20;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // cbtnlear
            // 
            this.cbtnlear.Location = new System.Drawing.Point(141, 318);
            this.cbtnlear.Name = "cbtnlear";
            this.cbtnlear.Size = new System.Drawing.Size(75, 23);
            this.cbtnlear.TabIndex = 19;
            this.cbtnlear.Text = "Clear";
            this.cbtnlear.UseVisualStyleBackColor = true;
            this.cbtnlear.Click += new System.EventHandler(this.cbtnlear_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(46, 318);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 18;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(156, 271);
            this.txtBal.Name = "txtBal";
            this.txtBal.Size = new System.Drawing.Size(148, 20);
            this.txtBal.TabIndex = 13;
            this.txtBal.Text = "0";
            this.txtBal.TextChanged += new System.EventHandler(this.txtBal_TextChanged);
            // 
            // txtMob
            // 
            this.txtMob.Location = new System.Drawing.Point(156, 231);
            this.txtMob.MaxLength = 15;
            this.txtMob.Name = "txtMob";
            this.txtMob.Size = new System.Drawing.Size(148, 20);
            this.txtMob.TabIndex = 12;
            // 
            // txtPh
            // 
            this.txtPh.Location = new System.Drawing.Point(156, 191);
            this.txtPh.MaxLength = 15;
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(148, 20);
            this.txtPh.TabIndex = 11;
            // 
            // txtAddrs2
            // 
            this.txtAddrs2.Location = new System.Drawing.Point(156, 153);
            this.txtAddrs2.MaxLength = 255;
            this.txtAddrs2.Name = "txtAddrs2";
            this.txtAddrs2.Size = new System.Drawing.Size(148, 20);
            this.txtAddrs2.TabIndex = 10;
            // 
            // txtAddrs1
            // 
            this.txtAddrs1.Location = new System.Drawing.Point(156, 116);
            this.txtAddrs1.MaxLength = 255;
            this.txtAddrs1.Name = "txtAddrs1";
            this.txtAddrs1.Size = new System.Drawing.Size(148, 20);
            this.txtAddrs1.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 81);
            this.txtName.MaxLength = 255;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address 1  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // dgCustomer
            // 
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Location = new System.Drawing.Point(380, 12);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.Size = new System.Drawing.Size(508, 416);
            this.dgCustomer.TabIndex = 44;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmCustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 440);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustomerMaster";
            this.Text = "frmCustomerMaster";
            this.Load += new System.EventHandler(this.frmCustomerMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.TextBox txtMob;
        private System.Windows.Forms.TextBox txtPh;
        private System.Windows.Forms.TextBox txtAddrs2;
        private System.Windows.Forms.TextBox txtAddrs1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button cbtnlear;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.ErrorProvider err;
    }
}