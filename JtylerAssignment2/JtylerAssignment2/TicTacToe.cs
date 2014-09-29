using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtylerAssignment2
{
    public partial class TicTacToe : Form
    {
        public bool turnStateIsO = false;
        public const int NUMBER_OF_PICTURES = 9;
        public object[] pictureBoxList = new object[NUMBER_OF_PICTURES];
        
        public TicTacToe()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On load, places all the picture boxes into the picture box array, then runs a for loop that adds the on click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                pictureBoxList[i] = picturePanel.Controls[i];
                picturePanel.Controls[i].Click += new EventHandler(PictureBoxClick);
                Console.WriteLine(pictureBoxList[i].ToString());
            }
        }
        /// <summary>
        /// The click event handler. Gets the name of the clicked item and does changes to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxClick(object sender, EventArgs e)
        {
            
        }
    }
}
