﻿namespace BomberMan
{
    partial class Menu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pOption = new System.Windows.Forms.Panel();
            this.pTwoPlayers = new System.Windows.Forms.Panel();
            this.tbCmdBomb3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCmdRight3 = new System.Windows.Forms.TextBox();
            this.tbCmdLeft3 = new System.Windows.Forms.TextBox();
            this.tbCmdDown3 = new System.Windows.Forms.TextBox();
            this.tbCmdUp3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tbCmdBomb2 = new System.Windows.Forms.TextBox();
            this.tbCmdBomb1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCmdRight2 = new System.Windows.Forms.TextBox();
            this.tbCmdLeft2 = new System.Windows.Forms.TextBox();
            this.tbCmdDown2 = new System.Windows.Forms.TextBox();
            this.tbCmdUp2 = new System.Windows.Forms.TextBox();
            this.tbCmdRight1 = new System.Windows.Forms.TextBox();
            this.tbCmdLeft1 = new System.Windows.Forms.TextBox();
            this.tbCmdDown1 = new System.Windows.Forms.TextBox();
            this.tbCmdUp1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.pOption.SuspendLayout();
            this.pTwoPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExit.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(280, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.BurlyWood;
            this.btnScore.Font = new System.Drawing.Font("Wide Latin", 10F);
            this.btnScore.Location = new System.Drawing.Point(280, 296);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(184, 39);
            this.btnScore.TabIndex = 4;
            this.btnScore.Text = "High Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.MouseLeave += new System.EventHandler(this.btnScore_MouseLeave);
            this.btnScore.MouseHover += new System.EventHandler(this.btnScore_MouseHover);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStart.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnStart.Location = new System.Drawing.Point(237, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(274, 56);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Stat Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnStart);
            this.pMenu.Controls.Add(this.btnExit);
            this.pMenu.Controls.Add(this.btnScore);
            this.pMenu.Controls.Add(this.btnOptions);
            this.pMenu.Location = new System.Drawing.Point(1, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(751, 436);
            this.pMenu.TabIndex = 7;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.BurlyWood;
            this.btnOptions.Font = new System.Drawing.Font("Wide Latin", 10F);
            this.btnOptions.Location = new System.Drawing.Point(280, 222);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(184, 39);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseHover += new System.EventHandler(this.btnOptions_MouseHover);
            // 
            // pOption
            // 
            this.pOption.Controls.Add(this.pTwoPlayers);
            this.pOption.Controls.Add(this.label1);
            this.pOption.Controls.Add(this.rb3);
            this.pOption.Controls.Add(this.rb2);
            this.pOption.Controls.Add(this.btnBack);
            this.pOption.Controls.Add(this.btnSave);
            this.pOption.Location = new System.Drawing.Point(-2, -5);
            this.pOption.Name = "pOption";
            this.pOption.Size = new System.Drawing.Size(756, 444);
            this.pOption.TabIndex = 9;
            this.pOption.Visible = false;
            // 
            // pTwoPlayers
            // 
            this.pTwoPlayers.Controls.Add(this.tbCmdBomb3);
            this.pTwoPlayers.Controls.Add(this.label18);
            this.pTwoPlayers.Controls.Add(this.tbCmdRight3);
            this.pTwoPlayers.Controls.Add(this.tbCmdLeft3);
            this.pTwoPlayers.Controls.Add(this.tbCmdDown3);
            this.pTwoPlayers.Controls.Add(this.tbCmdUp3);
            this.pTwoPlayers.Controls.Add(this.label19);
            this.pTwoPlayers.Controls.Add(this.label20);
            this.pTwoPlayers.Controls.Add(this.label21);
            this.pTwoPlayers.Controls.Add(this.label22);
            this.pTwoPlayers.Controls.Add(this.label23);
            this.pTwoPlayers.Controls.Add(this.label24);
            this.pTwoPlayers.Controls.Add(this.label25);
            this.pTwoPlayers.Controls.Add(this.textBox6);
            this.pTwoPlayers.Controls.Add(this.tbCmdBomb2);
            this.pTwoPlayers.Controls.Add(this.tbCmdBomb1);
            this.pTwoPlayers.Controls.Add(this.label17);
            this.pTwoPlayers.Controls.Add(this.label16);
            this.pTwoPlayers.Controls.Add(this.tbCmdRight2);
            this.pTwoPlayers.Controls.Add(this.tbCmdLeft2);
            this.pTwoPlayers.Controls.Add(this.tbCmdDown2);
            this.pTwoPlayers.Controls.Add(this.tbCmdUp2);
            this.pTwoPlayers.Controls.Add(this.tbCmdRight1);
            this.pTwoPlayers.Controls.Add(this.tbCmdLeft1);
            this.pTwoPlayers.Controls.Add(this.tbCmdDown1);
            this.pTwoPlayers.Controls.Add(this.tbCmdUp1);
            this.pTwoPlayers.Controls.Add(this.label15);
            this.pTwoPlayers.Controls.Add(this.label14);
            this.pTwoPlayers.Controls.Add(this.label13);
            this.pTwoPlayers.Controls.Add(this.label12);
            this.pTwoPlayers.Controls.Add(this.label11);
            this.pTwoPlayers.Controls.Add(this.label10);
            this.pTwoPlayers.Controls.Add(this.label9);
            this.pTwoPlayers.Controls.Add(this.label8);
            this.pTwoPlayers.Controls.Add(this.label7);
            this.pTwoPlayers.Controls.Add(this.label6);
            this.pTwoPlayers.Controls.Add(this.label5);
            this.pTwoPlayers.Controls.Add(this.label4);
            this.pTwoPlayers.Controls.Add(this.tbName2);
            this.pTwoPlayers.Controls.Add(this.label3);
            this.pTwoPlayers.Controls.Add(this.label2);
            this.pTwoPlayers.Controls.Add(this.tbName1);
            this.pTwoPlayers.Location = new System.Drawing.Point(14, 86);
            this.pTwoPlayers.Name = "pTwoPlayers";
            this.pTwoPlayers.Size = new System.Drawing.Size(728, 244);
            this.pTwoPlayers.TabIndex = 15;
            // 
            // tbCmdBomb3
            // 
            this.tbCmdBomb3.Location = new System.Drawing.Point(542, 207);
            this.tbCmdBomb3.Name = "tbCmdBomb3";
            this.tbCmdBomb3.Size = new System.Drawing.Size(100, 20);
            this.tbCmdBomb3.TabIndex = 53;
            this.tbCmdBomb3.Text = "NumPad0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label18.Location = new System.Drawing.Point(468, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 20);
            this.label18.TabIndex = 52;
            this.label18.Text = "Bomb";
            // 
            // tbCmdRight3
            // 
            this.tbCmdRight3.Location = new System.Drawing.Point(542, 187);
            this.tbCmdRight3.Name = "tbCmdRight3";
            this.tbCmdRight3.Size = new System.Drawing.Size(100, 20);
            this.tbCmdRight3.TabIndex = 51;
            this.tbCmdRight3.Text = "NumPad4";
            // 
            // tbCmdLeft3
            // 
            this.tbCmdLeft3.Location = new System.Drawing.Point(542, 167);
            this.tbCmdLeft3.Name = "tbCmdLeft3";
            this.tbCmdLeft3.Size = new System.Drawing.Size(100, 20);
            this.tbCmdLeft3.TabIndex = 50;
            this.tbCmdLeft3.Text = "NumPad6";
            // 
            // tbCmdDown3
            // 
            this.tbCmdDown3.Location = new System.Drawing.Point(542, 147);
            this.tbCmdDown3.Name = "tbCmdDown3";
            this.tbCmdDown3.Size = new System.Drawing.Size(100, 20);
            this.tbCmdDown3.TabIndex = 49;
            this.tbCmdDown3.Text = "NumPad5";
            // 
            // tbCmdUp3
            // 
            this.tbCmdUp3.Location = new System.Drawing.Point(542, 127);
            this.tbCmdUp3.Name = "tbCmdUp3";
            this.tbCmdUp3.Size = new System.Drawing.Size(100, 20);
            this.tbCmdUp3.TabIndex = 48;
            this.tbCmdUp3.Text = "NumPad8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label19.Location = new System.Drawing.Point(468, 187);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 47;
            this.label19.Text = "Right";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label20.Location = new System.Drawing.Point(468, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 46;
            this.label20.Text = "Left";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label21.Location = new System.Drawing.Point(468, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 20);
            this.label21.TabIndex = 45;
            this.label21.Text = "Down";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label22.Location = new System.Drawing.Point(468, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 20);
            this.label22.TabIndex = 44;
            this.label22.Text = "Up";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label23.Location = new System.Drawing.Point(527, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 20);
            this.label23.TabIndex = 43;
            this.label23.Text = "Commands";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label24.Location = new System.Drawing.Point(505, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 30);
            this.label24.TabIndex = 42;
            this.label24.Text = "Player3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label25.Location = new System.Drawing.Point(468, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 20);
            this.label25.TabIndex = 41;
            this.label25.Text = "Name:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(542, 60);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "Player3";
            // 
            // tbCmdBomb2
            // 
            this.tbCmdBomb2.Location = new System.Drawing.Point(316, 207);
            this.tbCmdBomb2.Name = "tbCmdBomb2";
            this.tbCmdBomb2.Size = new System.Drawing.Size(100, 20);
            this.tbCmdBomb2.TabIndex = 39;
            this.tbCmdBomb2.Text = "E";
            // 
            // tbCmdBomb1
            // 
            this.tbCmdBomb1.Location = new System.Drawing.Point(96, 207);
            this.tbCmdBomb1.Name = "tbCmdBomb1";
            this.tbCmdBomb1.Size = new System.Drawing.Size(100, 20);
            this.tbCmdBomb1.TabIndex = 38;
            this.tbCmdBomb1.Text = "Space";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label17.Location = new System.Drawing.Point(249, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Bomb";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label16.Location = new System.Drawing.Point(24, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Bomb";
            // 
            // tbCmdRight2
            // 
            this.tbCmdRight2.Location = new System.Drawing.Point(316, 187);
            this.tbCmdRight2.Name = "tbCmdRight2";
            this.tbCmdRight2.Size = new System.Drawing.Size(100, 20);
            this.tbCmdRight2.TabIndex = 35;
            this.tbCmdRight2.Text = "D";
            // 
            // tbCmdLeft2
            // 
            this.tbCmdLeft2.Location = new System.Drawing.Point(316, 167);
            this.tbCmdLeft2.Name = "tbCmdLeft2";
            this.tbCmdLeft2.Size = new System.Drawing.Size(100, 20);
            this.tbCmdLeft2.TabIndex = 34;
            this.tbCmdLeft2.Text = "A";
            // 
            // tbCmdDown2
            // 
            this.tbCmdDown2.Location = new System.Drawing.Point(316, 147);
            this.tbCmdDown2.Name = "tbCmdDown2";
            this.tbCmdDown2.Size = new System.Drawing.Size(100, 20);
            this.tbCmdDown2.TabIndex = 33;
            this.tbCmdDown2.Text = "S";
            // 
            // tbCmdUp2
            // 
            this.tbCmdUp2.Location = new System.Drawing.Point(316, 127);
            this.tbCmdUp2.Name = "tbCmdUp2";
            this.tbCmdUp2.Size = new System.Drawing.Size(100, 20);
            this.tbCmdUp2.TabIndex = 32;
            this.tbCmdUp2.Text = "W";
            // 
            // tbCmdRight1
            // 
            this.tbCmdRight1.Location = new System.Drawing.Point(96, 187);
            this.tbCmdRight1.Name = "tbCmdRight1";
            this.tbCmdRight1.Size = new System.Drawing.Size(100, 20);
            this.tbCmdRight1.TabIndex = 31;
            this.tbCmdRight1.Text = "Right";
            // 
            // tbCmdLeft1
            // 
            this.tbCmdLeft1.Location = new System.Drawing.Point(96, 167);
            this.tbCmdLeft1.Name = "tbCmdLeft1";
            this.tbCmdLeft1.Size = new System.Drawing.Size(100, 20);
            this.tbCmdLeft1.TabIndex = 30;
            this.tbCmdLeft1.Text = "Left";
            // 
            // tbCmdDown1
            // 
            this.tbCmdDown1.Location = new System.Drawing.Point(96, 147);
            this.tbCmdDown1.Name = "tbCmdDown1";
            this.tbCmdDown1.Size = new System.Drawing.Size(100, 20);
            this.tbCmdDown1.TabIndex = 29;
            this.tbCmdDown1.Text = "Down";
            // 
            // tbCmdUp1
            // 
            this.tbCmdUp1.Location = new System.Drawing.Point(96, 127);
            this.tbCmdUp1.Name = "tbCmdUp1";
            this.tbCmdUp1.Size = new System.Drawing.Size(100, 20);
            this.tbCmdUp1.TabIndex = 28;
            this.tbCmdUp1.Text = "Up";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label15.Location = new System.Drawing.Point(249, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Right";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label14.Location = new System.Drawing.Point(249, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Left";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label13.Location = new System.Drawing.Point(22, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Right";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(22, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Left";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(249, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Down";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(22, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Down";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(249, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Up";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(22, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Up";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(277, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Commands";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(81, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Commands";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(276, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Player2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(59, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player1";
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(321, 60);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(100, 20);
            this.tbName2.TabIndex = 3;
            this.tbName2.Text = "Player2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(249, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(96, 60);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(100, 20);
            this.tbName1.TabIndex = 0;
            this.tbName1.Text = "Player1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of players:";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rb3.Location = new System.Drawing.Point(505, 59);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(151, 24);
            this.rb3.TabIndex = 12;
            this.rb3.TabStop = true;
            this.rb3.Text = "Three Players";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rb2.Location = new System.Drawing.Point(335, 59);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(139, 24);
            this.rb2.TabIndex = 11;
            this.rb2.TabStop = true;
            this.rb2.Text = "Two Players";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.Font = new System.Drawing.Font("Wide Latin", 15F);
            this.btnBack.Location = new System.Drawing.Point(425, 336);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(274, 56);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSave.Font = new System.Drawing.Font("Wide Latin", 15F);
            this.btnSave.Location = new System.Drawing.Point(94, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(274, 56);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSingle_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSingle_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 435);
            this.Controls.Add(this.pOption);
            this.Controls.Add(this.pMenu);
            this.Name = "Menu";
            this.Text = "Bomberman";
            this.pMenu.ResumeLayout(false);
            this.pOption.ResumeLayout(false);
            this.pOption.PerformLayout();
            this.pTwoPlayers.ResumeLayout(false);
            this.pTwoPlayers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pOption;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Panel pTwoPlayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCmdRight2;
        private System.Windows.Forms.TextBox tbCmdLeft2;
        private System.Windows.Forms.TextBox tbCmdDown2;
        private System.Windows.Forms.TextBox tbCmdUp2;
        private System.Windows.Forms.TextBox tbCmdRight1;
        private System.Windows.Forms.TextBox tbCmdLeft1;
        private System.Windows.Forms.TextBox tbCmdDown1;
        private System.Windows.Forms.TextBox tbCmdUp1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCmdBomb2;
        private System.Windows.Forms.TextBox tbCmdBomb1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCmdBomb3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCmdRight3;
        private System.Windows.Forms.TextBox tbCmdLeft3;
        private System.Windows.Forms.TextBox tbCmdDown3;
        private System.Windows.Forms.TextBox tbCmdUp3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox6;
    }
}

