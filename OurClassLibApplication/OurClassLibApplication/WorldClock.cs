using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurClassLibApplication
{
    public partial class WorldClock : UserControl
    {
        [Browsable(true)]
        [Category("Custom")]
        [Description("Deviation")]
        public enum Deviation
        {
            Add,
            Subtract
        }
        private DateTime now;
        private Deviation difference = Deviation.Add;

        [Browsable(true)]
        [Category("Custom")]
        [Description("Positive/Negative Difference")]
        public Deviation Difference
        {
            get { return difference; }
            set { difference = value; }
        }
        private int hour = 0;
        [Browsable(true)]
        [Category("Custom")]
        [Description("Hour")]
        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0)
                {
                    hour = 0;
                }
                else
                { 
                    hour = value; 
                }
            }
        }
        private int minute = 0;
        [Browsable(true)]
        [Category("Custom")]
        [Description("Minute")]
        public int Minute
        {
            get { return minute; }
            set
            {
                if (minute < 0)
                {
                    minute = 0;
                }
                else
                {
                    minute = value;
                }
            }
        }
        private string address = "Kitchener";
        [Browsable(true)]
        [Category("Custom")]
        [Description("Location")]
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                lblLocation.Text = value;
            }
        }
        public WorldClock()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            TimeSpan diff = new TimeSpan(hour, minute, 0);
            switch (Difference)
            {
                case Deviation.Add:
                    now = now.Add(diff);
                    break;
                case Deviation.Subtract:
                    now = now.Subtract(diff);
                    break;
                default:
                    break;
            }
            string date = now.ToLongDateString();
            string time = now.ToLongTimeString();
            lblDate.Text = date;
            lblTime.Text = time;
        }
    }
}
