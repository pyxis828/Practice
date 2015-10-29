using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournyManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerWindow viewClock = new timerWindow(); 
            viewClock.Show();          
        }

        private void tournyEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tournament_Entry entryWindow = new Tournament_Entry();
            entryWindow.Show();
        }
    }
}
