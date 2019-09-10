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
                if (player == "X")
                    player = "O";
                else
                    player = "X";
                cell.Enabled = false;
                turnCount++;
                label1.Text = player + " turn";
            }

        }
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        #endregion
        private void setBoard(Button btn)
        {
            int xPos = btn.Name[btn.Name.Length - 2] - '0';
            int yPos = btn.Name[btn.Name.Length - 1] - '0';
            board[xPos, yPos] = player;
            System.Diagnostics.Debug.WriteLine("Xpos:" + xPos + "yPos:" + yPos + " player:" + board[xPos, yPos]);
        }
        private bool checkWin()
        {
            if (checkCol() || checkRow() || checkDiag())
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
        private bool checkCol()
        {
            for (int i = 0; i < 3; i++)
            {
                int count = 0;
                for (int j = 0; j < 2; j++)
                {
                    if (board[i, j] == board[i, j + 1] && board[i, j] == player)
                        count++;
                    if (count == 2)
                        return true;
                }
            }
            return false;
        }
        private bool checkRow()
        {
            for (int i = 0; i<3;i++)
            {
                int count = 0;
                for (int j = 0; j < 2; j++)
                {
                    if (board[j, i] == board[j + 1, i] && board[j, i] == player)
                        count++;
                    if (count == 2)
                        return true;
                }
            }
            return false;
        }
        private bool checkDiag()
        {
            int counter=0;
            for(int i = 0; i < 2; i++) // Sjekker "\" diagonal
            {
                if (board[i, i] == board[i + 1, i + 1] && board[i, i] == player)
                    counter++;
            }
            if (counter == 2)
                return true;
            counter = 0;
            for (int i = 0; i < 2;i++) // Sjekker "/" diagonal
            {
                if (board[2-i, i] == board[1-i , i + 1] && board[2-i, i] == player)
                    counter++;
            }
            if (counter == 2)
                return true;
            return false;
        }
        private void disableCells()
        {
            foreach (Button button in this.Controls.OfType<Button>()) // Velger alle knapper i denne klassen :/
            {
                button.Enabled = false;
            }
            reset_btn.Enabled = true;
        }
        private void resetGame()
        {
            label1.Text = "X turn";
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = "";
                }
            }
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Text = "";
                button.Enabled = true;
            }
            reset_btn.Text = "RESET";
            player = "X";
            turnCount = 1;
            label1.ForeColor = Color.White;
        }

    }
}
