using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
//test comment
namespace pk1304new
{
    public partial class Form1 : Form
    {
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
            string query = "SELECT userlogin, userpass FROM users WHERE userlogin = @param1 AND userpass = @param2 ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("param1", login);
            cmd.Parameters.AddWithValue("param2", pass);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            bool userExist = dataReader.HasRows;
            if (userExist)
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "Ошибка в имени пользователя или пароле. Возможно Вам нужно зарегистрироваться";
            }
            dataReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//для регистрации переход в другую форму
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

    }
}
