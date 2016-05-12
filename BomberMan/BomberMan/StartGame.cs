using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BomberMan
{
    public partial class StartGame : Form
    {
        Scene scene;
        List<Keys> keys;
        bool flashTimer;
        int StartTime;
        Point[] startingPoints;
        int NumOfPlayers;
        List<Player> players;


        public StartGame(int numPlayers, List<Player> players)
        {
            InitializeComponent();
            DoubleBuffered = true;
            NumOfPlayers = numPlayers;
            this.players = players;
            startingPoints = new Point[3];

            startingPoints[0] = new Point(50, 50);
            lblNameP1.Text =players[0].Name;

            startingPoints[1] = new Point(450, 450);
            lblNameP2.Text = players[1].Name;

            if (numPlayers == 3)
            {
                startingPoints[2] = new Point(450, 50);
                gbPlayer3.Visible = true;
                lblNameP3.Text = players[2].Name;
            }
            newGame(NumOfPlayers, players);



        }

        public void newGame(int NumOfPlayers, List<Player> players)
        {
            scene = new Scene();
            scene.GenerateMap();
            keys = new List<Keys>();
            StartGameTimer.Start();
            flashTimer = false;
            //  point = new Point(50, 50);
            BomberMan b1 = new BomberMan(players[0].Name, startingPoints[0], Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.Space);
            b1.Key = startingPoints[0];

            //  point = new Point(450, 450);
            BomberMan b2 = new BomberMan(players[1].Name, startingPoints[1], Keys.W, Keys.S, Keys.A, Keys.D, Keys.E);
            b2.Key = startingPoints[1];
            BomberMan b3 = null;
            if (NumOfPlayers == 3) {
                b3 = new BomberMan(players[2].Name, startingPoints[2], Keys.NumPad8, Keys.NumPad5, Keys.NumPad4, Keys.NumPad6, Keys.NumPad0);
                b3.Key = startingPoints[2];
            }
            scene.AddPlayer(b1);
            scene.AddPlayer(b2);
            if (NumOfPlayers == 3)
                scene.AddPlayer(b3);

            //StartTime = 4;
            Invalidate();

        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            scene.Count();
           

            if (scene.checkGameOver())
            {
                endGame();
                scene.destroyMapTimer.Stop();
            }
           
            string[] time = lblTime.Text.Split(':');
            int min = int.Parse(time[0]);
            int sec = int.Parse(time[1]);
            if (pbTimer.Value > 0)
            {
                pbTimer.Value -= 1;
                if (sec == 0)
                {
                    min--;
                    sec = 59;
                }
                else
                    sec--;
                if (sec == 0 && min == 0)
                {

                    scene.destroyMapTimer.Start();

                }
                if (sec <= 10 && min == 0)
                {

                    flashTimer = !flashTimer;
                    if (flashTimer)
                    {
                        lblTime.ForeColor = Color.Red;
                        lblTime.BackColor = Color.Gold;

                    }
                    else {
                        lblTime.ForeColor = Color.Black;
                        lblTime.BackColor = Color.GreenYellow;
                    }

                }

                lblTime.Text = string.Format("{0}:{1:00}", min, sec);
            }
            foreach (BomberMan b in scene.BomberMen)
            {
                if (b.Name == lblNameP1.Text)
                {
                    lblScoreP1.Text = b.Score.ToString();
                    lblBombsP1.Text = b.NumberOfBombs.ToString();
                    lblSpeedP1.Text = b.Velocity.ToString();
                    lblRadiusP1.Text = b.ExplosionRadius.ToString();
                }
                else if (b.Name == lblNameP2.Text)
                {
                    lblScoreP2.Text = b.Score.ToString();
                    lblBombsP2.Text = b.NumberOfBombs.ToString();
                    lblSpeedP2.Text = b.Velocity.ToString();
                    lblRadiusP2.Text = b.ExplosionRadius.ToString();
                }
                else if (b.Name == lblNameP3.Text)
                {
                    lblScoreP3.Text = b.Score.ToString();
                    lblBombsP3.Text = b.NumberOfBombs.ToString();
                    lblSpeedP3.Text = b.Velocity.ToString();
                    lblRadiusP3.Text = b.ExplosionRadius.ToString();
                }
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            scene.MovePlayer(keys);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawMap(e.Graphics);
            scene.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (StartTime == 0)
            {
                if (!keys.Contains(e.KeyCode))
                    keys.Add(e.KeyCode);
                scene.MovePlayer(keys);
                Invalidate();
            }
        }

        

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
              if (StartTime == 0)
            {   
                if (keys.Contains(e.KeyCode))
                    keys.Remove(e.KeyCode);
                scene.MovePlayer(keys);
                Invalidate();
            }
        }

        private void StartGameTimer_Tick(object sender, EventArgs e)
        {
            StartTime = int.Parse(lblStartTime.Text);
            StartTime--;
            if (StartTime == 0)
            {
                StartGameTimer.Stop();
                timerCountDown.Start();
                timer2.Start();
                pStartingGame.Visible = false;
            }
            lblStartTime.Text = StartTime.ToString();
        }
        public void endGame()
        {
            lblInfo.Text = "Game Over!";
            lblWinner.Visible = true;
            lblStartTime.ForeColor = Color.Red;
            lblStartTime.Visible = false;
            lblWinner.Text = scene.checkGameStat();
            pStartingGame.Visible = true;

            btnExit.Enabled = true;
            btnExit.Visible = true;

            //using(FileStream sr = new FileStream("HighScore.txt", FileMode.Append))
            //{
            //    using (StreamReader read = new StreamReader(sr))
            //    {
            //        string s = String.Empty;
            //        while ((s = read.ReadLine()) != null)
            //        {
                        
            //        }
            //    }
            //}

            btnRematch.Visible = true;
            btnRematch.Enabled = true;

            timer2.Stop();
            timerCountDown.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRematch_Click(object sender, EventArgs e)
        {
            newGame(NumOfPlayers, players);

            btnExit.Enabled = false;
            btnExit.Visible = false;

            btnRematch.Visible = false;
            btnRematch.Enabled = false;

            lblWinner.Visible = false;
            lblStartTime.ForeColor = Color.Black;
            lblStartTime.Visible = true;
            pbTimer.Value = 300;
            //StartTime = 4;
            lblStartTime.Text = "4";
            lblTime.Text = "5:00";
            lblInfo.Text = "GAME STARTING";
            
        }

        
    }
}
