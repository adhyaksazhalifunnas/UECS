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
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelAdminRegister;
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
            string fname = tbFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                tbFirstName.Text = "";
                tbFirstName.ForeColor = Color.Black;
            }
        }

        private void tbFirstName_Leave(object sender, EventArgs e)
        {
            string fname = tbFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                tbFirstName.Text = "first name";
                tbFirstName.ForeColor = Color.Gray;
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            string lname = tbLastName.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                tbLastName.Text = "";
                tbLastName.ForeColor = Color.Black;
            }
        }

        private void tbLastName_Leave(object sender, EventArgs e)
        {
            string lname = tbLastName.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                tbLastName.Text = "last name";
                tbLastName.ForeColor = Color.Gray;
            }
        }

        private void tbEmailAddress_Enter(object sender, EventArgs e)
        {
            string email = tbEmailAddress.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                tbEmailAddress.Text = "";
                tbEmailAddress.ForeColor = Color.Black;
            }
        }

        private void tbEmailAddress_Leave(object sender, EventArgs e)
        {
            string email = tbEmailAddress.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                tbEmailAddress.Text = "email address";
                tbEmailAddress.ForeColor = Color.Gray;
            }
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                tbUsername.Text = "username";
                tbUsername.ForeColor = Color.Gray;
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                tbPassword.Text = "password";
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.ForeColor = Color.Gray;
            }
        }

        private void tbConfirmPassword_Enter(object sender, EventArgs e)
        {
            string cpassword = tbConfirmPassword.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                tbConfirmPassword.Text = "";
                tbConfirmPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            string cpassword = tbConfirmPassword.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") || cpassword.ToLower().Trim().Equals("password") || cpassword.Trim().Equals(""))
            {
                tbConfirmPassword.Text = "confirm password";
                tbConfirmPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `useradmin`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = tbFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = tbLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = tbEmailAddress.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tbUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (tbPassword.Text.Equals(tbConfirmPassword.Text))
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select a Different One");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account has been Created","Account", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password does not Match","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }  
            else
            {
                MessageBox.Show("Enter your Information please","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            

            db.closeConnection();


        }
        public Boolean checkUsername()
        {
            DB db = new DB();
            string username = tbUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `useradmin` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkTextBoxesValues()
        {
            string fname = tbFirstName.Text;
            string lname = tbLastName.Text;
            string email = tbEmailAddress.Text;
            string uname = tbUsername.Text;
            string pass = tbPassword.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email address") || uname.Equals("username") || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin loginform = new AdminLogin();
            loginform.Show();
        }

        private void labelGoToLogin_Enter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Black;
        }

        private void labelGoToLogin_Leave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Gray;
        }

        private void AdminRegister_FormClosed(object sender, FormClosedEventArgs e)
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
