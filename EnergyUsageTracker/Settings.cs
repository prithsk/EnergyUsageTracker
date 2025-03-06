using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EnergyUsageTracker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            CenterToScreen();
            //LoadTotalEnergyUsage();
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback3));
            t.Start();
        }
        private void Threadbtnback3()
        {
            Application.Run(new HomePage());
        }
        /*
        private void LoadTotalEnergyUsage()
        {
           /*
            string connectionString = "Server=your_server_name;Database=Book2.csv;Integrated Security=True;";
            string query = "SELECT SUM(EnergyUsage) FROM LoggedAppliances"; // Use your actual table name

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        txtTotalEnergyStored.Text = result.ToString();
                    }
                    else
                    {
                        txtTotalEnergyStored.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading energy usage: " + ex.Message);
                }
            }
        }
   */

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Cyan;
            labelSettings.ForeColor = System.Drawing.Color.Black;
            labelNotifications.ForeColor = System.Drawing.Color.Black;
            labelTotalEnergyUsageStored.ForeColor = System.Drawing.Color.Black;
            laellHome.ForeColor = System.Drawing.Color.Black;
            button1.BackColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            button2.BackColor = System.Drawing.Color.Black;
            button2.ForeColor = System.Drawing.Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
            labelSettings.ForeColor = System.Drawing.Color.White;
            labelNotifications.ForeColor = System.Drawing.Color.White;
            labelTotalEnergyUsageStored.ForeColor = System.Drawing.Color.White;
            laellHome.ForeColor = System.Drawing.Color.White;
            button1.BackColor = System.Drawing.Color.Black;
            button1.ForeColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
        }
    }
}