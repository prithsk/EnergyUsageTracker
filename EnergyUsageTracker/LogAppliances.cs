using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace EnergyUsageTracker
{
    public partial class LogAppliances : Form
    {
        private List<string> applianceHistory = new List<string>();

        public LogAppliances()
        {
            InitializeComponent();
            CenterToScreen();
            LoadHistory();
        }

        private void LoadHistory()
        {

            applianceHistory.Add("Fridge - 200W - 5 hrs");
            applianceHistory.Add("Microwave - 1000W - 10 mins");
            UpdateHistoryDisplay();
        }

        private void UpdateHistoryDisplay()
        {
            listBoxHistory.DataSource = null;
            listBoxHistory.DataSource = applianceHistory;
        }

        private void btnAddAppliance_Click(object sender, EventArgs e)
        {

            string applianceName = txtAppName.Text;
            string usageDuration = txtUseDur.Text;
            string wattage = txtEnergyUse.Text;

            if (string.IsNullOrWhiteSpace(applianceName) || string.IsNullOrWhiteSpace(usageDuration) || string.IsNullOrWhiteSpace(wattage))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            string newEntry = $"{applianceName} - {wattage}W - {usageDuration} hrs";


            applianceHistory.Add(newEntry);
            UpdateHistoryDisplay();

            //Need to Put a generate to make sure I can actually see the recommendations
        }


        private void btnback8_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback8));
            t.Start();
        }
        private void Threadbtnback8()
        {
            Application.Run(new HomePage());
        }


        private void btnback9_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback9));
            t.Start();
        }
        private void Threadbtnback9()
        {
            Application.Run(new EnergyTracker());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 }

