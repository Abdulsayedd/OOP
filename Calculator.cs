using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.num1txt = new System.Windows.Forms.TextBox();
            this.num2txt = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.num1txt.Location = new System.Drawing.Point(100, 45);
            this.num1txt.Name = "num1txt";
            this.num1txt.Size = new System.Drawing.Size(183, 23);
            this.num2txt.Location = new System.Drawing.Point(350, 45);
            this.num2txt.Name = "num2txt";
            this.num2txt.Size = new System.Drawing.Size(183, 23);
            this.plus.Location = new System.Drawing.Point(100, 110);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.Text = "button1";
            this.minus.Location = new System.Drawing.Point(240, 110);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.Text = "button1";
            this.div.Location = new System.Drawing.Point(400, 110);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.Text = "button1";
            this.mult.Location = new System.Drawing.Point(500, 110);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.Text = "button1";
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num2txt);
            this.Controls.Add(this.num1txt);
        }
        public void solve(char r,int n1,int n2)
        {
            if (r == '*')
                MessageBox.Show((n1 * n2).ToString());
            else if (r == '-')
                MessageBox.Show((n1 - n2).ToString());
            else if (r == '+')
                MessageBox.Show((n1 + n2).ToString());
            else 
                MessageBox.Show((n1 / n2).ToString());
        }
        public void mult_click(object sender, EventArgs e)
        {
            solve('*', int.Parse(num1txt.Text), int.Parse(num2txt.Text));
        }
        public void div_click(object sender, EventArgs e)
        {
            solve('/', int.Parse(num1txt.Text), int.Parse(num2txt.Text));
        }
        public void minus_click(object sender, EventArgs e)
        {
            solve('-', int.Parse(num1txt.Text), int.Parse(num2txt.Text));
        }
        public void plus_click(object sender, EventArgs e)
        {
            solve('+', int.Parse(num1txt.Text), int.Parse(num2txt.Text));
        }
    }
}
