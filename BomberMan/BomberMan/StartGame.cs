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
        List<Player> playersLocal;
        bool isNewHighScore;
        List<Char> name;
        int positionOfText;
        bool isGameOver;
        bool ifGameStarted;
        bool enteredKeyAfterEndGame;


        public StartGame(int numPlayers, List<Player> players)
        {
            InitializeComponent();
            DoubleBuffered = true;
            NumOfPlayers = numPlayers;
            this.players = players;
            startingPoints = new Point[3];

            startingPoints[0] = new Point(50, 50);
            lblNameP1.Text = players[0].Name;

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
            name = new List<char>();
            scene = new Scene();
            scene.GenerateMap();
            keys = new List<Keys>();
            StartGameTimer.Start();
            flashTimer = false;
            playersLocal = new List<Player>();
            isNewHighScore = false;
            isGameOver = false;
            gbHighScore.Visible = false;
            gbHighScore.Enabled = false;
            ifGameStarted = false;
            positionOfText = 0;
            enteredKeyAfterEndGame = false;

            //  point = new Point(50, 50);
            BomberMan b1 = new BomberMan(players[0].Name, startingPoints[0], Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.Space, BomberMan.CHARACTER.Blue);
            b1.Key = startingPoints[0];

            //  point = new Point(450, 450);
            BomberMan b2 = new BomberMan(players[1].Name, startingPoints[1], Keys.W, Keys.S, Keys.A, Keys.D, Keys.E, BomberMan.CHARACTER.Yellow);
            b2.Key = startingPoints[1];
            BomberMan b3 = null;

            if (NumOfPlayers == 3)
            {
                b3 = new BomberMan(players[2].Name, startingPoints[2], Keys.NumPad8, Keys.NumPad5, Keys.NumPad4, Keys.NumPad6, Keys.NumPad0, BomberMan.CHARACTER.Red);
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
                isGameOver = true;
                scene.destroyMapTimer.Stop();
                endGame();
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
        }

        private void updateStatus()
        {
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
            if (isNewHighScore)
            {
                if (enteredKeyAfterEndGame)
                {
                    timer2.Stop();
                    lblHighScore1.Text = "A A A";
                }
                else
                {
                    char[] c = lblHighScore1.Text.ToCharArray();
                    if (c[0] > (char)('A' + 24))
                        c[0] = c[2] = c[4] = (char)('A' - 1);
                    lblHighScore1.Text = string.Format("{0} {1} {2}", (char)(c[0] + 1), (char)(c[2] + 1), (char)(c[4] + 1));
                }
            }
            if(!isGameOver) {
                scene.MovePlayer(keys);
                Invalidate();
            }
            updateStatus();
            scene.RemovePlayers();
        }

        public void enterNewName(Keys key)
        {
            char[] c = lblHighScore1.Text.ToCharArray();
            if (key == Keys.Up)
            {
                c[positionOfText] = (char)(c[positionOfText] + 1);
            }
            if (key == Keys.Down)
            {
                c[positionOfText] = (char)(c[positionOfText] - 1);
            }

            if (c[positionOfText] > (char)('A' + 25))
                c[positionOfText] = ('A');
            if (c[positionOfText] < ('A'))
                c[positionOfText] = ('Z');
            lblHighScore1.Text = string.Format("{0} {1} {2}", c[0], c[2], c[4]);
            if (key == Keys.Space)
            {
                positionOfText += 2;
            }
            if (positionOfText > 4)
            {
                writeToFile();
            }
        }

        private void writeToFile()
        {
            isNewHighScore = false;
            string newName = lblHighScore1.Text.Replace(" ", "");
            playersLocal[playersLocal.Count - 1].Name = newName;
            playersLocal = playersLocal.OrderByDescending(x => x.Score).ToList();
            using (FileStream sr = new FileStream("HighScore.txt", FileMode.Create))
            {
                sr.Position = 0;
                using (StreamWriter wr = new StreamWriter(sr))
                {
                    string s = String.Empty;
                    foreach (Player p in playersLocal)
                    {
                        wr.WriteLine(p.ToString());
                    }
                    wr.Close();
                }
                sr.Close();
            }
            gbHighScore.Enabled = false;
            gbHighScore.Visible = false;
            btnExit.Enabled = true;
            btnExit.Visible = true;
            btnRematch.Visible = true;
            btnRematch.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawMap(e.Graphics);
            scene.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver && ifGameStarted)
            {
                if (!keys.Contains(e.KeyCode))
                    keys.Add(e.KeyCode);
                scene.MovePlayer(keys);
                Invalidate();
            }
        }

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (isNewHighScore)
            {
                enteredKeyAfterEndGame = true;
                enterNewName(e.KeyCode);
            }

            if (!isGameOver && ifGameStarted)
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
                ifGameStarted = true;
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
            keys.Clear();

            makeHighScore();
            if (!isNewHighScore)
            {
                btnExit.Enabled = true;
                btnExit.Visible = true;

                btnRematch.Visible = true;
                btnRematch.Enabled = true;
            }
            timerCountDown.Stop();
        }

        public void makeHighScore()
        {
            string[] parts;
            List<Player> playersThatPlayed = new List<Player>();

            using (FileStream sr = new FileStream("HighScore.txt", FileMode.Open))
            {
                using (StreamReader read = new StreamReader(sr))
                {
                    string s = String.Empty;
                    while ((s = read.ReadLine()) != null)
                    {
                        parts = s.Split(' ');
                        Player p = new Player(parts[0], Convert.ToInt32(parts[1]));
                        playersLocal.Add(p);
                    }
                    read.Close();
                }
                sr.Close();
            }
            playersThatPlayed = new List<Player>();
            Player p1 = new Player(lblNameP1.Text, Convert.ToInt32(lblScoreP1.Text));
            Player p2 = new Player(lblNameP2.Text, Convert.ToInt32(lblScoreP2.Text));
            Player p3 = new Player(lblNameP3.Text, Convert.ToInt32(lblScoreP3.Text));
            playersThatPlayed.Add(p1);
            playersThatPlayed.Add(p2);
            playersThatPlayed.Add(p3);
            playersThatPlayed = playersThatPlayed.OrderByDescending(x => x.Score).ToList();
            if (playersLocal.Count >= 10)
                foreach (Player player in playersLocal)
                {
                    if (playersThatPlayed[0].Score > player.Score)
                    {
                        p1 = playersThatPlayed[0];
                        isNewHighScore = true;
                    }
                }
            else
            {
                p1 = playersThatPlayed[0];
                isNewHighScore = true;
            }

            if (isNewHighScore)
            {
                gbHighScore.Enabled = true;
                gbHighScore.Visible = true;
                lblHighScore.Text = string.Format("Player {0} has made into the top 10 players\n Please enter your name", p1.Name);
                playersLocal = playersLocal.OrderByDescending(x => x.Score).ToList();
                if (playersLocal.Count > 10)
                    playersLocal.RemoveAt(playersLocal.Count - 1);
                playersLocal.Add(p1);
            }
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
            this.Focus();

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
