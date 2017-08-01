using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingsbyFabrice
{
    public partial class frmGreetings : Form
    {
        private object cmdTimeset;

        public frmGreetings()
        {
            InitializeComponent();
        }

        private void tmrFlash_Tick(object sender, EventArgs e)
        {
            lblGreetings.Visible = !lblGreetings.Visible;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            tmrFlash.Stop();

            tmrFlash.Enabled = false;
            cmdRe_Start.Enabled = true;
            cmdTimeOne.Enabled= false;
            cmdTimetwo.Enabled = false;
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            tmrFlash.Start();

            tmrFlash.Enabled = true;
            cmdRe_Start.Enabled = false;
            cmdTimeOne.Enabled = true;
            cmdTimetwo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrFlash.Interval = 250;

        }

        private void cmdTimertwo_Click(object sender, EventArgs e)
        {
            tmrFlash.Interval = 2000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void SecondTimer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGreetings_Load(object sender, EventArgs e)
        {

        }
    }
}
