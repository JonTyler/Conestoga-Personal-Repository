using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonApplication
{
    public partial class RaceGame : Form
    {
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public RaceGame()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int numberofHorses = 5;
            int startX = 10;
            int startY = 10;
            Random rand = new Random();

            int minSpeed = 20;
            int maxSpeed = 30;
            int minInterval = 100;
            int maxInterval = 300;

            for (int i = 0; i < numberofHorses; i++)
            {
                
                //Horse h = new Horse();
                //h.Interval = rand.Next(minInterval, maxInterval);
                //h.Displacement = rand.Next(minSpeed, maxSpeed);
                Horse h = new Horse(finishLine, rand.Next(minInterval, maxInterval), rand.Next(minSpeed, maxSpeed));
                h.Left = startX;
                h.Top = startY;
                h.Width = 30;
                h.Height = 10;
                h.Text = i.ToString();
                h.IsStarted = true;
                this.Controls.Add(h);
                startY += 30;
                h.Click += h_Click;
            }
        }

        void h_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Neigh. -_-");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(result);
        }
    }
}
