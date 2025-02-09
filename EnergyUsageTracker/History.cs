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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback6_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback6));
            t.Start();
        }
        private void Threadbtnback6()
        {
            Application.Run(new About());
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback4));
            t.Start();
        }
        private void Threadbtnback4()
        {
            Application.Run(new HomePage());
        }
    }
}
