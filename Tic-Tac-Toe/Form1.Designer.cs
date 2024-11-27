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
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player2NameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusSetup = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button00 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusGame = new System.Windows.Forms.ToolStripStatusLabel();
            this.easyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.StatusSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.hintToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            this.pCToolStripMenuItem.CheckOnClick = true;
            this.pCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem1,
            this.mediumToolStripMenuItem1,
            this.hardToolStripMenuItem1});
            this.pCToolStripMenuItem.Name = "pCToolStripMenuItem";
            this.pCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pCToolStripMenuItem.Text = "Bot";
            this.pCToolStripMenuItem.Click += new System.EventHandler(this.Player1_Is_Bot_Click);
            // 
            // humanToolStripMenuItem
            // 
            this.humanToolStripMenuItem.CheckOnClick = true;
            this.humanToolStripMenuItem.Name = "humanToolStripMenuItem";
            this.humanToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
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
            this.humanToolStripMenuItem1.CheckOnClick = true;
            this.humanToolStripMenuItem1.Name = "humanToolStripMenuItem1";
            this.humanToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
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
            this.easyToolStripMenuItem.CheckOnClick = true;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.Player2_Is_BotEasy_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.Player2_Is_BotMedium_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.CheckOnClick = true;
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.Player2_Is_BotHard_Click);
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.startGameToolStripMenuItem.Text = "Start game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.StartGame);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.player1NameToolStripMenuItem,
            this.player2NameToolStripMenuItem,
            this.playerSignToolStripMenuItem,
            this.boardSizeToolStripMenuItem,
            this.gameModToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
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
            this.changeToolStripMenuItem});
            this.player1NameToolStripMenuItem.Name = "player1NameToolStripMenuItem";
            this.player1NameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.player1NameToolStripMenuItem.Text = "Player 1 name";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.ChangeNameOfPlayer1_Click);
            // 
            // boardSizeToolStripMenuItem
            // 
            this.boardSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.boardSizeToolStripMenuItem.Name = "boardSizeToolStripMenuItem";
            this.boardSizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.boardSizeToolStripMenuItem.Text = "Board size";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Checked = true;
            this.x3ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x3ToolStripMenuItem.Text = "3x3";
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bigToolStripMenuItem.Text = "Big";
            // 
            // player2NameToolStripMenuItem
            // 
            this.player2NameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem1});
            this.player2NameToolStripMenuItem.Name = "player2NameToolStripMenuItem";
            this.player2NameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.player2NameToolStripMenuItem.Text = "Player 2 name";
            // 
            // changeToolStripMenuItem1
            // 
            this.changeToolStripMenuItem1.Name = "changeToolStripMenuItem1";
            this.changeToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.changeToolStripMenuItem1.Text = "Change";
            this.changeToolStripMenuItem1.Click += new System.EventHandler(this.ChangeNameOfPlayer2_Click);
            // 
            // playerSignToolStripMenuItem
            // 
            this.playerSignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.imageToolStripMenuItem1});
            this.playerSignToolStripMenuItem.Name = "playerSignToolStripMenuItem";
            this.playerSignToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playerSignToolStripMenuItem.Text = "Player sign";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem2});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // changeToolStripMenuItem2
            // 
            this.changeToolStripMenuItem2.Name = "changeToolStripMenuItem2";
            this.changeToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.changeToolStripMenuItem2.Text = "Change";
            // 
            // gameModToolStripMenuItem
            // 
            this.gameModToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classicToolStripMenuItem,
            this.dropMoveToolStripMenuItem,
            this.blindToolStripMenuItem});
            this.gameModToolStripMenuItem.Name = "gameModToolStripMenuItem";
            this.gameModToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.hintToolStripMenuItem.Text = "Hint";
            // 
            // StatusSetup
            // 
            this.StatusSetup.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusGame});
            this.StatusSetup.Location = new System.Drawing.Point(0, 526);
            this.StatusSetup.Name = "StatusSetup";
            this.StatusSetup.Size = new System.Drawing.Size(859, 22);
            this.StatusSetup.TabIndex = 13;
            this.StatusSetup.Text = "statusStrip1";
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
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(234, 162);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(110, 110);
            this.button00.TabIndex = 16;
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.Player_Click);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(344, 162);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(110, 110);
            this.button01.TabIndex = 17;
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.Player_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(454, 162);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(110, 110);
            this.button02.TabIndex = 18;
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.Player_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(234, 272);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 110);
            this.button10.TabIndex = 19;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Player_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(344, 272);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(110, 110);
            this.button11.TabIndex = 20;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Player_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(454, 272);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 110);
            this.button12.TabIndex = 21;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Player_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(234, 382);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(110, 110);
            this.button20.TabIndex = 22;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Player_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(344, 382);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(110, 110);
            this.button21.TabIndex = 23;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Player_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(454, 382);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(110, 110);
            this.button22.TabIndex = 24;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Player_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Restart Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RestartGame_Click);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(313, 87);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(53, 16);
            this.Player1.TabIndex = 28;
            this.Player1.Text = "Player1";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(432, 87);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(53, 16);
            this.Player2.TabIndex = 29;
            this.Player2.Text = "Player2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(491, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 69);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // imageToolStripMenuItem1
            // 
            this.imageToolStripMenuItem1.Name = "imageToolStripMenuItem1";
            this.imageToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.imageToolStripMenuItem1.Text = "Image";
            // 
            // StatusGame
            // 
            this.StatusGame.BackColor = System.Drawing.Color.White;
            this.StatusGame.LinkColor = System.Drawing.Color.Black;
            this.StatusGame.Name = "StatusGame";
            this.StatusGame.Size = new System.Drawing.Size(0, 18);
            // 
            // easyToolStripMenuItem1
            // 
            this.easyToolStripMenuItem1.Name = "easyToolStripMenuItem1";
            this.easyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.easyToolStripMenuItem1.Text = "Easy";
            // 
            // mediumToolStripMenuItem1
            // 
            this.mediumToolStripMenuItem1.Name = "mediumToolStripMenuItem1";
            this.mediumToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.mediumToolStripMenuItem1.Text = "Medium";
            // 
            // hardToolStripMenuItem1
            // 
            this.hardToolStripMenuItem1.Name = "hardToolStripMenuItem1";
            this.hardToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.hardToolStripMenuItem1.Text = "Hard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(859, 548);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusSetup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusSetup.ResumeLayout(false);
            this.StatusSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private StatusStrip StatusSetup;
        private ToolStripMenuItem player2NameToolStripMenuItem;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem changeToolStripMenuItem;
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
        private Button button00;
        private Button button01;
        private Button button02;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem versionToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Player1;
        private Label Player2;
        private ToolStripMenuItem imageToolStripMenuItem1;
        private ToolStripStatusLabel StatusGame;
        private ToolStripMenuItem easyToolStripMenuItem1;
        private ToolStripMenuItem mediumToolStripMenuItem1;
        private ToolStripMenuItem hardToolStripMenuItem1;
    }
}

