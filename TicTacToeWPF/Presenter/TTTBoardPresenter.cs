using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private string _player1Type;
        private string _player2Type;
        private bool _endGame = false;

        public TTTBoardPresenter(ITTTView view, string player1, string player2)
        {
            _view = view;
            _board = new TTTBoard();
            _player1Type = player1;
            _player2Type = player2;
            _view.CheckCellEvent += OnCheckCell;
            _view.StartGameEvent += OnStartGame;
            _view.Show();
        }

        private void OnStartGame(object sender, EventArgs e)
        {
            _board.Initialize();

            if (_player1Type != "Human")
            {
                _board.Turn = false;
                MakeBotMove("X", _player1Type);
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
                //_view.UpdateStatus("X is playing...");

                //await DisableButtonsTemporarily(500);

                PlayerMove(row, col, "X", '1');
                image.Source = e.XImage;
                //_view.UpdateStatus("X edned.");

                //if (_endGame) return;

                //await DisableButtonsTemporarily(500);

               // _view.UpdateStatus("O is playing...");

                //await DisableButtonsTemporarily(1000);

                if (_player2Type != "Human")
                {
                    MakeBotMove("O", _player2Type);
                }

                //_view.UpdateStatus("O ended.");
            }
            else
            {
                //_view.UpdateStatus("O is playing...");

                //await DisableButtonsTemporarily(500);

                if (_player2Type != "Human")
                {
                    MakeBotMove("O", _player2Type);
                }
                else
                {
                    PlayerMove(row, col, "O", '0');
                }

                //_view.UpdateStatus("O ended.");

                //if (_endGame) return;

                //await DisableButtonsTemporarily(500);

                //_view.UpdateStatus("X is playing...");

                //await DisableButtonsTemporarily(500);

                if (_player1Type != "Human")
                {
                    MakeBotMove("X", _player1Type);
                }

                //_view.UpdateStatus("X ended.");
            }
        }

        private void PlayerMove(int row, int col, string symbol, char cellValue)
        {
            //var button = _buttons[row, col];
            //button.Text = symbol;
            //button.BackColor = color;
            //button.Enabled = false;
            _board.Cells[row, col] = cellValue;
            _board.Turn = !_board.Turn;
            _board.CountOfCells++;
            

            if (_board.CountOfCells >= 5)
            {
                if (_board.CheckBoard())
                {
                    MessageBox.Show($"Win  - {symbol}");
                    _endGame = true;
                }
                if (IsBoardFull(_board) && !_board.CheckBoard())
                {
                    MessageBox.Show("The Game is Draw.");
                    _endGame = true;
                }
            }
        }

        private void MakeBotMove(string symbol, string player)
        {
            if (_endGame) return;

            int row;
            int col;

            while (true)
            {
                if (player == "BotEasy")
                {
                   (row,col) = EasyBot.MakeMove(_board.Cells);
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
                    PlayerMove(row, col, symbol, cell);
                    break;
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
