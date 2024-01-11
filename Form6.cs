using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form6 : Form
    {
        public int flag_aktiv = 1;
        public string sum_shtraf;
        public int balans;

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
        public Form6()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Close();
            form9.Show();
            Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Visible = true;
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.money_shtraf = this.label7.Text;
            form10.money = this.label2.Text;
            form10.textBox3.Text = "Балланс: " + this.label2.Text;
            form10.roundButton4_1.Text = "Оплатить\n" + this.label7.Text;

            form10.ShowDialog();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sum_shtraf = label2.Text;
            balans = int.Parse(label2.Text);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.textBox3.Text = this.label2.Text;
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.textBox1.Text = this.label2.Text;
            form11.money = this.label2.Text;
            form11.ShowDialog();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }
    }
}
