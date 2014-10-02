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
    public partial class RaceButtons : Form
    {
        private const int LEFT = 20;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int TOP = 15;
        //gap between buttons.
        private const int VGAP = 60;
        public RaceButtons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = LEFT;
            int y = TOP;

            int buttonNumber = int.Parse(textBox1.Text);
            for (int i = 0; i < buttonNumber; i++)
            {
                Button b = new Button();
                b.Left = x;
                b.Top = y;
                b.Width = WIDTH;
                b.Height = HEIGHT;
                b.Text = i.ToString();

                b.Click += b_Click;
                b.KeyDown += b_KeyDown;

                //add the element to the controls list before it will show up.

                this.Controls.Add(b);

                y += VGAP;
            }
        }

        void b_KeyDown(object sender, KeyEventArgs e)
        {
            Button b = (Button)sender;
            b.Left += 30;
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Left += 30;
        }
    }
}
