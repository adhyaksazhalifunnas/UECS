using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListQueueDatabase
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            var AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            var GuestMenu = new GuestMenu();
            GuestMenu.Show();
            this.Hide();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
