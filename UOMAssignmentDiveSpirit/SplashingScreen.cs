using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UOMAssignmentDiveSpirit
{
    public partial class SplashingScreen : Form
    {
        public SplashingScreen()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void SplashingScreen_Load(object sender, EventArgs e)
        {

        }

        private void SplashingScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 6 sec

            tmr.Interval = 6000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {
            //after 6 sec stop the timer

            tmr.Stop();

            //display mainform

            LoginForm mf = new LoginForm();

            mf.Show();

            //hide this form

            this.Hide();
        }
    }
}
