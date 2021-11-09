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
        //String login = "";
        //String pass = "";
        //String loginOK = "MegaNagibator3000";
        //String passOK = "qwerty";

        public static MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;

        public static String login = "";
        private String pass = "";
        public static String userName = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            server = "127.0.0.1";
            database = "pk1304";
            uid = "stud1304";
            password = "123456";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; SSL Mode=None";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Подключение успешно");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {//для регистрации переход в другую форму
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

    }
}
