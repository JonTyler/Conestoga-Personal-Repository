/*JtylerAssignment2.cs
 * Assignment 2 for Prog 2370
 * 
 * Revision History
 *      Jonathon Tyler: 2014.09.28: Created
 *      Jonathon TylerL 2014.10.02: Pulled hair out trying to iterate a simpler solution; failed.
 */

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
        public int[] selectedTurn = new int[NUMBER_OF_PICTURES];
        public const int X_WIN = 3;
        public const int O_WIN = -3;
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
                            selectedTurn[i] = -1;
                            break;
                        case false:
                            picturePanel.Controls[i].BackgroundImage = JtylerAssignment2.Properties.Resources._7406807_f260;
                            picturePanel.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                            selectedTurn[i] = 1;
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
        private void TurnIncrement()
        {
            turnCount = turnCount + 1;
            lblTurnCount.Text = turnCount.ToString();
        }
        /// <summary>
        /// Switches the Turn State bool to the other side's turn and displays a little form with a message.
        /// </summary>
        private void TurnState()
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
            if (turnCount > 5)
            {
                WinCheck(turnStateIsO);
            }
        }
        /// <summary>
        /// Checks if a win condition has occured and displays a message saying so, then calls the win test method.
        /// </summary>
        private void WinCheck(bool OsTurn)
        {
            string[] nameArray = new string[NUMBER_OF_PICTURES];
            string WinMessage = "";
            if (OsTurn == true)
            {
                WinMessage = "X's Win!";
            }
            else
            {
                WinMessage = "0's Win!";
            }

            int win1 = selectedTurn[0] + selectedTurn[1] + selectedTurn[2];
            WinTest(win1, WinMessage);
            int win2 = selectedTurn[3] + selectedTurn[4] + selectedTurn[5];
            WinTest(win2, WinMessage);
            int win3 = selectedTurn[6] + selectedTurn[7] + selectedTurn[8];
            WinTest(win3, WinMessage);
            int win4 = selectedTurn[0] + selectedTurn[3] + selectedTurn[6];
            WinTest(win4, WinMessage);
            int win5 = selectedTurn[1] + selectedTurn[4] + selectedTurn[7];
            WinTest(win5, WinMessage);
            int win6 = selectedTurn[2] + selectedTurn[5] + selectedTurn[8];
            WinTest(win6, WinMessage);
            int win7 = selectedTurn[0] + selectedTurn[4] + selectedTurn[8];
            WinTest(win7, WinMessage);
            int win8 = selectedTurn[2] + selectedTurn[4] + selectedTurn[6];
            WinTest(win8, WinMessage);


        }
        /// <summary>
        /// Does simple arithmetic to test each win condition by summing rows based on the array. Calls the endgame method if a win happened.
        /// </summary>
        /// <param name="winInt"></param>
        /// <param name="winMessage"></param>
        private void WinTest(int winInt, string winMessage)
        {
            if (winInt == X_WIN)
            {
                MessageBox.Show(winMessage);
                EndGame();
            }
            else if (winInt == O_WIN)
            {
                MessageBox.Show(winMessage);
                EndGame();
            }
        }

        /// <summary>
        /// A void method called when a win condition is met that disables all the pictureboxes, preventing additional turns from being entered.
        /// </summary>
        private void EndGame()
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                picturePanel.Controls[i].Enabled = false;
                lblTurnOrder.Text = "GAME OVER";
            }
        }
        /// <summary>
        /// Rests the game state. Due to the way the game is coded, this will fix winners too.
        /// </summary>
        /// <param name="sender">The btnNewGAme button object.</param>
        /// <param name="e">A mouseclick event.</param>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NUMBER_OF_PICTURES; i++)
            {
                picturePanel.Controls[i].BackgroundImage = null;
                picturePanel.Controls[i].Enabled = true;
            }
            turnCount = 1;
            turnStateIsO = false;
            lblTurnCount.Text = turnCount.ToString();
            lblTurnOrder.Text = "X's Turn";

        }
    }
}
