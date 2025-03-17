using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace EnergyUsageTracker
{
    public partial class LogAppliances : Form
    {
        private List<string> applianceHistory = new List<string>();
        private int currentPage = 0;
        private const int ItemsPerPage = 10;
        private Label lblpanum = new Label();
        private const string CsvFilePath = "Book2.csv";

        public LogAppliances()
        {
            InitializeComponent();
            CenterToScreen();
            InitializePageLabel();
            LoadsHistory();
            PopulateComboBox();
            LoadHistory();
            
        }

        private void InitializePageLabel()
        {
            lblpanum.AutoSize = true;
            lblpanum.Location = new System.Drawing.Point(370, 400);
            Controls.Add(lblpanum);
            UpdatePageLabel();
        }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Settings.mdf;Integrated Security=True";

        private void LoadHistory()
        {
            applianceHistory.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, PowerConsumption, UsageHoursPerDay FROM Appliance";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        double power = Convert.ToDouble(reader["PowerConsumption"]);
                        double hours = Convert.ToDouble(reader["UsageHoursPerDay"]);

                        applianceHistory.Add($"{name} - {power}W - {hours} hrs");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appliances: " + ex.Message);
                }
            }

            UpdateHistoryDisplay();
        }
        private void LoadsHistory()
        {
            if (File.Exists(CsvFilePath))
            {
                applianceHistory = File.ReadAllLines(CsvFilePath).ToList();
            }
            else
            {
                applianceHistory = new List<string>
                {
                    "Fridge - 200W - 5 hrs",
                    "Microwave - 1000W - 10 mins",
                    "Dishwasher - 900W - 1.5 hrs",
                    "Air Conditioner - 2000W - 3 hrs",
                    "Heater - 1500W - 2 hrs",
                    "Oven - 1800W - 45 mins",
                    "Fan - 75W - 6 hrs",
                    "Washing Machine - 500W - 1 hr",
                    "Dryer - 1300W - 45 mins",
                    "Vacuum - 1200W - 30 mins"
                };
                SaveHistory(); // Save default entries
            }
            UpdateHistoryDisplay();
        }

        private void SaveHistory()
        {
            File.WriteAllLines(CsvFilePath, applianceHistory);
        }

        private void UpdateHistoryDisplay()
        {
            var paginatedHistory = applianceHistory
                .Skip(currentPage * ItemsPerPage)
                .Take(ItemsPerPage)
                .ToList();

            listBoxHistory.DataSource = null;
            listBoxHistory.DataSource = paginatedHistory;
            UpdateNavigationButtons();
            UpdatePageLabel();
        }

        private void UpdateNavigationButtons()
        {
            btnPrev.Enabled = currentPage > 0;
            btnNext.Enabled = (currentPage + 1) * ItemsPerPage < applianceHistory.Count;
        }

        private void UpdatePageLabel()
        {
            int totalPages = (int)Math.Ceiling((double)applianceHistory.Count / ItemsPerPage);
            lblpanum.Text = $"Page {currentPage + 1} of {totalPages}";
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateHistoryDisplay();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if ((currentPage + 1) * ItemsPerPage < applianceHistory.Count)
            {
                currentPage++;
                UpdateHistoryDisplay();
            }
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

        private void PopulateComboBox()
        {
            comboBox1.Items.Add("Sort A → Z");
            comboBox1.Items.Add("Sort Z → A");
            comboBox1.Items.Add("Sort by Wattage (Low → High)");
            comboBox1.Items.Add("Sort by Wattage (High → Low)");
            comboBox1.Items.Add("Sort by Time (Short → Long)");
            comboBox1.Items.Add("Sort by Time (Long → Short)");

            comboBox1.SelectedIndex = 0;
        }

        private void BubbleSortAppliances(bool ascending)
        {
            int n = applianceHistory.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    bool swapCondition = ascending
                        ? string.Compare(applianceHistory[j], applianceHistory[j + 1], StringComparison.OrdinalIgnoreCase) > 0
                        : string.Compare(applianceHistory[j], applianceHistory[j + 1], StringComparison.OrdinalIgnoreCase) < 0;

                    if (swapCondition)
                    {
                        string temp = applianceHistory[j];
                        applianceHistory[j] = applianceHistory[j + 1];
                        applianceHistory[j + 1] = temp;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "Sort A → Z")
            {
                BubbleSortAppliances(true);
            }
            else if (selectedOption == "Sort Z → A")
            {
                BubbleSortAppliances(false);
            }
            else if (selectedOption == "Sort by Wattage (Low → High)")
            {
                applianceHistory = applianceHistory.OrderBy(GetWattage).ToList();
            }
            else if (selectedOption == "Sort by Wattage (High → Low)")
            {
                applianceHistory = applianceHistory.OrderByDescending(GetWattage).ToList();
            }
            else if (selectedOption == "Sort by Time (Short → Long)")
            {
                applianceHistory = applianceHistory.OrderBy(GetUsageTime).ToList();
            }
            else if (selectedOption == "Sort by Time (Long → Short)")
            {
                applianceHistory = applianceHistory.OrderByDescending(GetUsageTime).ToList();
            }

            currentPage = 0;
            UpdateHistoryDisplay();
        }

        private int GetWattage(string entry)
        {
            Match match = Regex.Match(entry, @"(\d+)W");
            return match.Success ? int.Parse(match.Groups[1].Value) : 0;
        }

        private double GetUsageTime(string entry)
        {
            Match match = Regex.Match(entry, @"(\d+)\s*(hrs|min)");
            if (!match.Success) return 0;

            double value = double.Parse(match.Groups[1].Value);
            return match.Groups[2].Value == "min" ? value / 60.0 : value;
        }

        List<Appliance> applianceList = new List<Appliance>();

        public void AddNewAppliance(int userId, string name, float wattage, float usageDuration)
        {
            int newApplianceID = applianceList.Count + 1;
            Appliance newAppliance = new Appliance(newApplianceID, userId, name, wattage, usageDuration);
            applianceList.Add(newAppliance);
            newAppliance.AddAppliance();
        }

        public void ModifyAppliance(int applianceID, float newWattage, float newUsageDuration)
        {
            Appliance appliance = applianceList.FirstOrDefault(a => a.ApplianceID == applianceID);
            if (appliance != null)
            {
                appliance.ModifyAppliance(newWattage, newUsageDuration);
            }
        }
        

        //check the code to see if there are any changes to this
        private void btnAddAppliance_Click_1(object sender, EventArgs e)
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
            SaveHistory();
            currentPage = (applianceHistory.Count - 1) / ItemsPerPage;
            UpdateHistoryDisplay();
        }
    }
}