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
    public partial class RaceCopy : Form
    {
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public const int NUMBER_OF_PONIES = 5;
        private const int STARTINGX = 15;
        private const int STARTINGY = 15;
        private const int MINSPEED = 15;
        private const int MAXSPEED = 30;
        private const int MINDISPLACE = 200;
        private const int MAXDISPLACE = 400;
        Random rand = new Random();

        public RaceCopy()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show(result);
        }
    }
}
