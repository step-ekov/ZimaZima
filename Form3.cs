using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form3 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void designer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1 ();
            form1.ShowDialog();
            Hide ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int count = 0;
            //for( int i = 0; i <= 4; i++)
            //{
            //    if(button1_Click())
            //    {

            //    }
            //}

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Hide();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            Hide();
        }
    }
}
