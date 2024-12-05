using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWPF.Model
{
    public class TTTBoard
    {
        public char[,] Cells { get; set; }
        public bool Turn { get; set; } = true;
        public int CountOfCells { get; set; } = 0;
        public string Player1Type { get; set; } = "Human";
        public string Player2Type { get; set; } = "BotEasy";

        public TTTBoard()
        {
            Initialize();
        }

        public void Initialize()
        {
            Cells = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }

        public bool CheckBoard()
        {
            if ((Cells[0, 0] == '1' && Cells[0, 1] == '1' && Cells[0, 2] == '1')
                || (Cells[1, 0] == '1' && Cells[1, 1] == '1' && Cells[1, 2] == '1')
                || (Cells[2, 0] == '1' && Cells[2, 1] == '1' && Cells[2, 2] == '1')
                || (Cells[0, 0] == '1' && Cells[1, 0] == '1' && Cells[2, 0] == '1')
                || (Cells[0, 1] == '1' && Cells[1, 1] == '1' && Cells[2, 1] == '1')
                || (Cells[0, 2] == '1' && Cells[1, 2] == '1' && Cells[2, 2] == '1')
                || (Cells[0, 0] == '1' && Cells[1, 1] == '1' && Cells[2, 2] == '1')
                || (Cells[0, 2] == '1' && Cells[1, 1] == '1' && Cells[2, 0] == '1'))
            {
                return true;
            }

            else if ((Cells[0, 0] == '0' && Cells[0, 1] == '0' && Cells[0, 2] == '0')
                || (Cells[1, 0] == '0' && Cells[1, 1] == '0' && Cells[1, 2] == '0')
                || (Cells[2, 0] == '0' && Cells[2, 1] == '0' && Cells[2, 2] == '0')
                || (Cells[0, 0] == '0' && Cells[1, 0] == '0' && Cells[2, 0] == '0')
                || (Cells[0, 1] == '0' && Cells[1, 1] == '0' && Cells[2, 1] == '0')
                || (Cells[0, 2] == '0' && Cells[1, 2] == '0' && Cells[2, 2] == '0')
                || (Cells[0, 0] == '0' && Cells[1, 1] == '0' && Cells[2, 2] == '0')
                || (Cells[0, 2] == '0' && Cells[1, 1] == '0' && Cells[2, 0] == '0'))
            {
                return true;
            }

            return false;
        }

        public void Reset_Board()
        {
            Cells = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Cells[i, j] = ' ';
                }
            }
        }
    }
}
