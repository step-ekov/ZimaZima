using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form10 : Form
    {
        public string money; public string money_shtraf; public string rezu; public string rezu_1;

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
        public Form10()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form10_Load(object sender, EventArgs e)
        {
        }

    private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Close();
            form6.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void designer1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void roundButton4_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            razbor(); razbor1();
            int rezul;

            if ((textBox1.Text != "") & (textBox2.Text != ""))
            {
                form6.label7.Text = this.textBox4.Text;
                rezul = int.Parse(rezu) - int.Parse(rezu_1);
                form6.label2.Text = rezul.ToString();
                Close();
                MessageBox.Show("Успешная оплата", "Уведомление");
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

        public string razbor1()
        {
            char[] a = money_shtraf.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 'р')
                    rezu_1 += a[i];
                else
                    break;
            }
            return rezu_1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
