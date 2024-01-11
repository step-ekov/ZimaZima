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
    public partial class Form11 : Form
    {
        public string money; public string dly_rez = ""; public string rezu = "";

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
        public Form11()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void designer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Close();
            form6.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            razbor();

            if ((textBox3.Text != "") & (textBox2.Text != ""))
            {
                int uppMoney = int.Parse(textBox3.Text);
                int rezMoney = uppMoney + int.Parse(rezu);
                form6.label2.Text = rezMoney.ToString();
                Close();
                MessageBox.Show("Успешное пополнение!", "Уведомление");
                form6.Show();
                Hide();
            }
            else
                MessageBox.Show("Поля пустые!", "Ошибка");
        }

        public string razbor()
        {
            char[] a = money.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ' ')
                    rezu += a[i];
                else
                    break;
            }
            return rezu;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
