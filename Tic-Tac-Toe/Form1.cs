using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Tic_Tac_Toe.Model;
using Tic_Tac_Toe.View;
using Tic_Tac_Toe.Presenter;
using System.Security.Policy;
using System.Reflection;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form, ITTTBoardView
    {
        private TTTBoard _board = new TTTBoard();
        private FormForChangeNameOfPlayer1 _changePlayer1Name = new FormForChangeNameOfPlayer1();
        private FormForChangeNameOfPlayer2 _changePlayer2Name = new FormForChangeNameOfPlayer2();
        private FormForBackColor _checkedBox = new FormForBackColor();

        public event EventHandler CheckCellEvent;
        public event EventHandler ChooseFirstPlayerAsHumanEvent;
        public event EventHandler ChooseFirstPlayerAsBotEvent;
        public event EventHandler ChooseSecondPlayerAsHumanEvent;
        public event EventHandler ChooseSecondPlayerAsBotEvent;
        public event EventHandler ChooseStartGameEvent;
        public event EventHandler ChooseRestartGameEvent;
        public event EventHandler ChooseBotEasyEvent;
        public event EventHandler ChooseBotMediumEvent;
        public event EventHandler ChooseBotHardEvent;

        public Form1()
        {
            InitializeComponent();
            ChooseRestartGameEvent?.Invoke(this, EventArgs.Empty);

            var buttons = new Button[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    string buttonName = $"button{i}{j}";
                    var button = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                    buttons[i,j] = button;
                }
            }

            _board.InitializeBoard();
            AploadImage();
            _ = new TTTBoardPresenter(this, buttons);

            menuToolStripMenuItem.Click += new EventHandler(menuToolStripMenuItem_Click);
        }

        private void AploadImage()
        {
            pictureBox1.Image = Properties.Resources.Player1_Image1;
            pictureBox2.Image = Properties.Resources.Player2_Image1;
        }

        private void Player1_Is_Human_Click(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Player;

            ChooseFirstPlayerAsHumanEvent?.Invoke(sender, e);
        }

        private void Player1_Is_Bot_Click(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Bot;

            if (botToolStripMenuItem.Enabled)
                botToolStripMenuItem.DropDown.Show(menuStrip1, new Point(0, 0));

            ChooseFirstPlayerAsBotEvent?.Invoke(sender, e);
        }

        private void Player2_Is_Bot_Click(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Bot;

            if (botToolStripMenuItem.Enabled)
                botToolStripMenuItem.DropDown.Show(menuStrip1, new Point(0, 0));

            ChooseSecondPlayerAsBotEvent?.Invoke(sender, e);
        }

        private void Player2_Is_BotEasy_Click(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Easy;

            ChooseBotEasyEvent?.Invoke(sender, e);
        }

        private void Player2_Is_BotMedium_Click(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Medium;

            ChooseBotMediumEvent?.Invoke(sender, e);
        }

        private void Player2_Is_BotHard_Click(object sender, EventArgs e)
        {
            _board.Difficulty = BotDifficulty.Hard;

            ChooseBotHardEvent?.Invoke(sender, e);
        }

        private void Player2_Is_Human_Click(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Player;

            ChooseSecondPlayerAsHumanEvent?.Invoke(sender, e);
        }

        private void StartGame(object sender, EventArgs e)
        {
            ChooseRestartGameEvent?.Invoke(sender, e);

            label1.Text = "Player1 - " + _board.Player1.ToString();
            label2.Text = "Player2 - " + _board.Player2.ToString();

            ChooseStartGameEvent?.Invoke(sender, e);
        }

        public void UpdateStatus(string status)
        {
            StatusGame.Text = status;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            CheckCellEvent?.Invoke(sender, e);
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {

            ChooseRestartGameEvent?.Invoke(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormForBackColor dialog = new FormForBackColor();
            _checkedBox.Owner = this;
            //_CheckedBox.Parent = this;
            _checkedBox.ShowDialog();
        }
        private void ChangeNameOfPlayer1_Click(object sender, EventArgs e)
        {
            _changePlayer1Name.ShowDialog();
        }

        private void ChangeNameOfPlayer2_Click(object sender, EventArgs e)
        {
            _changePlayer2Name.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
