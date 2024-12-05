using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TicTacToeWPF.BotDifficulty;
using TicTacToeWPF.Model;
using TicTacToeWPF.View;

namespace TicTacToeWPF.Presenter
{
    public class TTTBoardPresenter
    {
        private ITTTView _view;
        private TTTBoard _board;
        private Image[,] _cages;
        private bool _endGame = false;

        public TTTBoardPresenter(ITTTView view, Image[,] cages, TTTBoard board)
        {
            _view = view;
            _board = board;
            _cages = cages;
            _view.CheckCellEvent += OnCheckCell;
            _view.StartGameEvent += OnStartGame;
            _view.RestartGameEvent += OnRestartGame;
            _view.HintEvent += HintPlayer;
            _view.Show();
        }

        private async void HintPlayer(object sender, EventArgs e)
        {
            int row;
            int col;

            if (_board.Player1Type == "Human")
            {
                (row, col) = HardBot.MakeMove(_board, "X");
            }
            else
            {
                (row, col) = HardBot.MakeMove(_board, "O");
            }

            var uriHint = new Uri("pack://application:,,,/TicTacToeWPF;component/Resources/Hint.png", UriKind.Absolute);
            _cages[row, col].Source = new BitmapImage(uriHint);

            await Task.Delay(500);

            var uri = new Uri("pack://application:,,,/TicTacToeWPF;component/Default.png", UriKind.Absolute);
            _cages[row, col].Source = new BitmapImage(uri);
        }

        private void OnRestartGame(object sender, EventArgs e)
        {
            _board.Reset_Board();
            _endGame = false;

            for (int i = 0; i < _cages.GetLength(0); i++)
            {
                for (int j = 0; j < _cages.GetLength(1); j++)
                {
                    var uri = new Uri("pack://application:,,,/TicTacToeWPF;component/Default.png", UriKind.Absolute);
                    _cages[i, j].Source = new BitmapImage(uri);
                    _cages[i, j].IsEnabled = true;
                }
            }
        }

        private void OnStartGame(object sender, CellCheckedEventArgs e)
        {
            _board.Initialize();
            _endGame = false;
            _board.Turn = true;

            if (_board.Player1Type != "Human")
            {
                MakeBotMove("X", _board.Player1Type, e.XImage);
            }
        }

        private void OnCheckCell(object sender, CellCheckedEventArgs e)
        {
            if (_endGame) return;

            var image = (Image)sender;

            //var row = Grid.GetRow(image); // Get the row of the clicked cell
            //var col = Grid.GetColumn(image); // Get the column of the clicked cell

            int rowIndex = image.Name.Length - 2;
            int row = int.Parse(image.Name[rowIndex].ToString());//?

            int colIndex = image.Name.Length - 1;
            int col = image.Name[colIndex] - '0';//?

            if (_board.Turn)
            {
                PlayerMove(row, col, "X", '1', e.XImage);

                if (_board.Player2Type != "Human")
                {
                    MakeBotMove("O", _board.Player2Type, e.OImage);
                }
            }
            else
            {
                if (_board.Player2Type != "Human")
                {
                    MakeBotMove("O", _board.Player2Type, e.OImage);
                }
                else
                {
                    PlayerMove(row, col, "O", '0', e.OImage);
                }

                if (_board.Player1Type != "Human")
                {
                    MakeBotMove("X", _board.Player1Type, e.XImage);
                }
            }
        }

        private void PlayerMove(int row, int col, string symbol, char cellValue, ImageSource cageImage)
        {
            _cages[row, col].Source = cageImage;
            _cages[row, col].IsEnabled = false;
            _board.Cells[row, col] = cellValue;
            _board.Turn = !_board.Turn;
            _board.CountOfCells++;


            if (_board.CountOfCells >= 5)
            {
                if (_board.CheckBoard())
                {
                    MessageBox.Show($"Win  - {symbol}");
                    SetCagesEnabled(false);
                    _endGame = true;
                }
                if (IsBoardFull(_board) && !_board.CheckBoard())
                {
                    MessageBox.Show("The Game is Draw.");
                    SetCagesEnabled(false);
                    _endGame = true;
                }
            }
        }

        private void MakeBotMove(string symbol, string player, ImageSource cageImage)
        {
            if (_endGame) return;

            int row;
            int col;

            if (player == "BotEasy")
            {
                (row, col) = EasyBot.MakeMove(_board.Cells);
            }
            else if (player == "BotMedium")
            {
                (row, col) = MediumBot.MakeMove(_board, symbol);
            }
            else
            {
                (row, col) = HardBot.MakeMove(_board, symbol);
            }

            if (_board.Cells[row, col] != '1' && _board.Cells[row, col] != '0')
            {
                char cell = symbol == "X" ? '1' : '0';
                PlayerMove(row, col, symbol, cell, cageImage);
            }
        }

        private void SetCagesEnabled(bool enabled)
        {
            for (int i = 0; i < _cages.GetLength(0); i++)
            {
                for (int j = 0; j < _cages.GetLength(1); j++)
                {
                    _cages[i, j].IsEnabled = enabled;
                }
            }
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
