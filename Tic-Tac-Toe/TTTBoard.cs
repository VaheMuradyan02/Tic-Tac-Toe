using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tic_Tac_Toe.Form1;

namespace Tic_Tac_Toe
{
    public class TTTBoard
    {
        public char[,] cells;
        public bool Turn { get; set; } = true;
        public int countOfAddCells = 0;
        public EPlayerType Player1 { get; set; }
        public EPlayerType Player2 { get; set; }


        public TTTBoard()
        {
            cells = new char[3, 3];
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for(int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = ' ';
                }
            }

            ResetBoard();
        }

        public void LogicH(EPlayerType playerType, int row, int col)
        {
            switch (playerType)
            {
                case EPlayerType.Player:
                    cells[row, col] = '1';
                    //cells =
                    
                    break;
                case EPlayerType.Bot:
                    cells[row, col] = '0';
                    break;
            }
        }

        public bool CheckBoard()
        {
            //mtacel aveli lav tarberak

            if (cells[0, 0] == '1' && cells[0, 1] == '1' && cells[0, 2] == '1'
                || cells[1, 0] == '1' && cells[1, 1] == '1' && cells[1, 2] == '1'
                || cells[2, 0] == '1' && cells[2, 1] == '1' && cells[2, 2] == '1'
                || cells[0, 0] == '1' && cells[1, 0] == '1' && cells[2, 0] == '1'
                || cells[0, 1] == '1' && cells[1, 1] == '1' && cells[2, 1] == '1'
                || cells[0, 2] == '1' && cells[2, 2] == '1' && cells[2, 2] == '1'
                || cells[0, 0] == '1' && cells[1, 1] == '1' && cells[2, 2] == '1'
                || cells[0, 2] == '1' && cells[1, 1] == '1' && cells[2, 0] == '1') 
            {
                MessageBox.Show("Player1 Win  - 'X'");
                return true;
            }

            else if (cells[0, 0] == '0' && cells[0, 1] == '0' && cells[0, 2] == '0'
                || cells[1, 0] == '0' && cells[1, 1] == '0' && cells[1, 2] == '0'
                || cells[2, 0] == '0' && cells[2, 1] == '0' && cells[2, 2] == '0'
                || cells[0, 0] == '0' && cells[1, 0] == '0' && cells[2, 0] == '0'
                || cells[0, 1] == '0' && cells[1, 1] == '0' && cells[2, 1] == '0'
                || cells[0, 2] == '0' && cells[2, 2] == '0' && cells[2, 2] == '0'
                || cells[0, 0] == '0' && cells[1, 1] == '0' && cells[2, 2] == '0'
                || cells[0, 2] == '0' && cells[1, 1] == '0' && cells[2, 0] == '0')
            {
                MessageBox.Show("Player2 Win  - 'O'");
                return true;
            }

            return false;
        }

        public void ResetBoard()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = ' ';
                }
            }
        }

        /*private void RestartGamePvP()
        {
            isVisited = true;

            buttonsPvP = new List<Button>();

            for (int i = 1; i <= 9; i++)
            {
                Button button = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (button != null)
                {
                    buttonsPvP.Add(button);
                }
            }

            foreach (Button x in buttonsPvP)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
        }

        private void RestartGamePCvPEasy()
        {
            isVisited = true;

            buttonsPvPCEasy = new List<Button>();

            for (int i = 11; i <= 19; i++)
            {
                Button button = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (button != null)
                {
                    buttonsPvPCEasy.Add(button);
                }
            }

            foreach (Button x in buttonsPvPCEasy)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
        }

        private void RestartGamePCvPC()
        {
            isVisited = true;

            buttonsPCvPC = new List<Button>();

            for (int i = 21; i <= 29; i++)
            {
                Button button = this.Controls.Find($"button{i}", true).FirstOrDefault() as Button;
                if (button != null)
                {
                    buttonsPCvPC.Add(button);
                }
            }

            foreach (Button x in buttonsPCvPC)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
        }*/


    }
}
