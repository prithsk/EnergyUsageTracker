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
            Application.Run(new SetGoals());
        }
    }
}
