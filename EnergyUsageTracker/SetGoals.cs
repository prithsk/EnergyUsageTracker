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
    public partial class SetGoals : Form
    {
        public SetGoals()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void btnAddGoals_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnAddGoals));
            t.Start();
        }

        private void ThreadbtnAddGoals()
        {
            Application.Run(new AddGoals());
        }

        private void btnCompletedGoalLog_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadCompletedGoalLog));
            t.Start();
        }
        private void ThreadCompletedGoalLog()
        {
            Application.Run(new CompletedGoalLog());


        }
    }
    }
