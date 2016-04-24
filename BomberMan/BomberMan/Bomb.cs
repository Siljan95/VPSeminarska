using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace BomberMan
{
    public class Bomb 
    {
        public int ExplodesionRadius { get; set; }
        public int Radius { get; set; }
        public Point Cordinates { get; set; }
        public Point Center { get; set; }
        public int CountDown { get; set; }
        public bool Exploded { get; set; }
        public Bitmap BombImage { get; set; }
        public bool CanPass { get; set; }

        public Bomb(Point c) 
        {
            Radius = 32;
            //Staveno e random kje treba da se smeni vo zavisnost od mapata
            ExplodesionRadius = 10;
            CountDown = 3;
            Cordinates = c;
            Exploded = false;
            String absolutePath = Path.GetFullPath("..\\..\\");
            BombImage = new Bitmap(absolutePath + @"resources\bomb_v3.png");
            Center = new Point(c.X + (c.X / 2), c.Y + (c.Y / 2));
            CanPass = true;
            //Debug.WriteLine("Coordinate X:{0}, Coordinate Y:{1}", Cordinates.X, Cordinates.Y);
            //Debug.WriteLine("Center coordinate X:{0}, Center coordinate Y:{1}", Center.X, Center.Y);
        }

        //Treba da se implementira countdown na bombata pred da eksplodira
        public bool Explode(Graphics g)
        {
            if (CountDown < 0)
            {
                Exploded = true;
            }
            return Exploded;
        }
        

        public void Draw(Graphics g)
        {
            if (Exploded)
            {
                Pen pen = new Pen(Color.Red, 5);
                g.DrawLine(pen, Cordinates.X - ExplodesionRadius, Cordinates.Y, Cordinates.X + ExplodesionRadius, Cordinates.Y);
                g.DrawLine(pen, Cordinates.X, Cordinates.Y - ExplodesionRadius, Cordinates.X, Cordinates.Y + ExplodesionRadius);
                pen.Dispose();
            }
            else
            {
                Brush s = new SolidBrush(Color.Black);
                g.DrawImage(BombImage, Cordinates);
                s.Dispose();
            }
        }
    }
}
