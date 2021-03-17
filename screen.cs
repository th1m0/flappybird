using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class screen : Form
    {
        public screen()
        {
            InitializeComponent();
            //Mainscreenpanel.Visible = true;
            //Mainscreenpanel.BringToFront();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // HOME SCREEN START BUTTON CLICK EVENT
            Mainscreenpanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // HOME SCREEN LEADERBOARD BUTTON CLICK EVENT
        }

        private void mainscreenpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
