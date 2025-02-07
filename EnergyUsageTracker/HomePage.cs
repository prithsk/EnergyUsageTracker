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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadAbout));
            t.Start();
        }

        private void ThreadAbout()
        {
            Application.Run(new About());
        }

        private void btnEnergyTracker_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnEnergyTracker));
            t.Start();
        }

        private void ThreadbtnEnergyTracker()
        {
            Application.Run(new EnergyTracker());
        }
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnRecommendations));
            t.Start();
        }

        private void ThreadbtnRecommendations()
        {
            Application.Run(new Recommendations());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnSettings));
            t.Start();
        }

        private void ThreadbtnSettings()
        {
            Application.Run(new Settings());
        }
    }
}
