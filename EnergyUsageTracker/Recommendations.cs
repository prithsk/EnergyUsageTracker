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

        private void btnPlanFutureEnergyUsage_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnPlanFutureEnergyUsage));
            t.Start();
        }

        private void ThreadbtnPlanFutureEnergyUsage()
        {
            Application.Run(new PlanFutureEnergyUsage());
        }

        private void btnSetGoals_Click_1(object sender, EventArgs e)
        {
          
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnSetGoals));
            t.Start();
        }

        private void ThreadbtnSetGoals()
        {
            Application.Run(new SetGoals());

        }
    
    }
}
