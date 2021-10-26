using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            server = "192.168.0.23";
            database = "chat";
            uid = "mainUser";
            password = "1234567890";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SSL Mode=None";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
