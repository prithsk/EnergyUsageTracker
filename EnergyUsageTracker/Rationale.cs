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
    public partial class Rationale : Form
    {
        public Rationale()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback5));
            t.Start();
        }

        private void Threadbtnback5()
        {
            Application.Run(new HomePage());
        }

        private void btnback7_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback7));
            t.Start();
        }
        private void Threadbtnback7()
        {
            Application.Run(new About());
        }
    }
}
