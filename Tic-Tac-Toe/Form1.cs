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

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {        
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        List<Button> buttonsPvP;
        List<Button> buttonsPvPCEasy;
        List<Button> buttonsPCvPC;

        TTTBoard board = new TTTBoard();

        bool isVisited = true;

        Button[,] boardButtons = new Button[3,3];

        public Form1()
        {
            InitializeComponent();
            board.InitializeBoard();
            CreateBoard();
            


            //newB.Click += new System.EventHandler(DoMessage());
            //this.Controls.Add(newB );
            //RestartGamePvP();
            //RestartGamePCvPEasy();
            //RestartGamePCvPC();
        }

        private void CreateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardButtons[i, j] = new Button();
                    boardButtons[i, j].BackColor = Color.White;
                    boardButtons[i, j].Name = i.ToString() + j.ToString();
                    boardButtons[i, j].Text = "-";
                    boardButtons[i, j].Parent = this;
                    boardButtons[i, j].SetBounds(i * 100 + 150, j * 100 + 80, 100, 100);

                    int row = i;
                    int col = j;

                    boardButtons[row, col].Click += (object sender, EventArgs e) =>
                    {
                        var button = (Button)sender;

                        if (board.Turn)
                        {
                            button.BackColor = Color.Green;
                            button.Text = "X";
                            button.Enabled = false;
                            board.Turn = false;
                            board.cells[row, col] = '1';
                            board.countOfAddCells++;

                            if (board.countOfAddCells >= 5 && board.CheckBoard())
                            {
                                board.ResetBoard();
                            }


                            if (board.Player2 == EPlayerType.Bot)
                            {                                
                                while (true)
                                {
                                    row = random.Next(0, 3);
                                    col = random.Next(0, 3);
                                    board.LogicH(board.Player2, row, col);

                                    var cell = boardButtons[row, col];
                                    if (cell.Text != "X" && cell.Text != "O")
                                    {
                                        boardButtons[row, col].Text = "O";
                                        board.cells[row, col] = '0';
                                        boardButtons[row, col].BackColor = Color.Yellow;
                                        boardButtons[row, col].Enabled = false;
                                        board.Turn = true;
                                        board.countOfAddCells++;

                                        if (board.countOfAddCells >= 5 && board.CheckBoard())
                                        {
                                            board.ResetBoard();
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
                            board.cells[row, col] = '0';
                            button.Enabled = false;
                            board.Turn = true;
                            board.LogicH(board.Player2, row, col);
                            board.countOfAddCells++;

                            if (board.countOfAddCells >= 5 && board.CheckBoard())
                            {
                                board.ResetBoard();
                            }

                            if (board.Player1 == EPlayerType.Bot)
                            {
                                while (true)
                                {
                                    row = random.Next(0, 3);
                                    col = random.Next(0, 3);
                                    board.LogicH(board.Player1, row, col);


                                    var cell = boardButtons[row, col];
                                    if (cell.Text != "X" && cell.Text != "O")
                                    {
                                        boardButtons[row, col].Text = "X";
                                        board.cells[row, col] = '1';
                                        boardButtons[row, col].BackColor = Color.Green;
                                        boardButtons[row, col].Enabled = false;
                                        board.Turn = false;
                                        board.countOfAddCells++;

                                        if (board.countOfAddCells >= 5 && board.CheckBoard())
                                        {
                                            board.ResetBoard();
                                        }
                                        break;
                                    }
                                }
                            }
                        }


                        //Human.PlayerClick(sender);


                        //you can use your variables inside event
                        //MessageBox.Show("dt fjfgf");
                    };
                }
            }

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
            board.Player1 = EPlayerType.Player;
        }

        private void Player1_Is_Bot_Click(object sender, EventArgs e)
        {
            board.Player1 = EPlayerType.Bot;
        }

        private void Player2_Is_Bot_Click(object sender, EventArgs e)
        {
            board.Player2 = EPlayerType.Bot;
        }

        private void Player2_Is_Human_Click(object sender, EventArgs e)
        {
            board.Player2 = EPlayerType.Player;
        }

        private void StartGame(object sender, EventArgs e)
        {
            board.InitializeBoard();  
            label1.Text = "Player1 - " + board.Player1.ToString();
            label2.Text = "Player2 - " + board.Player2.ToString();

            if (board.Player1 == EPlayerType.Bot)
            {
                int row = random.Next(0, 3);
                int col = random.Next(0, 3);
                board.LogicH(board.Player1, row, col);

                boardButtons[row, col].Text = "X";
                board.cells[row, col] = '1';
                boardButtons[row, col].BackColor = Color.Green;
                boardButtons[row, col].Enabled = false;
                board.countOfAddCells++;

                board.Turn = false;
            }
        }
    }
}
