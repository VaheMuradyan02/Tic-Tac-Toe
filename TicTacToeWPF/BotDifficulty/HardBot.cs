using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWPF.Model;

namespace TicTacToeWPF.BotDifficulty
{
    public static class HardBot
    {
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

                return (row,col);
            }

            int bestScore = int.MinValue;
            int bestRow = -1;
            int bestCol = -1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Cells[i, j] != '1' && board.Cells[i, j] != '0')
                    {
                        char symbolBot = symbol == "X" ? '1' : '0';
                        board.Cells[i, j] = symbolBot;
                        int score = Minimax(board, 0, false, int.MinValue, int.MaxValue, symbolBot);
                        board.Cells[i, j] = ' ';

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestRow = i;
                            bestCol = j;
                        }
                    }
                }
            }

            row = bestRow;
            col = bestCol;

            return (row, col);

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

        private static int Minimax(TTTBoard board, int depth, bool isMaximizing, int alpha, int beta, char symbolBot)
        {
            if (board.CheckBoard())
                return isMaximizing ? -10 + depth : 10 - depth;

            if (IsBoardFull(board)) return 0;

            int bestScore = isMaximizing ? int.MinValue : int.MaxValue;
            char symbolPlayer = symbolBot == '1' ? '0' : '1';
            char symbol = isMaximizing ? symbolBot : symbolPlayer;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Cells[i, j] != '1' && board.Cells[i, j] != '0')
                    {
                        board.Cells[i, j] = symbol;
                        int score = Minimax(board, depth + 1, !isMaximizing, alpha, beta, symbolBot);
                        board.Cells[i, j] = ' ';

                        if (isMaximizing)
                        {
                            bestScore = Math.Max(score, bestScore);
                            alpha = Math.Max(alpha, score);
                        }
                        else
                        {
                            bestScore = Math.Min(score, bestScore);
                            beta = Math.Min(beta, score);
                        }

                        if (beta <= alpha) break;
                    }
                }
            }
            return bestScore;
        }

        private static bool IsBoardFull(TTTBoard board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Cells[i, j] == ' ') return false;
                }
            }
            return true;
        }
    }

}
