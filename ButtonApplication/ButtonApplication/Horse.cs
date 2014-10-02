using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonApplication
{
    public class Horse : Button
    {
        private Panel finishLine;
        private Timer timer;

        private bool isFinished = false;
        private bool isStarted = false;

        public bool IsStarted
        {
            get { return isStarted; }
            set { isStarted = value;
            timer.Enabled = value;
            }
        }
        private int interval = 100;

        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        private int displacement = 50;

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public Horse()
        {
            timer = new Timer();
            timer.Interval = this.interval;
            timer.Enabled = this.isStarted;
            timer.Tick += timer_Tick;
        }
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="finishLine"></param>
        /// <param name="interval"></param>
        /// <param name="displacement"></param>
        public Horse(Panel finishLine,
            int interval,
            int displacement)
        {
            timer = new Timer();
            this.interval = interval;
            timer.Interval = this.interval;
            this.displacement = displacement;
            this.finishLine = finishLine;
            timer.Enabled = this.isStarted;
            timer.Tick += timer_Tick;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            RaceGame rg = (RaceGame)this.Parent;
            this.Left += displacement;
            if (isFinished == false)
            {
                if(this.Left + this.Width > finishLine.Left)
                {
                    this.isFinished = true;
                    timer.Stop();
                    rg.Result += this.Text + "\n";
                }
            }
        }
    }
}
