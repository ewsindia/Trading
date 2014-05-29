namespace SmartTrading.Forms
{
    partial class frmSingleFieldMaster
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
            this.exitbtn = new System.Windows.Forms.Button();
            this.cbtnlear = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.dgsinglefieldmaster = new System.Windows.Forms.DataGridView();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescripton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgsinglefieldmaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(197, 206);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 20;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // cbtnlear
            // 
            this.cbtnlear.Location = new System.Drawing.Point(101, 206);
            this.cbtnlear.Name = "cbtnlear";
            this.cbtnlear.Size = new System.Drawing.Size(75, 23);
            this.cbtnlear.TabIndex = 19;
            this.cbtnlear.Text = "Clear";
            this.cbtnlear.UseVisualStyleBackColor = true;
            this.cbtnlear.Click += new System.EventHandler(this.cbtnlear_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(6, 206);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 18;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // dgsinglefieldmaster
            // 
            this.dgsinglefieldmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsinglefieldmaster.Location = new System.Drawing.Point(278, 12);
            this.dgsinglefieldmaster.Name = "dgsinglefieldmaster";
            this.dgsinglefieldmaster.Size = new System.Drawing.Size(548, 384);
            this.dgsinglefieldmaster.TabIndex = 44;
            this.dgsinglefieldmaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsinglefieldmaster_CellClick);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 45;
            // 
            // txtDescripton
            // 
            this.txtDescripton.Location = new System.Drawing.Point(101, 107);
            this.txtDescripton.Name = "txtDescripton";
            this.txtDescripton.Size = new System.Drawing.Size(100, 20);
            this.txtDescripton.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Descritpion";
            // 
            // frmSingleFieldMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripton);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgsinglefieldmaster);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.cbtnlear);
            this.Controls.Add(this.savebtn);
            this.Name = "frmSingleFieldMaster";
            this.Text = "frmSingleFieldMaster";
            this.Load += new System.EventHandler(this.frmSingleFieldMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgsinglefieldmaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button cbtnlear;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView dgsinglefieldmaster;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripton;
        private System.Windows.Forms.TextBox txtName;
    }
}