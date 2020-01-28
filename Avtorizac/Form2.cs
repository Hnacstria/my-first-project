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
    public partial class Form2 : Form
    {
        string command = "";

        public Form2()
        {
            InitializeComponent();
            LB(0);
        }

        void LB(int n)
        {
            if (n == 0)
            {
                command = "SELECT `Login`, `Date`, `Text` FROM `Forum` inner join `Users` on Users.ID=Forum.IDUser WHERE `Theme`='1' LIMIT 0 , 50 ";
            }
            else
            {
                command = "SELECT `Login`, `Date`, `Text` FROM `Forum` inner join `Users` on Users.ID=Forum.IDUser WHERE `Theme`='1' LIMIT 0 , "+n+" ";
            }

            string serv = "server=localhost;user=root;password=;database=Math;";
            MySqlConnection conn = new MySqlConnection(serv);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(command, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listBoxForum.Items.Add(reader[0].ToString() + "          " + reader[1].ToString());
                listBoxForum.Items.Add(reader[2].ToString());
                listBoxForum.Items.Add("");
            }
            conn.Close();
        }
        аааааа
        private void buttonOtpravka_Click(object sender, EventArgs e)
        {
            string serv = "server=localhost;user=root;password=;database=IdFio;";
            MySqlConnection conn = new MySqlConnection(serv);
            conn.Open();

            string command = "INSERT INTO `Math`.`Forum` (`ID`, `IDUser`, `Text`, `Date`, `Theme`) VALUES (NULL, '" + Properties.Settings.Default.IdUser + "', '" + tB.Text + "', CURRENT_TIMESTAMP, '1')";

            MySqlCommand cmd = new MySqlCommand(command, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

            listBoxForum.Items.Clear();
            LB(0);
        }
    }
}
