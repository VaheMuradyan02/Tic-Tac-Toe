using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Model;
using Tic_Tac_Toe.View;


namespace Tic_Tac_Toe.Presenter
{
    /*internal class TTTBoardPresenter
    {
        private ITTTBoardView _view;
        private TTTBoard _board;

        private Random random = new Random();
        private Button[,] Buttons;
        private bool _endGame = false;

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
            _endGame = false;

            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    Buttons[i, j].Text = " ";
                    Buttons[i, j].Enabled = true;
                    Buttons[i, j].BackColor = Color.White;
                }
            }

            _board.Turn = true;
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

                _board.Turn = true;
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

            if (_board.Turn && !_endGame)
            {
                button.BackColor = Color.Green;
                button.Text = "X";
                button.Enabled = false;
                _board.Turn = false;
                _board.Cells[row, col] = '1';
                _board.CountOfAddCells++;

                if (_board.CountOfAddCells >= 5)
                {
                    if (_board.CheckBoard())
                    {
                        ButtonsMakeNonEnabled();
                        _endGame = true;
                    }
                }

                if (_board.Player2 == EPlayerType.Bot && !_endGame)
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
                            _board.Cells[row, col] = '0';
                            _board.CountOfAddCells++;

                            if (_board.CountOfAddCells >= 5)
                            {
                                if (_board.CheckBoard())
                                {
                                    ButtonsMakeNonEnabled();
                                    _endGame = true;
                                }
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
                    if (_board.CheckBoard())
                    {
                        ButtonsMakeNonEnabled();
                        _endGame = true;
                    }
                }

                if (_board.Player1 == EPlayerType.Bot && !_endGame)
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
                            _board.Cells[row, col] = '1';
                            _board.CountOfAddCells++;

                            if (_board.CountOfAddCells >= 5)
                            {
                                if (_board.CheckBoard())
                                {
                                    ButtonsMakeNonEnabled();
                                    _endGame = true;
                                }
                            }

                            break;
                        }
                    }
                }
            }
        }

        private void ButtonsMakeNonEnabled()
        {
            for (int i = 0; i < Buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Buttons.GetLength(1); j++)
                {
                    Buttons[i, j].Enabled = false;
                }
            }
        }
    }*/

    internal class TTTBoardPresenter
    {
        private ITTTBoardView _view;
        private TTTBoard _board;
        private Difficulty _difficulty;

        private Random _random = new Random();
        private Button[,] _buttons;
        private List<Button> _excludeButtons = new List<Button>();
        private bool _endGame = false;

        public TTTBoardPresenter(ITTTBoardView view, Button[,] buttons)
        {
            _view = view;
            _board = new TTTBoard();
            _difficulty = new Difficulty();
            _buttons = buttons;
            _view.CheckCellEvent += OnCheckCell;
            _view.ChooseFirstPlayerAsHumanEvent += OnChooseFirstPlayerAsHuman;
            _view.ChooseFirstPlayerAsBotEvent += OnChooseFirstPlayerAsBot;
            _view.ChooseSecondPlayerAsHumanEvent += OnChooseSecondPlayerAsHuman;
            _view.ChooseSecondPlayerAsBotEvent += OnChooseSecondPlayerAsBot;
            _view.ChooseStartGameEvent += OnChooseStartGame;
            _view.ChooseRestartGameEvent += OnChooseRestartGame;
            _view.ChooseBotEasyEvent += OnChooseBotEasy;
            _view.ChooseBotMediumEvent += OnChooseBotMedium;
            _view.ChooseBotHardEvent += OnChooseBotHard;
        }

        private void OnChooseBotHard(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Hard;
            _view.UpdateStatus("Bot is Hard");
        }

        private void OnChooseBotMedium(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Medium;
            _view.UpdateStatus("Bot is Medium");
        }

        private void OnChooseBotEasy(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Easy;
            _view.UpdateStatus("Bot is Easy");
        }

        private void OnChooseRestartGame(object sender, EventArgs e)
        {
            _board.ResetBoard();
            _view.UpdateStatus("Game is Restarted");

            _endGame = false;

            for (int i = 0; i < _buttons.GetLength(0); i++)
            {
                for (int j = 0; j < _buttons.GetLength(1); j++)
                {
                    _buttons[i, j].Text = " ";
                    _buttons[i, j].Enabled = true;
                    _buttons[i, j].BackColor = Color.White;
                }
            }

            _board.Turn = true;
        }

        private void OnChooseStartGame(object sender, EventArgs e)
        {

            _board.InitializeBoard();
            _view.UpdateStatus("Game is Started");

            if (_board.Player1 == EPlayerType.Bot)
            {
                _view.UpdateStatus("X is playing...");
                _board.Turn = true;
                MakeBotMove("X", Color.Green);
                _view.UpdateStatus("X ended.");
            }

        }

