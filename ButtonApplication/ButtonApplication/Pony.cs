using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonApplication
{
    public class Pony : Button
    {
        private Timer timer;
        private Panel panFinishLine;

        private bool isStarted = false;

        public bool IsStarted
        {
            get { return isStarted; }
            set
            {
                isStarted = value;
                timer.Enabled = value;
            }
        }
        private bool isFinished = false;
        private int displacement = 50;

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        private int interval = 100;

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        public Pony(Panel panFinishLine, int interval, int displacement)
        {
            timer = new Timer();
            this.interval = interval;
            this.displacement = displacement;
            this.panFinishLine = panFinishLine;
            timer.Enabled = this.isStarted;
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            RaceCopy rc = (RaceCopy)this.Parent;
        }


    }
}
