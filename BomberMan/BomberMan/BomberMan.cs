using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BomberMan
{
    public class BomberMan
    {
        public enum DIRECTION
        {
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        public String Name { get; set; }
        public int Velocity { get; set; }
        private Point Point;
        private DIRECTION Direction;
        public int RADIUS { get; set; }
        public Color Color { get; set; }
        public Keys CommandUp { get; set; }
        public Keys CommandDown { get; set; }
        public Keys CommandLeft { get; set; }
        public Keys CommandRight { get; set; }
        public Keys CommandPutBomb { get; set; }
        public List<Bomb> Bombs { get; set; }
        public int NumberOfBombs { get; set; }     
        public Bitmap Character { get; set; }   

        /// <summary>
        ///  Initilazing the Name, the starting point
        ///  and the commands
        /// </summary>
        public BomberMan(String name, Point startingPoint, 
            Keys cUp, Keys cDown, Keys cLeft, Keys cRight, Keys putbomb)
        {
            Name = name;
            Point = new Point(startingPoint.X, startingPoint.Y);
            CommandUp = cUp;
            CommandDown = cDown;
            CommandLeft = cLeft;
            CommandRight = cRight;
            Velocity = 2;
            CommandPutBomb = putbomb;
            Bombs = new List<Bomb>();
            NumberOfBombs = 3;
            // absolute bitmap path no solution for relative for now!!!
            Character = new Bitmap(@"C: \Users\eniko\Desktop\FINKI\Cetvrt Semestar\Visual Programing\testGit\VPSeminarska\BomberMan\BomberMan\resources\char1.png");
        }

        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }

        public void Move(int width, int height)
        {
            if (Direction == DIRECTION.RIGHT)
            {
                Point.X += Velocity;
                if (Point.X >= width)
                {
                    Point.X = 0;
                }
            }
            if (Direction == DIRECTION.LEFT)
            {
                Point.X -= Velocity;
                if (Point.X < 0)
                {
                    Point.X = width - 1;
                }
            }
            if (Direction == DIRECTION.UP)
            {
                Point.Y -= Velocity;
                if (Point.Y < 0)
                {
                    Point.Y = height - 1;
                }
            }
            if (Direction == DIRECTION.DOWN)
            {
                Point.Y += Velocity;
                if (Point.Y >= height)
                {
                    Point.Y = 0;
                }
            }
        }

        /// <summary>
        /// Placing bombs on the map
        /// </summary>
        public void PlaceBomb()
        {
            if(NumberOfBombs > Bombs.Count)
            {
                Bomb nova = new Bomb(Point);
                Bombs.Add(nova);
            }
        }

        /// <summary>
        /// Drawing the BomberMan
        /// </summary>
        public void Draw(System.Drawing.Graphics g)
        {
           
            Brush brush = new SolidBrush(Color.Black);
            if (Direction == DIRECTION.RIGHT)
            {
                g.DrawImage(Character, Point);
            }
            if (Direction == DIRECTION.LEFT)
            {
                g.DrawImage(Character, Point);
            }
            if (Direction == DIRECTION.UP)
            {
                g.DrawImage(Character, Point);
            }
            if(Direction == DIRECTION.DOWN)
            {
                g.DrawImage(Character, Point);
            }
            foreach(Bomb b in Bombs)
            {
                b.Draw(g);
            }       
            brush.Dispose();
        }
    }
}
