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
    public partial class JumpingButton4 : Form
    {
        public JumpingButton4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            //button1.Left += 10;
            for (int i = 0; i < this.Controls.Count; i++)
            {                
                int randomNumber = rand.Next(0, 20);
                this.Controls[i].Left += randomNumber + randomNumber;
            }
        }
    }
}
