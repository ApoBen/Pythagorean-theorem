using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trigonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Math.Sqrt(a * a + b * b);
                label1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = null;
                textBox2.Text = null;
                label1.Text = null;
                MessageBox.Show("The value entered is not a number","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "W")
            {
                button2.Text = "B";
                label1.ForeColor = Color.Black;
                this.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                pictureBox1.Image = Image.FromFile(@"C:\Users\abdul\Desktop\vs22\trigonometry\trigonometry\triangle.jpg");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\abdul\Desktop\vs22\trigonometry\trigonometry\triangleb.jpg");
                label1.ForeColor = Color.White;
                button2.Text = "W";
                this.BackColor = Color.Black;
                textBox1.BackColor = Color.Black;
                textBox2.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
            }
        }
    }
}
