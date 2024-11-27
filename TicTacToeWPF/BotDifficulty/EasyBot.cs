using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWPF.BotDifficulty
{
    public static class EasyBot
    {
        public static (int Row, int Col) MakeMove(char[,] board)
        {
            var random = new Random();
            int row, col;

            while (true)
            {
                row = random.Next(0, 3);
                col = random.Next(0, 3);

                if (board[row, col] == ' ')
                {
                    return (row, col); 
                }
            }
        }
    }
}
