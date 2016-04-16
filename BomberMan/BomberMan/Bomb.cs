using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BomberMan
{
  public  class Bomb 
    {
        public int BombRadius { get; set; }   
      
        public Point Cordinates { get; set; }
        public int Timer { get; set; }
        public Brush Bomb_color { get; set; }

        public Bomb(Point c) 
        {
            //Staveno e random kje treba da se smeni vo zavisnost od mapata
            BombRadius = 10;
            Timer = 5;
            Bomb_color = new SolidBrush(Color.Black);
            Cordinates = c;
        }

        //Treba da se implementira countdown na bombata pred da eksplodira
        public  void Explode( Graphics g)
        {
            if (Timer != 0)
            {
                Timer -= 1;
            }
            else
            {
                Pen pen = new Pen(Color.Red, 5);
                g.DrawLine(pen, Cordinates.X - BombRadius, Cordinates.Y, Cordinates.X + BombRadius, Cordinates.Y);
                g.DrawLine(pen, Cordinates.X, Cordinates.Y - BombRadius, Cordinates.X, Cordinates.Y + BombRadius);
               
            }
        }
        

        public  void Draw(Graphics g)
        {
            Brush s = new SolidBrush(Color.Black);

            g.FillEllipse(s, Cordinates.X, Cordinates.Y, 15, 15);

         

        }
    }
}
