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

namespace ListQueueDatabase
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string username = tbAdminUsername.Text;
            string password = tbAdminPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `useradmin` WHERE `username` = @usn and `password` = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                AdminMenu adminmenu = new AdminMenu();
                adminmenu.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if(password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void labelGoToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegister registerform = new AdminRegister();
            registerform.Show();
        }

        private void labelGoToRegister_Enter(object sender, EventArgs e)
        {
            labelGoToRegister.ForeColor = Color.Black;
        }

        private void labelGoToRegister_Leave(object sender, EventArgs e)
        {
            labelGoToRegister.ForeColor = Color.Gray;
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Show();
            this.Hide();
        }
    }
}
