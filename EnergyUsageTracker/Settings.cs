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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(Threadbtnback3));
            t.Start();
        }
        private void Threadbtnback3()
        {
            Application.Run(new HomePage());
        }
    }
}
