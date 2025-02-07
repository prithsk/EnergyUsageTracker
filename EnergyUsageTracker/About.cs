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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnRationale_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadRationale));
            t.Start();
        }

        private void ThreadRationale()
        {
            Application.Run(new Rationale());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadbtnHistory));
            t.Start();
        }

        private void ThreadbtnHistory()
        {
            Application.Run(new History());
        }
    }
}
