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
    public partial class CompletedGoalLog : Form
    {
        public CompletedGoalLog()
        {
            InitializeComponent();
            CenterToScreen();   
        }

        private void btnback14_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback14));
            t.Start();
        }
        private void Threadbtnback14()
        {
            Application.Run(new HomePage());
        }

        private void btnback15_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback15));
            t.Start();
        }
        private void Threadbtnback15()
        {
            Application.Run(new Recommendations());
        }
    }
}
