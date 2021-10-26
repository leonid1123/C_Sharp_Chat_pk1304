using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pk1304new
{
    public partial class Form2 : Form
    {
        String newLogin = "";
        String newPass = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() !="")
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    newLogin = textBox1.Text;
                    newPass = textBox2.Text;
                    label1.Text = "регистрация успешна";
                } else
                {
                    label1.Text = "";
                }
            }
        }
    }
}
