using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Model;
using Tic_Tac_Toe.View;


namespace Tic_Tac_Toe.Presenter
{
    internal class TTTBoardPresenter
    {
        private ITTTBoardView _view;
        private TTTBoard _board;

        Random random = new Random();
        Button[,] Buttons;

        public TTTBoardPresenter(ITTTBoardView view, Button[,] buttons)
        {
            _view = view;
            _board = new TTTBoard();
            Buttons = buttons;
            _view.CheckCellEvent += OnCheckCell;
            _view.ChooseFirstPlayerAsHumanEvent += OnChooseFirstPlayerAsHuman;
            _view.ChooseFirstPlayerAsBotEvent += OnChooseFirstPlayerAsBot;
            _view.ChooseSecondPlayerAsHumanEvent += OnChooseSecondPlayerAsHuman;
            _view.ChooseSecondPlayerAsBotEvent += OnChooseSecondPlayerAsBot;
            _view.ChooseStartGameEvent += OnChooseStartGame;
            _view.ChooseRestartGameEvent += OnChooseRestartGame;
        }

        private void OnChooseRestartGame(object sender, EventArgs e)
        {
            _board.ResetBoard();

            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    Buttons[i, j].Text = " ";
                }
            }
        }

        private void OnChooseStartGame(object sender, EventArgs e)
        {
            _board.InitializeBoard();

            if (_board.Player1 == EPlayerType.Bot)
            {
                int row = random.Next(0, 3);
                int col = random.Next(0, 3);
                var button = Buttons[row, col];

                _board.Cells[row, col] = '1';
                button.Text = "X";
                button.BackColor = Color.Green;
                button.Enabled = false;
                _board.Turn = false;
                _board.CountOfAddCells++;
            }
        }

        private void OnChooseSecondPlayerAsBot(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Bot;
        }

        private void OnChooseSecondPlayerAsHuman(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Player;
        }

        private void OnChooseFirstPlayerAsBot(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Bot;
        }

        private void OnChooseFirstPlayerAsHuman(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Player;
        }

        private void OnCheckCell(object sender, EventArgs e)
        {
            var button = sender as Button;

            
            int rowIndex = button.Name.Length - 2;
            int row = int.Parse(button.Name[rowIndex].ToString());//?

            int colIndex = button.Name.Length - 1;
            int col = button.Name[colIndex] - '0';//?

            if (_board.Turn)
            {
                button.BackColor = Color.Green;
                button.Text = "X";
                button.Enabled = false;
                _board.Turn = false;
                _board.Cells[row, col] = '1';
                _board.CountOfAddCells++;

                if (_board.CountOfAddCells >= 5) 
                {
                    _board.CheckBoard();
                }

                if (_board.Player2 == EPlayerType.Bot)
                {
                    while (true)
                    {
                        row = random.Next(0, 3);
                        col = random.Next(0, 3);

                        var cell = _board.Cells[row, col];

                        if (cell != '1' && cell != '0')
                        {
                            var nextButton = Buttons[row, col];

                            _board.Cells[row, col] = cell;
                            nextButton.Text = "O";
                            nextButton.BackColor = Color.Yellow;
                            nextButton.Enabled = false;
                            _board.Turn = true;
                            _board.CountOfAddCells++;

                            if (_board.CountOfAddCells >= 5)
                            {
                                _board.CheckBoard();
                            }

                            break;
                        }
                    }
                }
            }
            else
            {
                button.BackColor = Color.Yellow;
                button.Text = "O";
                _board.Cells[row, col] = '0';
                button.Enabled = false;
                _board.Turn = true;
                _board.CountOfAddCells++;

                if (_board.CountOfAddCells >= 5)
                {
                    _board.CheckBoard();
                }

                if (_board.Player1 == EPlayerType.Bot)
                {
                    while (true)
                    {
                        row = random.Next(0, 3);
                        col = random.Next(0, 3);

                        var cell = _board.Cells[row, col];

                        if (cell != '1' && cell != '0')
                        {
                            var nextButton = Buttons[row, col];

                            _board.Cells[row, col] = cell;
                            nextButton.Text = "X";
                            nextButton.BackColor = Color.Green;
                            nextButton.Enabled = false;
                            _board.Turn = false;
                            _board.CountOfAddCells++;

                            if (_board.CountOfAddCells >= 5)
                            {
                                _board.CheckBoard();
                            }

                            break;
                        }
                    }
                }
            }
        }
    }
}
