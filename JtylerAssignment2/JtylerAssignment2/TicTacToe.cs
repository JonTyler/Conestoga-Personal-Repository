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
        public int turnCount = 1;
       

        
        public TicTacToe()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On load, loops through the array in the panel and places the pictureboxclick event handler on each box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                picturePanel.Controls[i].Click += new EventHandler(PictureBoxClick);                
            }
            lblTurnCount.Text = turnCount.ToString();
            lblTurnOrder.Text = "X's Turn";
        }
        /// <summary>
        /// The click event handler. Gets the name of the clicked item and does changes to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxClick(object sender, EventArgs e)
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                if (picturePanel.Controls[i] == sender && picturePanel.Controls[i].BackgroundImage == null)
                {
                    switch (turnStateIsO)
                    {
                        case true:
                            picturePanel.Controls[i].BackgroundImage = JtylerAssignment2.Properties.Resources._7406806_f260;
                            picturePanel.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        case false:
                            picturePanel.Controls[i].BackgroundImage = JtylerAssignment2.Properties.Resources._7406807_f260;
                            picturePanel.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                    }
                    TurnIncrement();
                    TurnState();
                }
            }
            
        }
        /// <summary>
        /// Increments the turn by one.
        /// </summary>
        private void TurnIncrement ()
        {
            turnCount = turnCount + 1;
            lblTurnCount.Text = turnCount.ToString();
        }
        /// <summary>
        /// Switches the Turn State bool to the other side's turn and displays a little form with a message.
        /// </summary>
        private void TurnState ()
        {
            if (turnStateIsO == false)
            {
                turnStateIsO = true;
                lblTurnOrder.Text = "O's Turn.";
            }
            else
            {
                turnStateIsO = false;
                lblTurnOrder.Text = "X's Turn.";
            }
            WinCheck(turnStateIsO);
        }
        /// <summary>
        /// Checks if a win condition has occured and displays a message saying so, then calls the disable-all method to stop further turns from being input.
        /// </summary>
        private void WinCheck (bool OsTurn)
        {
            string WinMessage = "";
            if (OsTurn == true)
            {
                WinMessage = "O's Win!";
            }
            else
            {
                WinMessage = "X's Win!";
            }

            if ((pictureBox1.Image == pictureBox2.Image) && (pictureBox2.Image == pictureBox3.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox1.Image == pictureBox4.Image) && (pictureBox4.Image == pictureBox7.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox1.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox9.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox2.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox8.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox3.Image == pictureBox6.Image) && (pictureBox6.Image == pictureBox9.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox4.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox6.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox7.Image == pictureBox8.Image) && (pictureBox8.Image == pictureBox9.Image))
            {
                MessageBox.Show(WinMessage);
            }
            else if ((pictureBox7.Image == pictureBox5.Image) && (pictureBox5.Image == pictureBox3.Image))
            {
                MessageBox.Show(WinMessage);
            }

        }

    }
}
