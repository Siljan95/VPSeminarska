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
            this.lblTime = new System.Windows.Forms.Label();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.pStartingGame = new System.Windows.Forms.Panel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.StartGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRematch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pTimer.SuspendLayout();
            this.pStartingGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pStartingGame.Controls.Add(this.btnMenu);
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
            // btnRematch
            // 
            this.btnRematch.Location = new System.Drawing.Point(21, 156);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(75, 35);
            this.btnRematch.TabIndex = 3;
            this.btnRematch.Text = "Rematch";
            this.btnRematch.UseVisualStyleBackColor = true;
            this.btnRematch.Visible = false;
            this.btnRematch.Click += new System.EventHandler(this.btnRematch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(227, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(130, 156);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 35);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 599);
            this.Controls.Add(this.pStartingGame);
            this.Controls.Add(this.pTimer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bomberman";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartGame_KeyUp);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            this.pStartingGame.ResumeLayout(false);
            this.pStartingGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRematch;
    }
}

