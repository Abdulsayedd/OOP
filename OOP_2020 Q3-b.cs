//==============================================================
//█▀▀ █▀█ █▀█ █▀▄▀█ ▄█ ░ █▀▄ █▀▀ █▀ █ █▀▀ █▄░█ █▀▀ █▀█ ░ █▀▀ █▀
//█▀░ █▄█ █▀▄ █░▀░█ ░█ ▄ █▄▀ ██▄ ▄█ █ █▄█ █░▀█ ██▄ █▀▄ ▄ █▄▄ ▄█
//==============================================================
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.txtbx2 = new System.Windows.Forms.TextBox();
            this.txtbx3 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(53, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 44);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Number 1";
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(312, 52);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(153, 44);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Number 2";
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(576, 52);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(153, 44);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Result";
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(194, 63);
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(100, 23);
            this.txtbx1.TabIndex = 1;
            // 
            // txtbx2
            // 
            this.txtbx2.Location = new System.Drawing.Point(455, 63);
            this.txtbx2.Name = "txtbx2";
            this.txtbx2.Size = new System.Drawing.Size(100, 23);
            this.txtbx2.TabIndex = 1;
            // 
            // txtbx3
            // 
            this.txtbx3.Location = new System.Drawing.Point(675, 63);
            this.txtbx3.Name = "txtbx3";
            this.txtbx3.Size = new System.Drawing.Size(100, 23);
            this.txtbx3.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(88, 128);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(149, 47);
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(262, 128);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(149, 47);
            this.btnsub.Text = "Substract";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(455, 128);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(149, 47);
            this.btnmult.Text = "Multiple";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(626, 128);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(149, 47);
            this.btndiv.Text = "Divide";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 214);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtbx3);
            this.Controls.Add(this.txtbx2);
            this.Controls.Add(this.txtbx1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Menu Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txtbx1;
        private TextBox txtbx2;
        private TextBox txtbx3;
        private Button btnadd;
        private Button btnsub;
        private Button btnmult;
        private Button btndiv;
    }
}
//=====================================================
//█▀▀ █▀█ █▀█ █▀▄▀█ ▄█ ░ █▀▀ █▀
//█▀░ █▄█ █▀▄ █░▀░█ ░█ ▄ █▄▄ ▄█
//=====================================================
 public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(txtbx1.Text)+int.Parse(txtbx2.Text);
            txtbx3.Text = sum.ToString();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(txtbx1.Text) - int.Parse(txtbx2.Text);
            txtbx3.Text = sub.ToString();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            int mult = int.Parse(txtbx1.Text) * int.Parse(txtbx2.Text);
            txtbx3.Text = mult.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double div = double.Parse(txtbx1.Text) / double.Parse(txtbx2.Text);
            txtbx3.Text=div.ToString();
        }
    }
