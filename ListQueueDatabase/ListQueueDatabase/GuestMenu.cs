using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ListQueueDatabase
{
    public partial class GuestMenu : Form
    {
        public GuestMenu()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Show();
            this.Hide();
        }

        private void btn_Queue_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=QueueBase;Uid=root; Pwd=;";
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd;
                conn.Open();
                try
                {
                    String GuestName = GuestNameTxt.Text;

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Tr_Guest(GuestName) VALUES(@NAME); "+"SELECT last_insert_id();";
                    cmd.Parameters.AddWithValue("@NAME", GuestName);
                    int Id = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show("Anda mendapat antrian nomor : "+ Id);
                    GuestNameTxt.Text = "";
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        Console.WriteLine("Input Guest Success.");
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void GuestMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
