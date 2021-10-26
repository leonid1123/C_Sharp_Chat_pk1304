using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//test comment
namespace pk1304new
{
    public partial class Form1 : Form
    {
        String login = "";
        String pass = "";
        String loginOK = "MegaNagibator3000";
        String passOK = "qwerty";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //это игнорим
        }

        private void button1_Click(object sender, EventArgs e)
        {//для входа
            login = textBox1.Text;
            pass = textBox2.Text;

            //label4.Text = "login:" + login + " pass:" + pass;
            if (login==loginOK && pass==passOK)
            {
                label4.Text = "всё нормально";
            } else
            {
                label4.Text = "всё НЕ нормально";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//для регистрации переход в другую форму
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
