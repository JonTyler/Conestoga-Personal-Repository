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
    /// <summary>
    /// The class for the form that contains all relevant code
    /// </summary>
    public partial class TicTacToe : Form
    {
        public bool turnStateIsO = false;
        public const int NUMBER_OF_PICTURES = 9;
        public int turnCount = 1;
        /// <summary>
        /// Constructor for the Form
        /// </summary>
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
            string[] nameArray = new string[NUMBER_OF_PICTURES];
            string WinMessage = "";
            if (OsTurn == true)
            {
                WinMessage = "O's Win!";
            }
            else
            {
                WinMessage = "X's Win!";
            }
            if (pictureBox1 != null && pictureBox2 != null && pictureBox3 != null)
            {
                if ((pictureBox1.BackgroundImage == pictureBox2.BackgroundImage) && (pictureBox2.BackgroundImage == pictureBox3.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();                    
                }
            }
            if (pictureBox4 != null && pictureBox5 != null && pictureBox6 != null)
            {
                if ((pictureBox4.BackgroundImage == pictureBox5.BackgroundImage) && (pictureBox5.BackgroundImage == pictureBox6.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox7 != null && pictureBox8 != null && pictureBox9 != null)
            {
                if ((pictureBox7.BackgroundImage == pictureBox8.BackgroundImage) && (pictureBox8.BackgroundImage == pictureBox9.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox1 != null && pictureBox4 != null && pictureBox7 != null)
            {
                if ((pictureBox1.BackgroundImage == pictureBox4.BackgroundImage) && (pictureBox4.BackgroundImage == pictureBox7.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox2 != null && pictureBox5 != null && pictureBox8 != null)
            {
                if ((pictureBox2.BackgroundImage == pictureBox5.BackgroundImage) && (pictureBox5.BackgroundImage == pictureBox8.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox3 != null && pictureBox6 != null && pictureBox9 != null)
            {
                if ((pictureBox3.BackgroundImage == pictureBox6.BackgroundImage) && (pictureBox6.BackgroundImage == pictureBox9.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox1 != null && pictureBox5 != null && pictureBox9 != null)
            {
                if ((pictureBox1.BackgroundImage == pictureBox5.BackgroundImage) && (pictureBox5.BackgroundImage == pictureBox9.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
            if (pictureBox7 != null && pictureBox5 != null && pictureBox3 != null)
            {
                if ((pictureBox7.BackgroundImage == pictureBox5.BackgroundImage) && (pictureBox5.BackgroundImage == pictureBox3.BackgroundImage))
                {
                    MessageBox.Show(WinMessage);
                    EndGame();
                }
            }
        }
        private void EndGame ()
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                picturePanel.Controls[i].Enabled = false;
            }
        }

    }
}
