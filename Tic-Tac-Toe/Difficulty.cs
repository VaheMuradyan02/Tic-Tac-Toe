﻿using System;
using Tic_Tac_Toe.Model;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public enum BotDifficulty
    {
        Easy,
        Medium,
        Hard
    }

    public class Difficulty
    {

        private readonly Random _random = new Random();
        private int _row;
        private int _col;

        public int[] MakeMoveMedium(TTTBoard board, string symbol)
        {
            int[] rowAndCol = new int[2];

            if (TryToWinOrBlock(board, symbol == "X" ? '1' : '0')
                || TryToWinOrBlock(board, symbol == "X" ? '0' : '1'))
            {
                rowAndCol[0] = _row;
                rowAndCol[1] = _col;

                return rowAndCol;
            }

            rowAndCol[0] = _random.Next(0, 3);
            rowAndCol[1] = _random.Next(0, 3);

            return rowAndCol;
        }

        public int[] MakeMoveHard(TTTBoard board, string symbol)
        {
            int[] rowAndCol = new int[2];

            if (TryToWinOrBlock(board, symbol == "X" ? '1' : '0')
                || TryToWinOrBlock(board, symbol == "X" ? '0' : '1'))
            {
                rowAndCol[0] = _row;
                rowAndCol[1] = _col;

                return rowAndCol;
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

            rowAndCol[0] = bestRow;
            rowAndCol[1] = bestCol;
            return rowAndCol;

        }

        private bool TryToWinOrBlock(TTTBoard board, char symbol)
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

        private int Minimax(TTTBoard board, int depth, bool isMaximizing, int alpha, int beta, char symbolBot)
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

        private bool IsBoardFull(TTTBoard board)
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
