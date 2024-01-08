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
    public partial class Form2 : Form
    {
        string name_reg; string pochta_reg; string login_reg; string pass_reg;

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
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void designer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Код для добавления в бд
            Form11_Dly_Reg form11_reg = new Form11_Dly_Reg();
            //form11_reg.button1.PerformClick();

            //Заполнение полей
            form11_reg.loginTextBox.Text = this.textBox3.Text;
            form11_reg.passwordTextBox.Text = this.textBox4.Text;
            form11_reg.nameTextBox.Text = this.textBox1.Text;

            //Код для обновления в бд
            form11_reg.button2.PerformClick();
            form11_reg.Show();
            Hide();

            Form1 form1 = new Form1();
            form1.Show();
            Close();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name_reg = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pochta_reg = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            login_reg = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            pass_reg = textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Close();
            form9.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
