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


namespace BomberMan
{
    public partial class StartGame : Form
    {
        Point point;
        Scene scene;
        List<Keys> keys;
        bool flashTimer;



        public StartGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newGame();
            
            
        }

        public void newGame()
        {
            scene = new Scene();
            scene.GenerateMap();

            point = new Point(50, 50);
            BomberMan b1 = new BomberMan("Vikac", point, Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.NumPad0);
            b1.Key = point;

            //point = new Point(450, 50);
            //BomberMan b2 = new BomberMan("Zoki", point, Keys.NumPad8, Keys.NumPad5, Keys.NumPad4, Keys.NumPad6, Keys.NumPad0);
            //b2.Key = point;

            //point = new Point(50, 450);
            //BomberMan b3 = new BomberMan("Buce", point, Keys.U, Keys.J, Keys.H, Keys.K, Keys.Space);
            //b3.Key = point;

            point = new Point(450, 450);
            BomberMan b4 = new BomberMan("Emil", point, Keys.W, Keys.S, Keys.A, Keys.D, Keys.LShiftKey);
            b4.Key = point;

            scene.AddPlayer(b1);
            //scene.AddPlayer(b2);
            //scene.AddPlayer(b3);
            scene.AddPlayer(b4);
            keys = new List<Keys>();
            StartGameTimer.Start();
            
            flashTimer = false;

        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            scene.Count();
            

            if (scene.checkGameOver())
            {
                lblInfo.Text = "Game Over!";
                lblStartTime.ForeColor = Color.Red;
                lblStartTime.Visible = false;
                lblWinner.Text = scene.checkGameStat();
                pStartingGame.Visible = true;

            }
           
            string[] time = lblTime.Text.Split(':');
            int min = int.Parse(time[0]);
            int sec = int.Parse(time[1]);
            pbTimer.Value -= 1;
            if (sec == 0)
            {
                min--;
                sec = 59;
            }
            else
                sec--;
            if (sec == 0 && min == 0) { 
               // timerCountDown.Stop();
                // stopGame() 
                // destoyMap()
            }
            if (sec <= 10 && min == 0)
            {
                flashTimer = !flashTimer;
                if (flashTimer) { 
                    lblTime.ForeColor = Color.Red;
                    lblTime.BackColor = Color.Gold;

                }
                else { 
                    lblTime.ForeColor = Color.Black;
                    lblTime.BackColor = Color.GreenYellow;
                }
            
            }
            else
            lblTime.Text = string.Format("{0}:{1:00}", min, sec);
            
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
            if (!keys.Contains(e.KeyCode))
                keys.Add(e.KeyCode);
            scene.MovePlayer(keys);
            Invalidate();
        }

        

        private void StartGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode))
                keys.Remove(e.KeyCode);
            scene.MovePlayer(keys);
            Invalidate();
        }

        private void StartGameTimer_Tick(object sender, EventArgs e)
        {
            int time = int.Parse(lblStartTime.Text);
            time--;
            if (time == 0)
            {
                StartGameTimer.Stop();
                timerCountDown.Start();
                timer2.Start();
                pStartingGame.Visible = false;
            }
            
            lblStartTime.Text = time.ToString();
        }

    }
}
