using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int timeCs = 0, timeS = 0, timeMin = 0;
        bool isActive;

        private void lblstart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void lblstop_Click(object sender, EventArgs e)
        {
            isActive = false;

            //ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeS = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;

                if(timeCs >= 100)
                {
                    timeS++;
                    timeCs = 0;

                    if(timeS >= 60)
                    {
                        timeMin++;
                        timeS = 0;
                    }
                }
            }

            DrawTime();
        }

        private void DrawTime()
        {
            lblCs.Text = String.Format("{0,00}", timeCs);
            lbls.Text = String.Format("{0,00}", timeS);
            lblMin.Text = String.Format("{0,00}", timeMin);
        }

        private void lblR_Click(object sender, EventArgs e)
        {
            ResetTime();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }
    }
}
