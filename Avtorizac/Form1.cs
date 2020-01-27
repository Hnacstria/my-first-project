using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Avtorizac
{
    public partial class Form1 : Form
    {
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            string s1 = textBoxLogin.Text;
            string s2 = textBoxPassword.Text;

            if (s1.IndexOf('\'') == -1 && s1.IndexOf('\\') == -1 && s1.IndexOf('`') == -1 && s1.IndexOf(';') == -1 && s1.IndexOf('\"') == -1 && s1.IndexOf('#') == -1 && s1.IndexOf('%') == -1)
            {
                string serv = "server=localhost;user=root;password=;database=Math;";
                MySqlConnection conn = new MySqlConnection(serv);
                conn.Open();

                string command = "SELECT `Login`, `ID`, `Password`  FROM `Users` WHERE `Login`='" + s1 + "'";
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Properties.Settings.Default.User = reader[0].ToString();
                    Properties.Settings.Default.IdUser = reader[1].ToString();
                    Properties.Settings.Default.Save();
                    password = reader[2].ToString();
                }

                if (password == textBoxPassword.Text)
                {
                    Form f1 = new Form2();
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Введите хотя бы пароль правильно");
                }
            }
            else { MessageBox.Show("БААААН"); }

        }
    }
}
