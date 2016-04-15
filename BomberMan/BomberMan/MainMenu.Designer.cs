namespace BomberMan
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
            this.pStart = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.pStart.SuspendLayout();
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
            this.pMenu.Controls.Add(this.pOptions);
            this.pMenu.Location = new System.Drawing.Point(1, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(751, 436);
            this.pMenu.TabIndex = 7;
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.btnBack);
            this.pStart.Controls.Add(this.btnTwo);
            this.pStart.Controls.Add(this.btnSingle);
            this.pStart.Controls.Add(this.button1);
            this.pStart.Controls.Add(this.button4);
            this.pStart.Location = new System.Drawing.Point(-2, -5);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(756, 444);
            this.pStart.TabIndex = 9;
            this.pStart.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBack.Font = new System.Drawing.Font("Wide Latin", 15F);
            this.btnBack.Location = new System.Drawing.Point(237, 315);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(274, 56);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTwo.Font = new System.Drawing.Font("Wide Latin", 15F);
            this.btnTwo.Location = new System.Drawing.Point(237, 226);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(274, 56);
            this.btnTwo.TabIndex = 8;
            this.btnTwo.Text = "Two Player";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.MouseLeave += new System.EventHandler(this.btnTwo_MouseLeave);
            this.btnTwo.MouseHover += new System.EventHandler(this.btnTwo_MouseHover);
            // 
            // btnSingle
            // 
            this.btnSingle.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSingle.Font = new System.Drawing.Font("Wide Latin", 15F);
            this.btnSingle.Location = new System.Drawing.Point(237, 134);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(274, 56);
            this.btnSingle.TabIndex = 7;
            this.btnSingle.Text = "Single Player";
            this.btnSingle.UseVisualStyleBackColor = false;
            this.btnSingle.MouseLeave += new System.EventHandler(this.btnSingle_MouseLeave);
            this.btnSingle.MouseHover += new System.EventHandler(this.btnSingle_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(237, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stat Game";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.Font = new System.Drawing.Font("Wide Latin", 10F);
            this.button4.Location = new System.Drawing.Point(280, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "Options";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pOptions
            // 
            this.pOptions.Location = new System.Drawing.Point(0, 0);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(750, 436);
            this.pOptions.TabIndex = 9;
            this.pOptions.Visible = false;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 435);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pStart);
            this.Name = "Menu";
            this.Text = "Bomberman";
            this.pMenu.ResumeLayout(false);
            this.pStart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Button btnOptions;
    }
}

