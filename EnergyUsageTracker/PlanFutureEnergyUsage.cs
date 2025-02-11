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

namespace EnergyUsageTracker
{
    public partial class PlanFutureEnergyUsage : Form
    {
        public PlanFutureEnergyUsage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback16_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback16));
            t.Start();
        }
        private void Threadbtnback16()
        {
            Application.Run(new HomePage());
        }

        private void btnback17_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback17));
            t.Start();
        }
        private void Threadbtnback17()
        {
            Application.Run(new Recommendations());
        }
        private string GenerateEnergySavingRoutine(string strength, string weakness, string goal)
        {
            List<string> routines = new List<string>
            {
                $"Focus on strength training to enhance your {strength}. Incorporate practices like continue using that certain appliance as much.",
                $"To improve your {weakness}, add more alternatives of energy use or not using the appliance at all if there is a better appliance .",
                $"Since your goal is to {goal}, consider a balanced mix of strength training and using certain appliances or buying alternative appliances that are better for energy saving.",
                $"Work on your {strength} by integrating more low energy appliances instead of high energy for everything, while also addressing your {weakness} with targeted practices.",
                $"If your goal is {goal}, try a program that includes a set time to turn off certain appliances or different ways to time when to turn off all appliances, saving you more energy over time."
            };

            // Randomly select a routine
            Random rand = new Random();
            int index = rand.Next(routines.Count);
            return routines[index];
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtStrength.Text.Length > 0 && txtWeakness.Text.Length > 0 && txtGoal.Text.Length > 0)
            {
                string strength = txtStrength.Text;
                string weakness = txtWeakness.Text;
                string goal = txtGoal.Text;

                txtRecommendations.Text = GenerateEnergySavingRoutine(strength, weakness, goal);
            }
        }
    }
}
