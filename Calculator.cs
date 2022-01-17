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

            TextBox num1txt = new TextBox();
            TextBox num2txt = new TextBox();
            Button plus = new Button();
            Button minus = new Button();
            Button div = new Button();
            Button mult = new Button();
            num1txt.Location = new Point(100, 45);
            num1txt.Name = "num1txt";
            num1txt.Size = new Size(183, 23);
            num2txt.Location = new Point(350, 45);
            num2txt.Name = "num2txt";
            num2txt.Size = new Size(183, 23);
            plus.Location = new Point(100, 110);
            plus.Name = "plus";
            plus.Size = new Size(75, 23);
            plus.Text = "button1";
            minus.Location = new Point(240, 110);
            minus.Name = "minus";
            minus.Size = new Size(75, 23);
            minus.Text = "button1";
            div.Location = new Point(400, 110);
            div.Name = "div";
            div.Size = new Size(75, 23);
            div.Text = "button1";
            mult.Location = new Point(500, 110);
            mult.Name = "mult";
            mult.Size = new Size(75, 23);
            mult.Text = "button1";
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
