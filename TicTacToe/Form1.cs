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
        const string player1String = "X";
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
                label1.Text = player + " turn";
                cell.Enabled = false;
                turnCount++;
                computerTurn();
            }

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
        private void changePlayer()
        {
            if (player == "X")
            {
                player = "O";
            }
            else
                player = "X";
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
            label1.Refresh();
            board[move[0] - '0', move[1] - '0'] = player;
            System.Threading.Thread.Sleep(500);
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
                else
                {
                    changePlayer();
                    label1.Text = player + " turn";
                    turnCount++;
                }


        }
        private string computerDecideMove()
        {
            if (cell11.Enabled == true) // Allways take middle if possible ! 
            {
                return "11";
            }
            string move = checkImmidiateEnd(player);
            if (move != null)
                return move;
            move =  checkImmidiateEnd(player1String);
            if (move != null)
                return move;

            // Check row/col/diag function with possible win (Advanced function)

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
                        
                    if (playerCount == maxVal-1 && spaceCount == 1)
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
            string[] availableCells = new string[9];
            int availableCount = 0;
            for (int i = 0; i < maxVal; i++)
            {
                for (int j = 0; j< maxVal; j++)
                {
                    if (board[i, j] == null)
                    {
                        availableCells[availableCount] = i.ToString() + j.ToString();
                    }
                }
            }
            Random rng = new Random();
            return availableCells[rng.Next(0, availableCount)];
        }
        #endregion
    }

}
