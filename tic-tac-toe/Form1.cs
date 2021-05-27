using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int playerTurn = 0;
        public static int numOfTurns = 0;

        public void checkWin()
        {
            bool playerWin = false;
            string ekso = "";
            switch (playerTurn)
            {
                case 0:
                    ekso = "O";
                    break;
                case 1:
                    ekso = "X";
                    break;
            }

            numOfTurns = numOfTurns + 1; 

            if(btnTopLeft.Text == ekso && btnTopMid.Text == ekso && btnTopRight.Text == ekso)
            {
                playerWin = true;
            }
            else if(btnMidLeft.Text == ekso && btnMidMid.Text == ekso && btnMidRight.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnBotLeft.Text == ekso && btnBotMid.Text == ekso && btnBotRight.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnMidLeft.Text == ekso && btnMidMid.Text == ekso && btnBotMid.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnTopLeft.Text == ekso && btnMidLeft.Text == ekso && btnBotLeft.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnTopMid.Text == ekso && btnMidMid.Text == ekso && btnBotMid.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnTopRight.Text == ekso && btnMidRight.Text == ekso && btnBotRight.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnTopLeft.Text == ekso && btnMidMid.Text == ekso && btnBotRight.Text == ekso)
            {
                playerWin = true;
            }
            else if (btnBotLeft.Text == ekso && btnMidMid.Text == ekso && btnTopRight.Text == ekso)
            {
                playerWin = true;
            }
            else
            {
                playerWin = false;
            }

            if (playerWin || numOfTurns == 9)
            {
                DialogResult dialogResult;
                if (playerWin)
                {
                    dialogResult = MessageBox.Show(ekso + " wins the game. Do you want to play again?", "Tic-Tac-Toe", MessageBoxButtons.YesNo);
                }
                else
                {
                    dialogResult = MessageBox.Show("It's a tie. Do you want to play again?", "Tic-Tac-Toe", MessageBoxButtons.YesNo);
                }
                

                if (dialogResult == DialogResult.Yes)
                {
                    btnTopLeft.Enabled = true;
                    btnMidLeft.Enabled = true;
                    btnBotLeft.Enabled = true;
                    btnTopMid.Enabled = true;
                    btnMidMid.Enabled = true;
                    btnBotMid.Enabled = true;
                    btnTopRight.Enabled = true;
                    btnMidRight.Enabled = true;
                    btnBotRight.Enabled = true;

                    btnTopLeft.Text = "";
                    btnMidLeft.Text = "";
                    btnBotLeft.Text = "";
                    btnTopMid.Text = "";
                    btnMidMid.Text = "";
                    btnBotMid.Text = "";
                    btnTopRight.Text = "";
                    btnMidRight.Text = "";
                    btnBotRight.Text = "";

                    playerTurn = 0;
                    playerWin = false;
                    numOfTurns = 0;

                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
           
        }

        public int turnPlay(int turn, int boxNum)
        {
            if (turn == 0)
            {
                switch (boxNum) 
                {
                    case 1:
                        btnTopLeft.Text = "X";
                        break;
                    case 2:
                        btnMidLeft.Text = "X";
                        break;
                    case 3:
                        btnBotLeft.Text = "X";
                        break;
                    case 4:
                        btnTopMid.Text = "X";
                        break;
                    case 5:
                        btnMidMid.Text = "X";
                        break;
                    case 6:
                        btnBotMid.Text = "X";
                        break;
                    case 7:
                        btnTopRight.Text = "X";
                        break;
                    case 8:
                        btnMidRight.Text = "X";
                        break;
                    case 9:
                        btnBotRight.Text = "X";
                        break;
                }
                turn = 1;
            }
            else
            {
                switch (boxNum)
                {
                    case 1:
                        btnTopLeft.Text = "O";
                        break;
                    case 2:
                        btnMidLeft.Text = "O";
                        break;
                    case 3:
                        btnBotLeft.Text = "O";
                        break;
                    case 4:
                        btnTopMid.Text = "O";
                        break;
                    case 5:
                        btnMidMid.Text = "O";
                        break;
                    case 6:
                        btnBotMid.Text = "O";
                        break;
                    case 7:
                        btnTopRight.Text = "O";
                        break;
                    case 8:
                        btnMidRight.Text = "O";
                        break;
                    case 9:
                        btnBotRight.Text = "O";
                        break;
                }
                turn = 0;
            }
            return turn;
            
        }


        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            btnTopLeft.Enabled = false;
            playerTurn = turnPlay(playerTurn, 1);
            checkWin();
        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            btnMidLeft.Enabled = false;
            playerTurn = turnPlay(playerTurn, 2);
            checkWin();
        }

        private void btnBotLeft_Click(object sender, EventArgs e)
        {
            btnBotLeft.Enabled = false;
            playerTurn = turnPlay(playerTurn, 3);
            checkWin();
        }

        private void btnTopMid_Click(object sender, EventArgs e)
        {
            btnTopMid.Enabled = false;
            playerTurn = turnPlay(playerTurn, 4);
            checkWin();
        }

        private void btnMidMid_Click(object sender, EventArgs e)
        {
            btnMidMid.Enabled = false;
            playerTurn = turnPlay(playerTurn, 5);
            checkWin();
        }

        private void btnBotMid_Click(object sender, EventArgs e)
        {
            btnBotMid.Enabled = false;
            playerTurn = turnPlay(playerTurn, 6);
            checkWin();
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            btnTopRight.Enabled = false;
            playerTurn = turnPlay(playerTurn, 7);
            checkWin();
        }

        private void btnMidRight_Click(object sender, EventArgs e)
        {
            btnMidRight.Enabled = false;
            playerTurn = turnPlay(playerTurn, 8);
            checkWin();
        }

        private void btnBotRight_Click(object sender, EventArgs e)
        {
            btnBotRight.Enabled = false;
            playerTurn = turnPlay(playerTurn, 9);
            checkWin();
        }

              
    }
}
