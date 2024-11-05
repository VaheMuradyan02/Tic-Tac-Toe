using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Tic_Tac_Toe.Form1;

namespace Tic_Tac_Toe.Model
{
    public class TTTBoard
    {
        public char[,] Cells { get; set; }
        public bool Turn { get; set; } = true;
        public int CountOfAddCells { get; set; } = 0;
        public EPlayerType Player1 { get; set; }
        public EPlayerType Player2 { get; set; }


        public TTTBoard()
        {
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            Cells = new char[3, 3];
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for(int j = 0; j < Cells.GetLength(1); j++)
                {
                    Cells[i, j] = ' ';
                }
            }

            //ResetBoard();
        }

        public bool CheckBoard()
        {
            //mtacel aveli lav tarberak

            if (Cells[0, 0] == '1' && Cells[0, 1] == '1' && Cells[0, 2] == '1'
                || Cells[1, 0] == '1' && Cells[1, 1] == '1' && Cells[1, 2] == '1'
                || Cells[2, 0] == '1' && Cells[2, 1] == '1' && Cells[2, 2] == '1'
                || Cells[0, 0] == '1' && Cells[1, 0] == '1' && Cells[2, 0] == '1'
                || Cells[0, 1] == '1' && Cells[1, 1] == '1' && Cells[2, 1] == '1'
                || Cells[0, 2] == '1' && Cells[2, 2] == '1' && Cells[2, 2] == '1'
                || Cells[0, 0] == '1' && Cells[1, 1] == '1' && Cells[2, 2] == '1'
                || Cells[0, 2] == '1' && Cells[1, 1] == '1' && Cells[2, 0] == '1') 
            {
                MessageBox.Show("Player1 Win  - 'X'");
                return true;
            }

            else if (Cells[0, 0] == '0' && Cells[0, 1] == '0' && Cells[0, 2] == '0'
                || Cells[1, 0] == '0' && Cells[1, 1] == '0' && Cells[1, 2] == '0'
                || Cells[2, 0] == '0' && Cells[2, 1] == '0' && Cells[2, 2] == '0'
                || Cells[0, 0] == '0' && Cells[1, 0] == '0' && Cells[2, 0] == '0'
                || Cells[0, 1] == '0' && Cells[1, 1] == '0' && Cells[2, 1] == '0'
                || Cells[0, 2] == '0' && Cells[2, 2] == '0' && Cells[2, 2] == '0'
                || Cells[0, 0] == '0' && Cells[1, 1] == '0' && Cells[2, 2] == '0'
                || Cells[0, 2] == '0' && Cells[1, 1] == '0' && Cells[2, 0] == '0')
            {
                MessageBox.Show("Player2 Win  - 'O'");
                return true;
            }

            return false;
        }

        public void ResetBoard()
        {
            for (int i = 0; i < Cells.GetLength(0); i++)
            {
                for (int j = 0; j < Cells.GetLength(1); j++)
                {
                    Cells[i, j] = ' ';
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
