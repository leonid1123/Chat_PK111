using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        MySqlConnection myConnection;
        MySqlCommand myCommand;
        DateTime lastDateTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //отправка сообщения
            string myInsertQuery = "INSERT INTO messages (id, author, timeStamp,msg) Values(null, 'Leo', null, @myMessage)";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myCommand.Parameters.AddWithValue("@myMessage", textBox1.Text);
            myCommand.ExecuteNonQuery();
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Database=messenger111;Data Source=localhost;User Id=msguser;Password=1234567890";
            myConnection = new MySqlConnection(myConnectionString);
            string mySelectQuery = "SELECT author,timeStamp,msg FROM messages";
            myConnection.Open();
            MySqlCommand command = myConnection.CreateCommand();
            command.CommandText = mySelectQuery;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listBox1.Items.Add(reader.GetString(1) + " " + reader.GetString(0) + " " + reader.GetString(2));
                lastDateTime = reader.GetDateTime(1);
            }
            label1.Text = lastDateTime.ToString();
            reader.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //получение сообщения
            string mySelectQuery = "SELECT author,timeStamp,msg FROM messages WHERE timeStamp > @dt";
            MySqlCommand command = myConnection.CreateCommand();
            command.Parameters.AddWithValue("@dt", lastDateTime);
            command.CommandText = mySelectQuery;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add("" + reader.GetString(1) + " " + reader.GetString(0) + " " + reader.GetString(2));

                lastDateTime = reader.GetDateTime(1);
            }
            reader.Close();
            label1.Text = lastDateTime.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //myCommand.Connection.Close();
        }
    }
}