        private void OnChooseFirstPlayerAsHuman(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Player;
            _view.UpdateStatus("Player1 is Human");
        }

        private void OnChooseSecondPlayerAsHuman(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Player;
            _view.UpdateStatus("Player2 is Human");
        }

        private void OnChooseFirstPlayerAsBot(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Bot;
            _view.UpdateStatus("Player1 is Bot");
        }

        private void OnChooseSecondPlayerAsBot(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Bot;
            _view.UpdateStatus("Player2 is Bot");
        }

        private async void OnCheckCell(object sender, EventArgs e)
        {
            if (_endGame) return;

            var button = sender as Button;

            int rowIndex = button.Name.Length - 2;
            int row = int.Parse(button.Name[rowIndex].ToString());//?

            int colIndex = button.Name.Length - 1;
            int col = button.Name[colIndex] - '0';//?

            if (_board.Turn)
            {
                _view.UpdateStatus("X is playing...");

                await DisableButtonsTemporarily(500);

                PlayerMove(row, col, "X", Color.Green, '1');
                _view.UpdateStatus("X edned.");

                if (_endGame) return;

                await DisableButtonsTemporarily(500);

                _view.UpdateStatus("O is playing...");

                await DisableButtonsTemporarily(1000);

                if (_board.Player2 == EPlayerType.Bot)
                {
                    MakeBotMove("O", Color.Yellow);
                }

                _view.UpdateStatus("O ended.");
            }
            else
            {
                _view.UpdateStatus("O is playing...");

                await DisableButtonsTemporarily(500);

                if (_board.Player2 == EPlayerType.Bot) 
                {
                    MakeBotMove("O", Color.Yellow);
                }
                else 
                {
                    PlayerMove(row, col, "O", Color.Yellow, '0'); 
                }

                _view.UpdateStatus("O ended.");

                if (_endGame) return;

                await DisableButtonsTemporarily(500);

                _view.UpdateStatus("X is playing...");

                await DisableButtonsTemporarily(500);

                if (_board.Player1 == EPlayerType.Bot) MakeBotMove("X", Color.Green);

                _view.UpdateStatus("X ended.");
            }
        }

        private void PlayerMove(int row, int col, string symbol, Color color, char cellValue)
        {
            var button = _buttons[row, col];
            button.Text = symbol;
            button.BackColor = color;
            button.Enabled = false;
            _board.Cells[row, col] = cellValue;
            _board.Turn = !_board.Turn;
            _board.CountOfAddCells++;

            _excludeButtons.Add(button);

            if (_board.CountOfAddCells >= 5)
            {
                if (_board.CheckBoard())
                {
                    MessageBox.Show($"Win  - {symbol}");
                    SetButtonsEnabled(false);
                    _endGame = true;
                }
                if (IsBoardFull(_board) && !_board.CheckBoard())
                {
                    MessageBox.Show("The Game is Draw.");
                    SetButtonsEnabled(false);
                    _endGame = true;
                }
            }
        }

        private void MakeBotMove(string symbol, Color color)
        {
            if (_endGame) return;

            int row;
            int col;

            while (true)
            {
                if (_board.Difficulty == BotDifficulty.Easy)
                {
                    row = _random.Next(0, 3);
                    col = _random.Next(0, 3);
                }
                else if (_board.Difficulty == BotDifficulty.Medium)
                {
                    int[] newPosition = _difficulty.MakeMoveMedium(_board, symbol);
                    row = newPosition[0];
                    col = newPosition[1];
                }
                else
                {
                    int[] newPosition = _difficulty.MakeMoveHard(_board, symbol);
                    row = newPosition[0];
                    col = newPosition[1];
                }

                if (_board.Cells[row, col] != '1' && _board.Cells[row, col] != '0')
                {
                    PlayerMove(row, col, symbol, color, symbol == "X" ? '1' : '0');
                    break;
                }
            }
        }

        private void SetButtonsEnabled(bool enabled)
        {
            for (int i = 0; i < _buttons.GetLength(0); i++)
            {
                for (int j = 0; j < _buttons.GetLength(1); j++)
                {
                    _buttons[i, j].Enabled = enabled;
                }
            }
        }

        private void SetButtonsEnabled(Button[,] buttons, bool enabled, List<Button> excludeButtons)
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if (excludeButtons == null || !excludeButtons.Contains(buttons[i, j]))
                    {
                        buttons[i, j].Enabled = enabled;
                    }
                }
            }
        }

        private async Task DisableButtonsTemporarily(int delayMilliseconds)
        {
            SetButtonsEnabled(_buttons, false, _excludeButtons);
            await Task.Delay(delayMilliseconds);
            SetButtonsEnabled(_buttons, true, _excludeButtons);
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
