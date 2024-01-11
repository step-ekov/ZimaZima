using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace test_2 //380; 398
{
    public partial class Form1 : Form
    {
        public DataGrid grid_lg;

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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Regestrat". При необходимости она может быть перемещена или удалена.
            this.regestratTableAdapter.Fill(this.dataSet1.Regestrat);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void designer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11_Dly_Reg frm11 = new Form11_Dly_Reg();
            frm11.Show();
            frm11.regestratBindingSource.AddNew();
            Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //ПРОВЕРКА
            int index_lg = 0, flag_lg = 0;
            int index_ps = 0, flag_ps = 0;

            //Проверка логина
            try
            {
                int dl_lg = dataGridView1.Rows.Count;
                int dl_1_lg = dataGridView1.ColumnCount;
                string[] mass = new string[dl_lg - 1];

                String s_lg = "";

                for (int i_lg = 0; i_lg < dl_lg - 1; i_lg++)  //Копирование датагрида в текстбокс
                {
                    for (int j_lg = 0; j_lg < dl_1_lg - 1; j_lg++) // если сделать -1 то будет только логин
                    {
                        s_lg = dataGridView1.Rows[i_lg].Cells[j_lg].Value.ToString();
                    }
                    mass[i_lg] += s_lg.Replace(" ", "");
                    label5.Text += (s_lg + "\r");
                }

                foreach (string c in mass)
                {
                    if (textBox1.Text == c)
                    {
                        flag_lg = 1;
                        index_lg = index_lg;
                        break;
                    }
                    else
                    {
                        flag_lg = 0;
                    }
                    label6.Text += (c + "\r");
                    index_lg++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err");
            }

            //Проверка пароля
            try
            {
                int dl_ps = dataGridView2.Rows.Count;
                int dl_1_ps = dataGridView2.ColumnCount;
                string[] mass_ps = new string[dl_ps - 1];

                String s_ps = "";

                for (int i_ps = 0; i_ps < dl_ps - 1; i_ps++)  //Копирование датагрида в текстбокс
                {
                    for (int j_ps = 0; j_ps < dl_1_ps; j_ps++) // если сделать -1 то будет только логин
                    {
                        s_ps = dataGridView2.Rows[i_ps].Cells[j_ps].Value.ToString();
                    }
                    mass_ps[i_ps] += s_ps.Replace(" ", "");
                    label8.Text += (s_ps + "\r");
                }

                foreach (string c_ps in mass_ps)
                {
                    if (textBox2.Text == c_ps)
                    {
                        flag_ps = 1;
                        index_ps = index_ps;
                        break;
                    }
                    else
                    {
                        flag_ps = 0;
                    }
                    label7.Text += (c_ps + "\r");
                    index_ps++;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Err");
            }

            //Запись имени
            //int dl_name = dataGridView3.Rows.Count;
            //int dl_1_name = dataGridView3.ColumnCount;
            //string[] mass_name = new string[dl_name - 1];

            //String s_name = "";

            //for (int i_name = 0; i_name < dl_name - 1; i_name++)  //Копирование датагрида в текстбокс
            //{
            //    for (int j_name = 0; j_name < dl_1_name; j_name++) // если сделать -1 то будет только логин
            //    {
            //        s_name = dataGridView3.Rows[i_name].Cells[j_name].Value.ToString();
            //    }
            //    mass_name[i_name] += s_name.Replace(" ", "");
            //    label9.Text += (s_name + "\r");
            //}
            //try
            //{
            //    int dl_name = dataGridView3.Rows.Count;
            //    int dl_1_name = dataGridView3.ColumnCount;
            //    string[] mass_name = new string[dl_name - 1];

            //    String s_name = "";

            //    for (int i_name = 0; i_name < dl_name - 1; i_name++)  //Копирование датагрида в текстбокс
            //    {
            //        for (int j_name = 0; j_name < dl_1_name; j_name++) // если сделать -1 то будет только логин
            //        {
            //            s_name = dataGridView3.Rows[i_name].Cells[j_name].Value.ToString();
            //        }
            //        mass_name[i_name] += s_name.Replace(" ", "");
            //        label9.Text += (s_name + "\r");
            //    }

            //    foreach (string v in mass_name)
            //    {
            //        if (textBox1.Text == v)
            //        {
            //            flag_lg = 1;
            //            index_lg = index_lg;
            //            break;
            //        }
            //        else
            //        {
            //            flag_lg = 0;
            //        }
            //        label6.Text += (v + "\r");
            //        index_lg++;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Err");
            //}

            //Конец проверки
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                if (((flag_lg != 0) && (flag_ps != 0)) && (index_lg == index_ps))
                {
                    Form6 form6 = new Form6();
                    MessageBox.Show("Добро пожаловать!", "Успешный вход");
                    form6.Show();
                    Hide();

                    form6.flag_aktiv = 1;
                }
                else
                {
                    MessageBox.Show("Неверные введенные данные!", "Ошибка");
                    textBox1.Clear(); textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Введите данные!", "Ошибка");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = ""; label6.Text = ""; label7.Text = ""; label8.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}