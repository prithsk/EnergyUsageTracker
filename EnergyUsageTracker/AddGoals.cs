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
    public partial class AddGoals : Form
    {
        public AddGoals()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback12_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback12));
            t.Start();
        }
        private void Threadbtnback12()
        {
            Application.Run(new HomePage());
        }

        private void btnback13_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback13));
            t.Start();
        }
        private void Threadbtnback13()
        {
            Application.Run(new SetGoals());
        }
    }
}
