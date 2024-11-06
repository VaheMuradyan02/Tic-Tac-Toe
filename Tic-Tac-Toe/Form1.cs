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

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form, ITTTBoardView
    {
        private TTTBoard _board = new TTTBoard();

        public event EventHandler CheckCellEvent;
        public event EventHandler ChooseFirstPlayerAsHumanEvent;
        public event EventHandler ChooseFirstPlayerAsBotEvent;
        public event EventHandler ChooseSecondPlayerAsHumanEvent;
        public event EventHandler ChooseSecondPlayerAsBotEvent;
        public event EventHandler ChooseStartGameEvent;
        public event EventHandler ChooseRestartGameEvent;

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
            CreateBoard();
            _ = new TTTBoardPresenter(this, buttons);
        }

        private void CreateBoard()
        {
            PictureBox pb1 = new PictureBox();
            pb1.Image = Image.FromFile("C:\\Users\\user\\OneDrive\\Pictures\\Desktop Backgrounds\\Image 24.jpg");
            pb1.Location = new Point(120, 50);
            pb1.Size = new Size(30, 30);
            this.Controls.Add(pb1);

            Label l1 = new Label();
            l1.Text = "Player1";
            l1.Location = new Point(150, 50);
            this.Controls.Add(l1);

            PictureBox pb2 = new PictureBox();
            pb2.Image = Image.FromFile("C:\\Users\\user\\OneDrive\\Pictures\\Desktop Backgrounds\\Image 24.jpg");
            pb2.Location = new Point(450, 50);
            pb2.Size = new Size(30, 30);
            this.Controls.Add(pb2);

            Label l2 = new Label();
            l2.Text = "Player2";
            l2.Location = new Point(410, 50);
            this.Controls.Add(l2);
        }

        private void Player1_Is_Human_Click(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Player;

            ChooseFirstPlayerAsHumanEvent?.Invoke(sender, e);
        }

        private void Player1_Is_Bot_Click(object sender, EventArgs e)
        {
            _board.Player1 = EPlayerType.Bot;

            ChooseFirstPlayerAsBotEvent?.Invoke(sender, e);
        }

        private void Player2_Is_Bot_Click(object sender, EventArgs e)
        {
            _board.Player2 = EPlayerType.Bot;

            ChooseSecondPlayerAsBotEvent?.Invoke(sender, e);
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

        private void Player_Click(object sender, EventArgs e)
        {
            CheckCellEvent?.Invoke(sender, e);
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            ChooseRestartGameEvent?.Invoke(sender, e);
        }
    }
}
