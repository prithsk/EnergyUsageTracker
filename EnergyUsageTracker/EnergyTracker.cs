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
    public partial class EnergyTracker : Form
    {
        public EnergyTracker()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnLogAppliances_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadLogAppliances));
            t.Start();
        }

        private void ThreadLogAppliances()
        {
            Application.Run(new LogAppliances());
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback1));
            t.Start();
        }
        private void Threadbtnback1()
        {
            Application.Run(new HomePage());
        }
    }
}
