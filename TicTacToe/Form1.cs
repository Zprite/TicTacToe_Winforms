using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
    
{
    public partial class Form1 : Form
    {
        string player = "X";
        string opponent = "O";
        string[,] board = new string[3, 3];
        int turnCount = 1;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Bondesjakk"; 
            label1.Text = player + " turn";
        }

        #region UI
        private void Cell_click(object sender, EventArgs e)
        {
            Button cell = (Button)sender;
            setBoard(cell);
            cell.Text = player;
            if (checkWin())
                disableCells();
            else
            {
                changePlayer();
                cell.Enabled = false;
                turnCount++;
                label1.Text = player + " turn";
                computerTurn();
            }

        }

        private void changePlayer()
        {
            if (player == "X")
            {
                player = "O";
            }
            else
                player = "X";
        }
        private void disableCells()
        {
            foreach (Control c in boardPanel.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        private void resetGame()
        {
            label1.Text = "X turn";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = null;
                }
            }
            resetButtons();
            player = "X";
            turnCount = 1;
            label1.ForeColor = Color.White;
        }
        private void resetButtons()
        {
            foreach (Control c in boardPanel.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.Enabled = true;
                }
            }
        }
        #endregion

        #region GameLogic
        private void setBoard(Button btn)
        {
            int xPos = btn.Name[btn.Name.Length - 2] - '0';
            int yPos = btn.Name[btn.Name.Length - 1] - '0';
            board[xPos, yPos] = player;
            // System.Diagnostics.Debug.WriteLine("Xpos:" + xPos + "yPos:" + yPos + " player:" + board[xPos, yPos]);
        }
        private bool checkWin()
        {
           if (checkCol(3) || checkRow(3) || checkDiag(3))
            {
                label1.Text = player + " WINS!";
                label1.ForeColor = Color.LimeGreen;
                return true;
            }
            else if (turnCount >= 9)
            {
                label1.Text = "DRAW";
                label1.ForeColor = Color.Yellow;
                return true;
            }
            return false;
        }
        private bool checkCol(int maxVal)
        {
            for (int i = 0; i < maxVal; i++)
            {
                int playerCount = 0;
                for (int j = 0; j < maxVal; j++)
                {
                    if (board[i, j] == player)
                        playerCount++;
                    if (playerCount == maxVal)
                        return true;
                }
            }
            return false;
        }
        private bool checkRow(int maxVal)
        {
            for (int i = 0; i<maxVal;i++)
            {
                int playerCount = 0;
                for (int j = 0; j < maxVal; j++)
                {
                    if (board[j, i] == player)
                        playerCount++;
                    if (playerCount == maxVal)
                        return true;
                }
            }
            return false;
        }
        private bool checkDiag(int maxVal)
        {
            int playerCount=0;
            for(int i = 0; i < maxVal; i++) // Sjekker "\" diagonal
            {
                if (board[i, i] == player)
                    playerCount++;
            }
            if (playerCount == maxVal)
                return true;

            playerCount = 0;
            for (int i = 0; i < maxVal;i++) // Sjekker "/" diagonal
            {
                if (board[(maxVal-1)-i, i] == player)
                    playerCount++;
            }
            if (playerCount == maxVal)
                return true;
            return false;
        }
        #endregion
        #region AI

        private void computerTurn()
        {
            string move = computerDecideMove();
            label1.Text = player + " turn";
            if (move != null)
            {
                System.Threading.Thread.Sleep(300);
                board[move[0] - '0', move[1] - '0'] = player;
                foreach (Control c in boardPanel.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Name == "cell" + move[0] + move[1])
                        {
                            c.Enabled = false;
                            c.Text = player;
                        }    
                    }
                }
                if (checkWin())
                    disableCells();
                changePlayer();
                turnCount++;
            }
            
        }
        private string computerDecideMove()
        {
            string move = checkImmidiateEnd(player);
            if (move != null)
                return move;
            move =  checkImmidiateEnd("X");
            if (move != null)
                return move;
            // Check row/col/diag with possible win
            // Else set unset cell
            move = checkAvailableCell(3);
            if (move != null)
                return move;
            return "REEEEE";
        }

        private string checkImmidiateEnd(string playerIcon) {
            string movePos = null;
            if (checkImmidiateEndCol(3, playerIcon) != null)
                movePos = checkImmidiateEndCol(3, playerIcon);
           else if (checkImmidiateEndRow(3, playerIcon) != null)
                movePos = checkImmidiateEndRow(3, playerIcon);
           else if (checkImmidiateEndDiag(3, playerIcon) != null)
                movePos = checkImmidiateEndDiag(3, playerIcon);
            return movePos;
        }
        private string checkImmidiateEndRow(int maxVal, string player)
        {
            for (int i = 0; i < maxVal; i++)
            {
                int playerCount = 0;
                int spaceCount = 0;
                int xPos = 0;
                int yPos = 0;
                for (int j = 0; j < maxVal; j++)
                {
                    if (board[j, i] == player)
                        playerCount++;
                    else if (board[j, i] == null){
                        spaceCount++;
                        xPos = j;
                        yPos = i;
                    }
                        
                    if (playerCount == maxVal && spaceCount == 1)
                        return xPos.ToString() + yPos.ToString();
                }
            }
            return null;
        }
        private string checkImmidiateEndCol(int maxVal, string player)
        {
            for (int i = 0; i < maxVal; i++)
            {
                int playerCount = 0;
                int spaceCount = 0;
                int xPos = 0;
                int yPos = 0;
                for (int j = 0; j < maxVal; j++)
                {
                    if (board[i, j] == player)
                        playerCount++;
                    else if (board[i, j] == null)
                    {
                        spaceCount++;
                        xPos = i;
                        yPos = j;
                    }
                        
                    if (playerCount == maxVal-1 && spaceCount == 1)
                        return xPos.ToString() + yPos.ToString();
                }
            }
            return null;
        }
        private string checkImmidiateEndDiag(int maxVal, string player)
        {
            int playerCount = 0;
            int spaceCount = 0;
            int xPos = 0;
            int yPos = 0;
            for (int i = 0; i < maxVal; i++)
            {
                    if (board[i, i] == player)
                        playerCount++;
                    else if (board[i, i] == null)
                {
                    spaceCount++;
                    xPos = i;
                }
                       
                if (playerCount == maxVal - 1 && spaceCount == 1)
                    return xPos.ToString() + xPos.ToString();
            }
            playerCount = 0;
            spaceCount = 0;
            for (int i = 0; i < maxVal; i++) // Sjekker "/" diagonal
            {
                if (board[(maxVal - 1) - i, i] == player)
                    playerCount++;
                else if (board[(maxVal - 1) - i, i] == null) {
                    spaceCount++;
                    xPos = (maxVal - 1) - i;
                    yPos = i;
                }
                    
                if (playerCount == maxVal - 1 && spaceCount == 1)
                    return xPos.ToString() + yPos.ToString();
            }
            return null;
        }
        private string checkAvailableCell(int maxVal)
        {
            for (int i = 0; i < maxVal; i++)
            {
                for (int j = 0; j< maxVal; j++)
                {
                    if (board[i, j] == null)
                        return i.ToString() + j.ToString();
                }
            }
            return null;
        }
        #endregion
    }

}
