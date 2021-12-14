using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace pk1304new
{
    public partial class Form2 : Form
    {
        String newLogin = "";
        String newPass = "";
        bool userExist = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Trim() == textBox3.Text.Trim() && !userExist && textBox2.Text != "")
            {
                string newUserQuery = "INSERT INTO users (userid,userlogin,userpass) VALUES (null,@param1,@param2)";
                MySqlCommand cmdIns = new MySqlCommand(newUserQuery, Form1.connection);
                cmdIns.Parameters.AddWithValue("param1", textBox1.Text);
                cmdIns.Parameters.AddWithValue("param2", textBox2.Text);
                Form1.connection.Open();
                int err = cmdIns.ExecuteNonQuery();
                Console.WriteLine(err);
                Form1.connection.Close();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            newLogin = textBox1.Text.Trim();
            string query = "SELECT userlogin FROM users WHERE userlogin = @param1";
            MySqlCommand cmd = new MySqlCommand(query, Form1.connection);
            cmd.Parameters.AddWithValue("param1", newLogin);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            userExist = dataReader.HasRows;
            dataReader.Close();
            Form1.connection.Close();
            if (userExist)
            {
                label4.Text = "имя пользователя занято";
            }
            else
            {
                label4.Text = "имя пользователя свободно";
            }
        }
    }
}
