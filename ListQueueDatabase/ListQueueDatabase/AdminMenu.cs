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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        

        private void btn_QueueCall_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=QueueBase;Uid=root; Pwd=;";
            try
            {
                MySqlConnection conn = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd;
                conn.Open();
                try
                {
                    String AdminName = AdminNameTxt.Text;

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM `Tr_Guest` as TG WHERE TG.`Admin` IS NULL";
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    var rows = dt.AsEnumerable().ToArray();

                    LabelAntrian.Text = "Antrian No: " + rows[0]["id"].ToString();
                    LabelGuestName.Text = rows[0]["GuestName"].ToString();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE `Tr_Guest` as TG SET TG.`Admin` = @ADMINNAME WHERE TG.`id` = @ID";
                    cmd.Parameters.AddWithValue("@ADMINNAME", AdminName);
                    cmd.Parameters.AddWithValue("@ID", rows[0]["id"]);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=QueueBase;Uid=root; Pwd=;";
            if (MessageBox.Show("Benar akan me-reset data?\n(Data akan dimulai ulang dari guest pertama)", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd;
                    conn.Open();
                    try
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE Tr_Guest SET Admin = NULL WHERE Admin = ADMIN";
                        cmd.ExecuteNonQuery();
                        LabelAntrian.Text = "Antrian No: ";
                        LabelGuestName.Text = "";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Database=QueueBase;Uid=root; Pwd=;";
            if (MessageBox.Show("Benar akan menghapus data?\n(Semua data pada database Guest akan menghilang)", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmd;
                    conn.Open();
                    try
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "TRUNCATE TABLE Tr_Guest";
                        cmd.ExecuteNonQuery();
                        LabelAntrian.Text = "Antrian No: ";
                        LabelGuestName.Text = "";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            
        }
    }
}
