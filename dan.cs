using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
    public class dan
    {
        public static void Dannie()
        {
            Form2 form2 = new Form2();
            string login_reg_and_pochta = form2.textBox3.Text + " " + form2.textBox2.Text;
            string pass_reg = form2.textBox4.Text;

            var dannie = new Dictionary<string, string>();
            dannie.Add(login_reg_and_pochta, pass_reg);

        }
    }
}