using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalTimer
{
    public partial class digitalTimer : Form
    {
        Timer t = new Timer();

        public digitalTimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //timer inteval
            t.Interval = 1000; //this is in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //This starts the timer when the form loads
            t.Start(); //this will use t_Tick method
        }

        // timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding the leading 0
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if(mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            label1.Text = time;
        }
    }
}
