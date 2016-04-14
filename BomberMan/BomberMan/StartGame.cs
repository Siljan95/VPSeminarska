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
        BomberMan b;

        public StartGame()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            point = new Point(10, 10);
            b = new BomberMan("Player1", point);
            timer1.Start();
            Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            b.Draw(e.Graphics);
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                b.ChangeDirection(BomberMan.DIRECTION.UP);
            }
            if (e.KeyCode == Keys.Down)
            {
                b.ChangeDirection(BomberMan.DIRECTION.DOWN);
            }
            if (e.KeyCode == Keys.Right)
            {
                b.ChangeDirection(BomberMan.DIRECTION.RIGHT);
            }
            if (e.KeyCode == Keys.Left)
            {
                b.ChangeDirection(BomberMan.DIRECTION.LEFT);
            }
            b.Move(Width, Height);
            Invalidate();
        }
    }
}
