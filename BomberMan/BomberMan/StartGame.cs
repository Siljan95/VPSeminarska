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
        bool FirstTimePainting;

        public StartGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            scene = new Scene();
            point = new Point(50, 50);
            
            BomberMan b1 = new BomberMan("Vikac", point, Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.Space);
            b1.Color = Color.Aqua;

            point = new Point(Width - 105, Height - 130);
            BomberMan b2 = new BomberMan("Emil", point, Keys.W, Keys.S, Keys.A, Keys.D, Keys.E);

            b2.Color = Color.Yellow;

            scene.GenerateMap();

            scene.AddPlayer(b1);
            scene.AddPlayer(b2);

            FirstTimePainting = true;

            keys = new List<Keys>();
            

            timer1.Start();
            timer2.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            scene.Count();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //scene.MovePlayer(keys);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (FirstTimePainting)
            {
                FirstTimePainting = false;
            }
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
    }
}
