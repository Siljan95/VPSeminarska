﻿namespace BomberMan
{
    partial class StartGame
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
            this.components = new System.ComponentModel.Container();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pTimer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.pStartingGame = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRematch = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.StartGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pStatus = new System.Windows.Forms.Panel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbPlayer3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPlayer3 = new System.Windows.Forms.PictureBox();
            this.lblScoreP3 = new System.Windows.Forms.Label();
            this.lblRadiusP3 = new System.Windows.Forms.Label();
            this.lblNameP3 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPLayer2 = new System.Windows.Forms.PictureBox();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.lblBombsP2 = new System.Windows.Forms.Label();
            this.lblNameP2 = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.lblBombsP1 = new System.Windows.Forms.Label();
            this.lblNameP1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRadiusP1 = new System.Windows.Forms.Label();
            this.lblSpeedP1 = new System.Windows.Forms.Label();
            this.lblRadiusP2 = new System.Windows.Forms.Label();
            this.lblSpeedP2 = new System.Windows.Forms.Label();
            this.lblBombsP3 = new System.Windows.Forms.Label();
            this.lblSpeedP3 = new System.Windows.Forms.Label();
            this.pTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pStartingGame.SuspendLayout();
            this.pStatus.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).BeginInit();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLayer2)).BeginInit();
            this.gbPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pTimer
            // 
            this.pTimer.Controls.Add(this.pictureBox1);
            this.pTimer.Controls.Add(this.lblTime);
            this.pTimer.Controls.Add(this.pbTimer);
            this.pTimer.Location = new System.Drawing.Point(2, 550);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(551, 81);
            this.pTimer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::BomberMan.Properties.Resources.Danger1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Wide Latin", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(212, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(138, 37);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "5:00";
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(43, 3);
            this.pbTimer.Maximum = 300;
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(508, 47);
            this.pbTimer.Step = 1;
            this.pbTimer.TabIndex = 2;
            this.pbTimer.Value = 300;
            // 
            // pStartingGame
            // 
            this.pStartingGame.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pStartingGame.Controls.Add(this.btnExit);
            this.pStartingGame.Controls.Add(this.btnRematch);
            this.pStartingGame.Controls.Add(this.lblStartTime);
            this.pStartingGame.Controls.Add(this.lblInfo);
            this.pStartingGame.Controls.Add(this.lblWinner);
            this.pStartingGame.Location = new System.Drawing.Point(147, 103);
            this.pStartingGame.Name = "pStartingGame";
            this.pStartingGame.Size = new System.Drawing.Size(322, 204);
            this.pStartingGame.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(179, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRematch
            // 
            this.btnRematch.BackColor = System.Drawing.Color.BurlyWood;
            this.btnRematch.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRematch.ForeColor = System.Drawing.Color.Black;
            this.btnRematch.Location = new System.Drawing.Point(21, 149);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(136, 42);
            this.btnRematch.TabIndex = 3;
            this.btnRematch.Text = "Rematch";
            this.btnRematch.UseVisualStyleBackColor = false;
            this.btnRematch.Visible = false;
            this.btnRematch.Click += new System.EventHandler(this.btnRematch_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStartTime.Font = new System.Drawing.Font("Showcard Gothic", 45F);
            this.lblStartTime.Location = new System.Drawing.Point(125, 79);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(66, 74);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "4";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(28, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 38);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Game Starting ";
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Red;
            this.lblWinner.Location = new System.Drawing.Point(27, 92);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(260, 61);
            this.lblWinner.TabIndex = 2;
            // 
            // StartGameTimer
            // 
            this.StartGameTimer.Interval = 1000;
            this.StartGameTimer.Tick += new System.EventHandler(this.StartGameTimer_Tick);
            // 
            // pStatus
            // 
            this.pStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pStatus.Controls.Add(this.gbStatus);
            this.pStatus.Location = new System.Drawing.Point(551, 3);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(286, 597);
            this.pStatus.TabIndex = 4;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbStatus.Controls.Add(this.gbPlayer3);
            this.gbStatus.Controls.Add(this.gbPlayer2);
            this.gbStatus.Controls.Add(this.gbPlayer1);
            this.gbStatus.Location = new System.Drawing.Point(8, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(275, 590);
            this.gbStatus.TabIndex = 0;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Game Status";
            // 
            // gbPlayer3
            // 
            this.gbPlayer3.Controls.Add(this.lblSpeedP3);
            this.gbPlayer3.Controls.Add(this.lblBombsP3);
            this.gbPlayer3.Controls.Add(this.label13);
            this.gbPlayer3.Controls.Add(this.label14);
            this.gbPlayer3.Controls.Add(this.label6);
            this.gbPlayer3.Controls.Add(this.label15);
            this.gbPlayer3.Controls.Add(this.pbPlayer3);
            this.gbPlayer3.Controls.Add(this.lblScoreP3);
            this.gbPlayer3.Controls.Add(this.lblRadiusP3);
            this.gbPlayer3.Controls.Add(this.lblNameP3);
            this.gbPlayer3.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer3.Location = new System.Drawing.Point(7, 397);
            this.gbPlayer3.Name = "gbPlayer3";
            this.gbPlayer3.Size = new System.Drawing.Size(262, 187);
            this.gbPlayer3.TabIndex = 2;
            this.gbPlayer3.TabStop = false;
            this.gbPlayer3.Text = "Player3";
            this.gbPlayer3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(125, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Score:";
            // 
            // pbPlayer3
            // 
            this.pbPlayer3.Location = new System.Drawing.Point(16, 52);
            this.pbPlayer3.Name = "pbPlayer3";
            this.pbPlayer3.Size = new System.Drawing.Size(100, 119);
            this.pbPlayer3.TabIndex = 8;
            this.pbPlayer3.TabStop = false;
            // 
            // lblScoreP3
            // 
            this.lblScoreP3.AutoSize = true;
            this.lblScoreP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP3.Location = new System.Drawing.Point(196, 81);
            this.lblScoreP3.Name = "lblScoreP3";
            this.lblScoreP3.Size = new System.Drawing.Size(22, 15);
            this.lblScoreP3.TabIndex = 5;
            this.lblScoreP3.Text = "0";
            // 
            // lblRadiusP3
            // 
            this.lblRadiusP3.AutoSize = true;
            this.lblRadiusP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRadiusP3.Location = new System.Drawing.Point(196, 132);
            this.lblRadiusP3.Name = "lblRadiusP3";
            this.lblRadiusP3.Size = new System.Drawing.Size(18, 15);
            this.lblRadiusP3.TabIndex = 4;
            this.lblRadiusP3.Text = "1";
            // 
            // lblNameP3
            // 
            this.lblNameP3.AutoSize = true;
            this.lblNameP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP3.Location = new System.Drawing.Point(122, 52);
            this.lblNameP3.Name = "lblNameP3";
            this.lblNameP3.Size = new System.Drawing.Size(70, 15);
            this.lblNameP3.TabIndex = 3;
            this.lblNameP3.Text = "label9";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.lblSpeedP2);
            this.gbPlayer2.Controls.Add(this.lblRadiusP2);
            this.gbPlayer2.Controls.Add(this.label10);
            this.gbPlayer2.Controls.Add(this.label4);
            this.gbPlayer2.Controls.Add(this.label11);
            this.gbPlayer2.Controls.Add(this.pbPLayer2);
            this.gbPlayer2.Controls.Add(this.label12);
            this.gbPlayer2.Controls.Add(this.lblScoreP2);
            this.gbPlayer2.Controls.Add(this.lblBombsP2);
            this.gbPlayer2.Controls.Add(this.lblNameP2);
            this.gbPlayer2.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2.Location = new System.Drawing.Point(7, 213);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(260, 187);
            this.gbPlayer2.TabIndex = 1;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(125, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score:";
            // 
            // pbPLayer2
            // 
            this.pbPLayer2.BackgroundImage = global::BomberMan.Properties.Resources.char2;
            this.pbPLayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPLayer2.Location = new System.Drawing.Point(16, 39);
            this.pbPLayer2.Name = "pbPLayer2";
            this.pbPLayer2.Size = new System.Drawing.Size(100, 119);
            this.pbPLayer2.TabIndex = 6;
            this.pbPLayer2.TabStop = false;
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP2.Location = new System.Drawing.Point(190, 71);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(22, 15);
            this.lblScoreP2.TabIndex = 5;
            this.lblScoreP2.Text = "0";
            // 
            // lblBombsP2
            // 
            this.lblBombsP2.AutoSize = true;
            this.lblBombsP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombsP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBombsP2.Location = new System.Drawing.Point(190, 107);
            this.lblBombsP2.Name = "lblBombsP2";
            this.lblBombsP2.Size = new System.Drawing.Size(18, 15);
            this.lblBombsP2.TabIndex = 4;
            this.lblBombsP2.Text = "1";
            // 
            // lblNameP2
            // 
            this.lblNameP2.AutoSize = true;
            this.lblNameP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP2.Location = new System.Drawing.Point(122, 39);
            this.lblNameP2.Name = "lblNameP2";
            this.lblNameP2.Size = new System.Drawing.Size(70, 15);
            this.lblNameP2.TabIndex = 3;
            this.lblNameP2.Text = "label6";
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.lblSpeedP1);
            this.gbPlayer1.Controls.Add(this.lblRadiusP1);
            this.gbPlayer1.Controls.Add(this.label9);
            this.gbPlayer1.Controls.Add(this.label7);
            this.gbPlayer1.Controls.Add(this.label1);
            this.gbPlayer1.Controls.Add(this.label3);
            this.gbPlayer1.Controls.Add(this.pbPlayer1);
            this.gbPlayer1.Controls.Add(this.lblScoreP1);
            this.gbPlayer1.Controls.Add(this.lblBombsP1);
            this.gbPlayer1.Controls.Add(this.lblNameP1);
            this.gbPlayer1.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1.Location = new System.Drawing.Point(7, 20);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(260, 187);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(122, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(125, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radius";
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackgroundImage = global::BomberMan.Properties.Resources.char1;
            this.pbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer1.Location = new System.Drawing.Point(16, 44);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(100, 119);
            this.pbPlayer1.TabIndex = 7;
            this.pbPlayer1.TabStop = false;
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP1.Location = new System.Drawing.Point(190, 70);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(22, 15);
            this.lblScoreP1.TabIndex = 2;
            this.lblScoreP1.Text = "0";
            // 
            // lblBombsP1
            // 
            this.lblBombsP1.AutoSize = true;
            this.lblBombsP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombsP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBombsP1.Location = new System.Drawing.Point(190, 108);
            this.lblBombsP1.Name = "lblBombsP1";
            this.lblBombsP1.Size = new System.Drawing.Size(18, 15);
            this.lblBombsP1.TabIndex = 1;
            this.lblBombsP1.Text = "1";
            // 
            // lblNameP1
            // 
            this.lblNameP1.AutoSize = true;
            this.lblNameP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP1.Location = new System.Drawing.Point(122, 44);
            this.lblNameP1.Name = "lblNameP1";
            this.lblNameP1.Size = new System.Drawing.Size(67, 15);
            this.lblNameP1.TabIndex = 0;
            this.lblNameP1.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(125, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(125, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bombs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(125, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bombs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(125, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(125, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Radius";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(125, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Bombs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(125, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Speed";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ravie", 8.25F);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(125, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Radius";
            // 
            // lblRadiusP1
            // 
            this.lblRadiusP1.AutoSize = true;
            this.lblRadiusP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRadiusP1.Location = new System.Drawing.Point(190, 125);
            this.lblRadiusP1.Name = "lblRadiusP1";
            this.lblRadiusP1.Size = new System.Drawing.Size(18, 15);
            this.lblRadiusP1.TabIndex = 12;
            this.lblRadiusP1.Text = "1";
            // 
            // lblSpeedP1
            // 
            this.lblSpeedP1.AutoSize = true;
            this.lblSpeedP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSpeedP1.Location = new System.Drawing.Point(190, 142);
            this.lblSpeedP1.Name = "lblSpeedP1";
            this.lblSpeedP1.Size = new System.Drawing.Size(18, 15);
            this.lblSpeedP1.TabIndex = 13;
            this.lblSpeedP1.Text = "1";
            // 
            // lblRadiusP2
            // 
            this.lblRadiusP2.AutoSize = true;
            this.lblRadiusP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadiusP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRadiusP2.Location = new System.Drawing.Point(190, 124);
            this.lblRadiusP2.Name = "lblRadiusP2";
            this.lblRadiusP2.Size = new System.Drawing.Size(18, 15);
            this.lblRadiusP2.TabIndex = 15;
            this.lblRadiusP2.Text = "1";
            // 
            // lblSpeedP2
            // 
            this.lblSpeedP2.AutoSize = true;
            this.lblSpeedP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSpeedP2.Location = new System.Drawing.Point(190, 143);
            this.lblSpeedP2.Name = "lblSpeedP2";
            this.lblSpeedP2.Size = new System.Drawing.Size(18, 15);
            this.lblSpeedP2.TabIndex = 16;
            this.lblSpeedP2.Text = "1";
            // 
            // lblBombsP3
            // 
            this.lblBombsP3.AutoSize = true;
            this.lblBombsP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBombsP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBombsP3.Location = new System.Drawing.Point(196, 113);
            this.lblBombsP3.Name = "lblBombsP3";
            this.lblBombsP3.Size = new System.Drawing.Size(18, 15);
            this.lblBombsP3.TabIndex = 18;
            this.lblBombsP3.Text = "1";
            // 
            // lblSpeedP3
            // 
            this.lblSpeedP3.AutoSize = true;
            this.lblSpeedP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSpeedP3.Location = new System.Drawing.Point(196, 156);
            this.lblSpeedP3.Name = "lblSpeedP3";
            this.lblSpeedP3.Size = new System.Drawing.Size(18, 15);
            this.lblSpeedP3.TabIndex = 19;
            this.lblSpeedP3.Text = "1";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 599);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pStartingGame);
            this.Controls.Add(this.pTimer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bomberman";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartGame_KeyUp);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pStartingGame.ResumeLayout(false);
            this.pStartingGame.PerformLayout();
            this.pStatus.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbPlayer3.ResumeLayout(false);
            this.gbPlayer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer3)).EndInit();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPLayer2)).EndInit();
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pStartingGame;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer StartGameTimer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRematch;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbPlayer3;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer3;
        private System.Windows.Forms.Label lblScoreP3;
        private System.Windows.Forms.Label lblRadiusP3;
        private System.Windows.Forms.Label lblNameP3;
        private System.Windows.Forms.PictureBox pbPLayer2;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.Label lblBombsP2;
        private System.Windows.Forms.Label lblNameP2;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.Label lblBombsP1;
        private System.Windows.Forms.Label lblNameP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSpeedP3;
        private System.Windows.Forms.Label lblBombsP3;
        private System.Windows.Forms.Label lblSpeedP2;
        private System.Windows.Forms.Label lblRadiusP2;
        private System.Windows.Forms.Label lblSpeedP1;
        private System.Windows.Forms.Label lblRadiusP1;
    }
}

