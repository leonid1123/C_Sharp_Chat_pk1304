using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pk1304new
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//send message button

        }

        private void Form3_Load(object sender, EventArgs e)
        {//on load event
            String online = "";
            if (Form1.connection.State != System.Data.ConnectionState.Open)
            {
                Form1.connection.Open();
            }
            //get all users
            string query = "SELECT username,isonline FROM users";
            MySqlCommand cmd = new MySqlCommand(query, Form1.connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetBoolean(1)==true)
                {
                    online = "в сети";
                } else
                {
                    online = "не в сети";
                }
                listBox1.Items.Add(dataReader.GetString(0)+" "+online);
            }
            dataReader.Close();
            Form1.connection.Close();
        }
    }
}
