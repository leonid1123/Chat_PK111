using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Chat
{
    public partial class Form2 : Form
    {
        MySqlConnection myConnection;
        MySqlCommand myCommand;
        bool loginOk = false;
        bool passOk = false;
        bool eMailOk = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /*if (Equals(textBox4.Text, "Повторите пароль") )
            {
                textBox4.PasswordChar = '\0';
            } else
            {
                textBox4.PasswordChar = '*';
            }
            if (textBox4.Text.Length==0)
            {
                textBox4.Text = "Повторите пароль";
            }*/


            if (Equals(textBox3.Text, textBox4.Text)) 
            {
                label3.Text = "Пароли совпадают";
                label3.ForeColor = Color.Green;
                passOk = true;
            } else
            {
                label3.Text = "Пароли НЕ совпадают!";
                label3.ForeColor = Color.Red;
                passOk = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string login = textBox2.Text;
            string password1 = textBox3.Text;
            string password2 = textBox4.Text;
            string eMail = textBox5.Text;
            string description = textBox6.Text;
            string myInsertQuery = "INSERT INTO users (name, login, password, regTime, eMail, description) Values(@name,@login,@password,null,@eMail,@description)";
            myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@login", login);
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, password1);
                myCommand.Parameters.AddWithValue("@password", hash);
            }
            myCommand.Parameters.AddWithValue("@eMail", eMail);
            myCommand.Parameters.AddWithValue("@description", description);

            myCommand.ExecuteNonQuery();

            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Database=messenger111;Data Source=localhost;User Id=msguser;Password=1234567890";
            myConnection = new MySqlConnection(myConnectionString);
            myConnection.Open();
        }
        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //Debug.WriteLine("1-" + sBuilder);
            //Debug.WriteLine("2-" + sBuilder.ToString()); 
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string mySelectQuery = "SELECT login FROM users WHERE login=@tmpLogin";
            MySqlCommand command = myConnection.CreateCommand();
            command.Parameters.AddWithValue("@tmpLogin", textBox2.Text);
            command.CommandText = mySelectQuery;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                label2.Text = "Занято!";
                label2.ForeColor = Color.Red;
                loginOk = false;
            } else
            {
                label2.Text = "Свободно";
                label2.ForeColor = Color.Green;
                loginOk = true;
            }
            reader.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.PasswordChar = '*';

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text.Length==0)
            {
                textBox4.Text = "Повторите пароль";
            }
        }
    }
}
