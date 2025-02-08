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
    public partial class Recommendations : Form
    {
        public Recommendations()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSetGoals_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnSetGoals));
            t.Start();
        }

        private void ThreadbtnSetGoals()
        {
            Application.Run(new SetGoals());
        }

        private void btnPlanFutureEnergyUsage_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadPlanFutureEnergyUsage));
            t.Start();
        }
        private void ThreadPlanFutureEnergyUsage()
        {
            Application.Run(new PlanFutureEnergyUsage());

        }

    }
}
