namespace BomberMan
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblNameP3 = new System.Windows.Forms.Label();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPLayer2 = new System.Windows.Forms.PictureBox();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNameP2 = new System.Windows.Forms.Label();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameP1 = new System.Windows.Forms.Label();
            this.gbHighScore = new System.Windows.Forms.GroupBox();
            this.lblHighScore1 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
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
            this.gbHighScore.SuspendLayout();
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
            this.pTimer.Location = new System.Drawing.Point(3, 677);
            this.pTimer.Margin = new System.Windows.Forms.Padding(4);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(735, 100);
            this.pTimer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::BomberMan.Properties.Resources.Danger1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Wide Latin", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(283, 16);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(170, 46);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "5:00";
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(57, 4);
            this.pbTimer.Margin = new System.Windows.Forms.Padding(4);
            this.pbTimer.Maximum = 300;
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(677, 58);
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
            this.pStartingGame.Location = new System.Drawing.Point(196, 127);
            this.pStartingGame.Margin = new System.Windows.Forms.Padding(4);
            this.pStartingGame.Name = "pStartingGame";
            this.pStartingGame.Size = new System.Drawing.Size(429, 251);
            this.pStartingGame.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(239, 183);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 52);
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
            this.btnRematch.Location = new System.Drawing.Point(28, 183);
            this.btnRematch.Margin = new System.Windows.Forms.Padding(4);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(181, 52);
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
            this.lblStartTime.Location = new System.Drawing.Point(167, 97);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(82, 93);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "4";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(63, 36);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(328, 49);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Game Starting ";
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Red;
            this.lblWinner.Location = new System.Drawing.Point(27, 92);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(376, 61);
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
            this.pStatus.Location = new System.Drawing.Point(735, 4);
            this.pStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(381, 735);
            this.pStatus.TabIndex = 4;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbStatus.Controls.Add(this.gbPlayer3);
            this.gbStatus.Controls.Add(this.gbPlayer2);
            this.gbStatus.Controls.Add(this.gbPlayer1);
            this.gbStatus.Location = new System.Drawing.Point(11, 4);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbStatus.Size = new System.Drawing.Size(367, 726);
            this.gbStatus.TabIndex = 0;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Game Status";
            // 
            // gbPlayer3
            // 
            this.gbPlayer3.Controls.Add(this.label6);
            this.gbPlayer3.Controls.Add(this.pbPlayer3);
            this.gbPlayer3.Controls.Add(this.lblScoreP3);
            this.gbPlayer3.Controls.Add(this.label8);
            this.gbPlayer3.Controls.Add(this.lblNameP3);
            this.gbPlayer3.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer3.Location = new System.Drawing.Point(9, 489);
            this.gbPlayer3.Margin = new System.Windows.Forms.Padding(4);
            this.gbPlayer3.Name = "gbPlayer3";
            this.gbPlayer3.Padding = new System.Windows.Forms.Padding(4);
            this.gbPlayer3.Size = new System.Drawing.Size(349, 230);
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
            this.label6.Location = new System.Drawing.Point(163, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Score:";
            // 
            // pbPlayer3
            // 
            this.pbPlayer3.Location = new System.Drawing.Point(21, 64);
            this.pbPlayer3.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer3.Name = "pbPlayer3";
            this.pbPlayer3.Size = new System.Drawing.Size(133, 146);
            this.pbPlayer3.TabIndex = 8;
            this.pbPlayer3.TabStop = false;
            // 
            // lblScoreP3
            // 
            this.lblScoreP3.AutoSize = true;
            this.lblScoreP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP3.Location = new System.Drawing.Point(261, 126);
            this.lblScoreP3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreP3.Name = "lblScoreP3";
            this.lblScoreP3.Size = new System.Drawing.Size(27, 18);
            this.lblScoreP3.TabIndex = 5;
            this.lblScoreP3.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(261, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "0";
            // 
            // lblNameP3
            // 
            this.lblNameP3.AutoSize = true;
            this.lblNameP3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP3.Location = new System.Drawing.Point(163, 92);
            this.lblNameP3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameP3.Name = "lblNameP3";
            this.lblNameP3.Size = new System.Drawing.Size(87, 18);
            this.lblNameP3.TabIndex = 3;
            this.lblNameP3.Text = "label9";
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.label4);
            this.gbPlayer2.Controls.Add(this.pbPLayer2);
            this.gbPlayer2.Controls.Add(this.lblScoreP2);
            this.gbPlayer2.Controls.Add(this.label5);
            this.gbPlayer2.Controls.Add(this.lblNameP2);
            this.gbPlayer2.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2.Location = new System.Drawing.Point(9, 262);
            this.gbPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Padding = new System.Windows.Forms.Padding(4);
            this.gbPlayer2.Size = new System.Drawing.Size(347, 230);
            this.gbPlayer2.TabIndex = 1;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(163, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score:";
            // 
            // pbPLayer2
            // 
            this.pbPLayer2.BackgroundImage = global::BomberMan.Properties.Resources.char2;
            this.pbPLayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPLayer2.Location = new System.Drawing.Point(21, 48);
            this.pbPLayer2.Margin = new System.Windows.Forms.Padding(4);
            this.pbPLayer2.Name = "pbPLayer2";
            this.pbPLayer2.Size = new System.Drawing.Size(133, 146);
            this.pbPLayer2.TabIndex = 6;
            this.pbPLayer2.TabStop = false;
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP2.Location = new System.Drawing.Point(253, 102);
            this.lblScoreP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(27, 18);
            this.lblScoreP2.TabIndex = 5;
            this.lblScoreP2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(253, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "0";
            // 
            // lblNameP2
            // 
            this.lblNameP2.AutoSize = true;
            this.lblNameP2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP2.Location = new System.Drawing.Point(163, 70);
            this.lblNameP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameP2.Name = "lblNameP2";
            this.lblNameP2.Size = new System.Drawing.Size(87, 18);
            this.lblNameP2.TabIndex = 3;
            this.lblNameP2.Text = "label6";
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.label1);
            this.gbPlayer1.Controls.Add(this.label3);
            this.gbPlayer1.Controls.Add(this.pbPlayer1);
            this.gbPlayer1.Controls.Add(this.lblScoreP1);
            this.gbPlayer1.Controls.Add(this.label2);
            this.gbPlayer1.Controls.Add(this.lblNameP1);
            this.gbPlayer1.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1.Location = new System.Drawing.Point(9, 25);
            this.gbPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Padding = new System.Windows.Forms.Padding(4);
            this.gbPlayer1.Size = new System.Drawing.Size(347, 230);
            this.gbPlayer1.TabIndex = 0;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(163, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(163, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackgroundImage = global::BomberMan.Properties.Resources.char1;
            this.pbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer1.Location = new System.Drawing.Point(21, 54);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(133, 146);
            this.pbPlayer1.TabIndex = 7;
            this.pbPlayer1.TabStop = false;
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScoreP1.Location = new System.Drawing.Point(253, 118);
            this.lblScoreP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(27, 18);
            this.lblScoreP1.TabIndex = 2;
            this.lblScoreP1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(253, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // lblNameP1
            // 
            this.lblNameP1.AutoSize = true;
            this.lblNameP1.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNameP1.Location = new System.Drawing.Point(163, 80);
            this.lblNameP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameP1.Name = "lblNameP1";
            this.lblNameP1.Size = new System.Drawing.Size(82, 18);
            this.lblNameP1.TabIndex = 0;
            this.lblNameP1.Text = "label1";
            // 
            // gbHighScore
            // 
            this.gbHighScore.Controls.Add(this.lblHighScore1);
            this.gbHighScore.Controls.Add(this.lblHighScore);
            this.gbHighScore.Location = new System.Drawing.Point(117, 111);
            this.gbHighScore.Name = "gbHighScore";
            this.gbHighScore.Size = new System.Drawing.Size(574, 353);
            this.gbHighScore.TabIndex = 5;
            this.gbHighScore.TabStop = false;
            this.gbHighScore.Text = "New High Score";
            // 
            // lblHighScore1
            // 
            this.lblHighScore1.AutoSize = true;
            this.lblHighScore1.Font = new System.Drawing.Font("Courier New", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore1.Location = new System.Drawing.Point(182, 113);
            this.lblHighScore1.Name = "lblHighScore1";
            this.lblHighScore1.Size = new System.Drawing.Size(288, 88);
            this.lblHighScore1.TabIndex = 1;
            this.lblHighScore1.Text = "A A A";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(179, 26);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(177, 17);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "[lblWhoHasNewHighScore]";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 737);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.gbHighScore);
            this.Controls.Add(this.pStartingGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.gbHighScore.ResumeLayout(false);
            this.gbHighScore.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNameP3;
        private System.Windows.Forms.PictureBox pbPLayer2;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameP2;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbHighScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHighScore1;
    }
}

