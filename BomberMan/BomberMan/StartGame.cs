using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class StartGame : Form
    {
        Point point;
        Scene scene;
        Bomb s;

        public StartGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newGame();
            s = new Bomb(new Point(0,0));
        }

        public void newGame()
        {
            scene = new Scene();
            point = new Point(10, 10);
            
            BomberMan b1 = new BomberMan("Vikac", point, Keys.Up, Keys.Down, Keys.Left, Keys.Right, Keys.Space);
            b1.Color = Color.Aqua;

            point = new Point(Width - 100, Height - 100);
            BomberMan b2 = new BomberMan("Emil", point, Keys.W, Keys.S, Keys.A, Keys.D, Keys.E);

            b2.Color = Color.Yellow;

            scene.AddPlayer(b1);
            scene.AddPlayer(b2);

            timer1.Start();
            Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            s.Draw(e.Graphics);
            s.Explode(e.Graphics);
           
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (BomberMan b in scene.BomberMen)
            {
                if (e.KeyCode == b.CommandUp)
                {
                    b.ChangeDirection(BomberMan.DIRECTION.UP);
                    b.Move(Width, Height);
                }
                if (e.KeyCode == b.CommandDown)
                {
                    b.ChangeDirection(BomberMan.DIRECTION.DOWN);
                    b.Move(Width, Height);
                }
                if (e.KeyCode == b.CommandRight)
                {
                    b.ChangeDirection(BomberMan.DIRECTION.RIGHT);
                    b.Move(Width, Height);
                }
                if (e.KeyCode == b.CommandLeft)
                {
                    b.ChangeDirection(BomberMan.DIRECTION.LEFT);
                    b.Move(Width, Height);
                }
                if(e.KeyCode == Keys.Space)
                {
                    s = new Bomb( new Point ( Width, Height ));
                }
              
                Invalidate();
            }
        }
    }
}
