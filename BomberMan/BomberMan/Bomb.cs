using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public class Bomb 
    {
        static public Bitmap BombImage = new Bitmap(Properties.Resources.bomb_v3);
        static public Bitmap ExplodeImg = new Bitmap(Properties.Resources.exlode);
        static public Bitmap BombRed = new Bitmap(Properties.Resources.bomb_v3_red);
        public int ExplodesionRadius { get; set; }
        public Point Coordinates { get; set; }
        public int CountDown { get; set; }
        public bool Exploded { get; set; }
        public bool flash;
        public Timer time;
        public int ExplodeTime { get; set; }
        

        public Bomb(Point c, int exRadius) 
        {
            
            //Staveno e random kje treba da se smeni vo zavisnost od mapata
            ExplodesionRadius = exRadius;
            CountDown = 5;
            Coordinates = c;
            Exploded = false;
            flash = false;
            time = new Timer();
            ExplodeTime = -1;
            
            
        }

        // tick za trepkanje na bombata pred da eksplodira 
        private void bomb_Tick(object sender, EventArgs e)
        {
            flash = !flash;
        }

            // Proverka dali bombata ekslpodirala
        public bool Explode()
        {
            if (CountDown == 1)
            {
                time.Tick += new EventHandler(bomb_Tick);
                time.Interval = 150;
                time.Start();
            }
            if (CountDown == 0)
                Exploded = true;
            return Exploded;
        }

        // Iscrtuvawe na bombata 
        public void Draw(Graphics g)
        {
            if (ExplodeTime >= 0)
            {
                g.DrawImage(ExplodeImg, Coordinates);
            }
            else if (flash)
                g.DrawImage(BombRed, Coordinates.X, Coordinates.Y, 50, 50);
               
            else
            {
                g.DrawImage(BombImage, Coordinates.X, Coordinates.Y, 50, 50);
            }
        }
    }
}
