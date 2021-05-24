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
        public int playerTurn = 0;
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
                }
                turn = 0;
            }
            return turn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            playerTurn = turnPlay(playerTurn, 1);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            playerTurn = turnPlay(playerTurn, 3);
        }

        private void btnTopMid_Click(object sender, EventArgs e)
        {

        }

        private void btnMidLeft_Click(object sender, EventArgs e)
        {
            playerTurn = turnPlay(playerTurn, 2);
        }
    }
}
