using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public class Bomb
    {
        /// <summary>
        /// Image for the bomb image
        /// </summary>
        static public Bitmap BombImage = new Bitmap(Properties.Resources.bomb_v3);

        /// <summary>
        /// Image for the explosion
        /// </summary>
        static public Bitmap ExplodeImg = new Bitmap(Properties.Resources.exlode);

        /// <summary>
        /// Image when the bomb is about to explode
        /// </summary>
        static public Bitmap BombRed = new Bitmap(Properties.Resources.bomb_v3_red);

        /// <summary>
        /// Radius of explosion measured in tiles
        /// </summary>
        public int ExplodesionRadius { get; set; }

        /// <summary>
        /// Coordinates where the bomb is placed
        /// </summary>
        public Point Coordinates { get; set; }

        /// <summary>
        /// Time to explosion
        /// </summary>
        public int CountDown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool flash;

        /// <summary>
        /// Timer that flashes the bomb before it explodes
        /// </summary>
        public Timer time;

        public Bomb(Point c, int exRadius)
        {
            ExplodesionRadius = exRadius;
            CountDown = 5;
            Coordinates = c;
            flash = false;
            time = new Timer();
        }

        /// <summary>
        /// Timer that flashes the bomb before it explodes
        /// </summary>
        private void bombFlash_Tick(object sender, EventArgs e)
        {
            flash = !flash;
        }

        /// <summary>
        /// Checks if the bomb has exploded
        /// </summary>
        /// <returns>Weather the bomb has exploded or not</returns>
        public bool Explode()
        {
            if (CountDown == 1)
            {
                time.Tick += new EventHandler(bombFlash_Tick);
                time.Interval = 150;
                time.Start();
            }
            if (CountDown == 0)
            {
                time.Stop();
                time.Dispose();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Draws the bomb
        /// </summary>
        public void Draw(Graphics g)
        {
            if (flash)
                g.DrawImage(BombRed, Coordinates.X, Coordinates.Y, 50, 50);

            else
                g.DrawImage(BombImage, Coordinates.X, Coordinates.Y, 50, 50);
        }
    }
}
