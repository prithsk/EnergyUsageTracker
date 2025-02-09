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

        private void btnCompletedGoalLog_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnCompletedGoalLog));
            t.Start();
        }

        private void ThreadbtnCompletedGoalLog()
        {
            Application.Run(new CompletedGoalLog());


        }

        private void btnback10_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback10));
            t.Start();
        }
        private void Threadbtnback10()
        {
            Application.Run(new HomePage());
        }

        private void btnback11_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback11));
            t.Start();
        }
        private void Threadbtnback11()
        {
            Application.Run(new Recommendations());
        }
    }
}
