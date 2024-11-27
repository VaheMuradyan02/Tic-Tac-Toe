using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWPF.Model;

namespace TicTacToeWPF.BotDifficulty
{
    public static class MediumBot
    {
        private static readonly Random _random = new Random();
        private static int _row;
        private static int _col;

        public static (int row, int col) MakeMove(TTTBoard board, string symbol)
        {
            int row;
            int col;

            if (TryToWinOrBlock(board, symbol == "X" ? '1' : '0')
                || TryToWinOrBlock(board, symbol == "X" ? '0' : '1'))
            {
                row = _row;
                col = _col;

                return (row, col);
            }

            row = _random.Next(0, 3);
            col = _random.Next(0, 3);

            return (row,col);
        }

        private static bool TryToWinOrBlock(TTTBoard board, char symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Cells[i, j] != '1' && board.Cells[i, j] != '0')
                    {
                        board.Cells[i, j] = symbol;
                        if (board.CheckBoard())
                        {
                            board.Cells[i, j] = ' ';

                            _row = i;
                            _col = j;
                            return true;
                        }
                        board.Cells[i, j] = ' ';
                    }
                }
            }
            return false;
        }
    }
}
