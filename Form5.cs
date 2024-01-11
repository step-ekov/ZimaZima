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
    public partial class Form5 : Form
    {
        public string flag_iz_4frm;
        string data, time, FIO, login = "";

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
        public Form5()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void designer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }
        public void label6VS(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;// Display the date as "Mon 27 Feb 2012".  
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            data = dateTimePicker1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            time = comboBox1.Text;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            if (form6.label19.Text == "")
            {
                form6.label19.Visible = true;
                //Проверка на заполненые поля
                if ((FIO != "") & (login != "") & (data != "") & (time != ""))
                {
                    if (flag_iz_4frm == "1")
                    {
                        //Form6 form6 = new Form6();
                        form6.label19.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                    else
                    {
                        //Form6 form6 = new Form6();
                        form6.label19.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк + СПА" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                }
                else
                    MessageBox.Show("Главные поля не заполнены!!!");
            }
            else if (form6.label20.Text == "")
            {
                form6.label20.Visible = true;
                //Проверка на заполненые поля
                if ((FIO != "") & (login != "") & (data != "") & (time != ""))
                {
                    if (flag_iz_4frm == "1")
                    {
                        //Form6 form6 = new Form6();
                        form6.label20.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                    else
                    {
                        //Form6 form6 = new Form6();
                        form6.label20.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк + СПА" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                }
                else
                    MessageBox.Show("Главные поля не заполнены!!!");
            }
            else
            {
                form6.label16.Visible = true;
                form6.label16.Text = "";
                //Проверка на заполненые поля
                if ((FIO != "") & (login != "") & (data != "") & (time != ""))
                {
                    if (flag_iz_4frm == "1")
                    {
                        //Form6 form6 = new Form6();
                        form6.label16.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                    else
                    {
                        //Form6 form6 = new Form6();
                        form6.label16.Text = this.dateTimePicker1.Text + " ; "
                            + "Вид абонемента - Аквапарк + СПА" + " ; " + this.comboBox1.Text;
                        form6.Show();
                        Hide();
                    }
                }
                else
                    MessageBox.Show("Главные поля не заполнены!!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FIO = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            login = textBox2.Text;
        }
    }
}
