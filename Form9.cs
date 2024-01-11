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
    public partial class Form9 : Form
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
        public Form9()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            Hide();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            int flag_s_6frm = form6.flag_aktiv;
            if(flag_s_6frm == 0)
            {
                Form1 form1 = new Form1();
                MessageBox.Show("Вы не зашли в личный кабинет!\n" +
                    "Зайти в личный кабинет?", "Ошибка", MessageBoxButtons.YesNo);
                form1.Show();
                Hide() ;
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                Hide();
            }
            //Сделать проверку, клиент зашел в кабинет, если нет то предложить
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
