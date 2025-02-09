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
    public partial class LogAppliances : Form
    {
        public LogAppliances()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback8_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback8));
            t.Start();
        }
        private void Threadbtnback8()
        {
            Application.Run(new HomePage());
        }

        private void btnback9_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback9));
            t.Start();
        }
        private void Threadbtnback9()
        {
            Application.Run(new EnergyTracker());
        }
    }
}
