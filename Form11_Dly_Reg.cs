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
    public partial class Form11_Dly_Reg : Form
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
        public Form11_Dly_Reg()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void regestratBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regestratBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void Form11_Dly_Reg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Regestrat". При необходимости она может быть перемещена или удалена.
            this.regestratTableAdapter.Fill(this.dataSet1.Regestrat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();

            regestratBindingSource.EndEdit();
            regestratTableAdapter.Update(dataSet1);

            Close();
            frm1.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            Close();
            form9.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            regestratDataGridView.Visible = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regestratDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dl = regestratDataGridView.Rows.Count;
            int dl_1 = regestratDataGridView.ColumnCount;

            String s = "";
            for (int i = 0; i < dl - 1; i++)  //Копирование датагрида в текстбокс
            {
                for (int j = 0; j < dl_1; j++) // если сделать -1 то будет только логин
                {
                    s = regestratDataGridView.Rows[i].Cells[j].Value.ToString();
                    //label5.Text += (s + " "); //если убрать это то будет только пасворд
                }
                label5.Text += (s + "\r");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "";
        }
    }
}
