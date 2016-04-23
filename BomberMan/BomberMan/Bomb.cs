using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace BomberMan
{
    public class Bomb 
    {
        public int BombRadius { get; set; }   
        public Point Cordinates { get; set; }
        public int CountDown { get; set; }
        public bool Exploded { get; set; }
        public Bitmap bomb { get; set; }

        public Bomb(Point c) 
        {
            //Staveno e random kje treba da se smeni vo zavisnost od mapata
            BombRadius = 10;
            CountDown = 3;
            Cordinates = c;
            Exploded = false;
            // absolute bitmap path
            bomb = new Bitmap(@"C:\Users\eniko\Desktop\FINKI\Cetvrt Semestar\Visual Programing\testGit\VPSeminarska\BomberMan\BomberMan\resources\bomb_v3.png");
            
               
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
                g.DrawLine(pen, Cordinates.X - BombRadius, Cordinates.Y, Cordinates.X + BombRadius, Cordinates.Y);
                g.DrawLine(pen, Cordinates.X, Cordinates.Y - BombRadius, Cordinates.X, Cordinates.Y + BombRadius);
                pen.Dispose();
            }
            else
            {
                Brush s = new SolidBrush(Color.Black);
                g.DrawImage(bomb,Cordinates);
                s.Dispose();
            }
        }
    }
}
