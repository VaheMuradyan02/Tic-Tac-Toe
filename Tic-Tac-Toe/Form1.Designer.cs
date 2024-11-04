using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.botToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerSignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.hintToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1ToolStripMenuItem,
            this.player2ToolStripMenuItem,
            this.startGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // player1ToolStripMenuItem
            // 
            this.player1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCToolStripMenuItem,
            this.humanToolStripMenuItem});
            this.player1ToolStripMenuItem.Name = "player1ToolStripMenuItem";
            this.player1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.player1ToolStripMenuItem.Text = "Player1";
            // 
            // pCToolStripMenuItem
            // 
            this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
            this.pCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pCToolStripMenuItem.Text = "PC";
            this.pCToolStripMenuItem.Click += new System.EventHandler(this.Player1_Is_Bot_Click);
            // 
            // humanToolStripMenuItem
            // 
            this.humanToolStripMenuItem.Name = "humanToolStripMenuItem";
            this.humanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.humanToolStripMenuItem.Text = "Human";
            this.humanToolStripMenuItem.Click += new System.EventHandler(this.Player1_Is_Human_Click);
            // 
            // player2ToolStripMenuItem
            // 
            this.player2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanToolStripMenuItem1,
            this.botToolStripMenuItem});
            this.player2ToolStripMenuItem.Name = "player2ToolStripMenuItem";
            this.player2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.player2ToolStripMenuItem.Text = "Player 2";
            // 
            // humanToolStripMenuItem1
            // 
            this.humanToolStripMenuItem1.Name = "humanToolStripMenuItem1";
            this.humanToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.humanToolStripMenuItem1.Text = "Human";
            this.humanToolStripMenuItem1.Click += new System.EventHandler(this.Player2_Is_Human_Click);
            // 
            // botToolStripMenuItem
            // 
            this.botToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.botToolStripMenuItem.Name = "botToolStripMenuItem";
            this.botToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.botToolStripMenuItem.Text = "Bot";
            this.botToolStripMenuItem.Click += new System.EventHandler(this.Player2_Is_Bot_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startGameToolStripMenuItem.Text = "Start game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.StartGame);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.player1NameToolStripMenuItem,
            this.boardSizeToolStripMenuItem,
            this.player2NameToolStripMenuItem,
            this.playerSignToolStripMenuItem,
            this.gameModToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // player1NameToolStripMenuItem
            // 
            this.player1NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1ToolStripMenuItem1,
            this.changeToolStripMenuItem});
            this.player1NameToolStripMenuItem.Name = "player1NameToolStripMenuItem";
            this.player1NameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.player1NameToolStripMenuItem.Text = "Player 1 name";
            // 
            // player1ToolStripMenuItem1
            // 
            this.player1ToolStripMenuItem1.Name = "player1ToolStripMenuItem1";
            this.player1ToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.player1ToolStripMenuItem1.Text = "Player1";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // boardSizeToolStripMenuItem
            // 
            this.boardSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.boardSizeToolStripMenuItem.Name = "boardSizeToolStripMenuItem";
            this.boardSizeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.boardSizeToolStripMenuItem.Text = "Board size";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.x3ToolStripMenuItem.Text = "3x3";
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.bigToolStripMenuItem.Text = "Big";
            // 
            // player2NameToolStripMenuItem
            // 
            this.player2NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player2ToolStripMenuItem1,
            this.changeToolStripMenuItem1});
            this.player2NameToolStripMenuItem.Name = "player2NameToolStripMenuItem";
            this.player2NameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.player2NameToolStripMenuItem.Text = "Player 2 name";
            // 
            // player2ToolStripMenuItem1
            // 
            this.player2ToolStripMenuItem1.Name = "player2ToolStripMenuItem1";
            this.player2ToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.player2ToolStripMenuItem1.Text = "Player2";
            // 
            // changeToolStripMenuItem1
            // 
            this.changeToolStripMenuItem1.Name = "changeToolStripMenuItem1";
            this.changeToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.changeToolStripMenuItem1.Text = "Change";
            // 
            // playerSignToolStripMenuItem
            // 
            this.playerSignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1});
            this.playerSignToolStripMenuItem.Name = "playerSignToolStripMenuItem";
            this.playerSignToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.playerSignToolStripMenuItem.Text = "Player sign";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem2});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(128, 26);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // changeToolStripMenuItem2
            // 
            this.changeToolStripMenuItem2.Name = "changeToolStripMenuItem2";
            this.changeToolStripMenuItem2.Size = new System.Drawing.Size(142, 26);
            this.changeToolStripMenuItem2.Text = "Change";
            // 
            // gameModToolStripMenuItem
            // 
            this.gameModToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicToolStripMenuItem,
            this.dropMoveToolStripMenuItem,
            this.blindToolStripMenuItem});
            this.gameModToolStripMenuItem.Name = "gameModToolStripMenuItem";
            this.gameModToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.gameModToolStripMenuItem.Text = "Game mod";
            // 
            // classicToolStripMenuItem
            // 
            this.classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            this.classicToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.classicToolStripMenuItem.Text = "&Classic";
            // 
            // dropMoveToolStripMenuItem
            // 
            this.dropMoveToolStripMenuItem.Name = "dropMoveToolStripMenuItem";
            this.dropMoveToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.dropMoveToolStripMenuItem.Text = "Drop move";
            // 
            // blindToolStripMenuItem
            // 
            this.blindToolStripMenuItem.Name = "blindToolStripMenuItem";
            this.blindToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.blindToolStripMenuItem.Text = "Blind";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.onToolStripMenuItem.Text = "On";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.offToolStripMenuItem.Text = "Off";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.hintToolStripMenuItem.Text = "Hint";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(859, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem hintToolStripMenuItem;
        private ToolStripMenuItem player1ToolStripMenuItem;
        private ToolStripMenuItem pCToolStripMenuItem;
        private ToolStripMenuItem humanToolStripMenuItem;
        private ToolStripMenuItem player2ToolStripMenuItem;
        private ToolStripMenuItem humanToolStripMenuItem1;
        private ToolStripMenuItem botToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem player1NameToolStripMenuItem;
        private ToolStripMenuItem boardSizeToolStripMenuItem;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem bigToolStripMenuItem;
        private ToolStripMenuItem versionToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem player2NameToolStripMenuItem;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem player1ToolStripMenuItem1;
        private ToolStripMenuItem changeToolStripMenuItem;
        private ToolStripMenuItem player2ToolStripMenuItem1;
        private ToolStripMenuItem changeToolStripMenuItem1;
        private ToolStripMenuItem playerSignToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem1;
        private ToolStripMenuItem changeToolStripMenuItem2;
        private ToolStripMenuItem gameModToolStripMenuItem;
        private ToolStripMenuItem classicToolStripMenuItem;
        private ToolStripMenuItem dropMoveToolStripMenuItem;
        private ToolStripMenuItem blindToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}

