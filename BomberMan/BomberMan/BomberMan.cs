using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
        private Point center;
        public Rectangle rectanglePivot { get; set; }
        private DIRECTION Direction;
        public int RADIUS { get; set; }
        public Color Color { get; set; }
        public Keys CommandUp { get; set; }
        public Keys CommandDown { get; set; }
        public Keys CommandLeft { get; set; }
        public Keys CommandRight { get; set; }
        public Keys CommandPutBomb { get; set; }
        public Dictionary<Point, Bomb> Bombs { get; set; }
        public int NumberOfBombs { get; set; }
        public Rectangle r { get; set; }
        public Bitmap Character {get; set;}



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
            Bombs = new Dictionary<Point, Bomb>();
            NumberOfBombs = 1;
            RADIUS = 25;
            center = new Point(Point.X + (Point.X / 2), Point.Y + (Point.Y / 2));
            r = new Rectangle(Point.X, Point.Y, 40, 40);

            String absolutePath = Path.GetFullPath("..\\..\\");
            Character = new Bitmap(absolutePath + @"resources\char1.png");

        }

        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }

        public void Move()
        {
            if (Direction == DIRECTION.RIGHT)
            {
               
                Point.X += Velocity;
                center.X += Velocity;
                r = new Rectangle(Point.X, Point.Y, 40, 40);
                //pivot = new Point(center.X + RADIUS, center.Y);
              //  Debug.WriteLine("MOVE:Direction Right Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.LEFT)
            {
                Point.X -= Velocity;
                center.X -= Velocity;
                //pivot = new Point(center.X - RADIUS, center.Y);
                r = new Rectangle(Point.X, Point.Y, 45, 45);
              //  Debug.WriteLine("MOVE:Direction Left Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.UP)
            {
                Point.Y -= Velocity;
                center.Y -= Velocity;
                //pivot = new Point(center.X, center.Y - RADIUS);
                r = new Rectangle(Point.X, Point.Y, 45, 45);
              //  Debug.WriteLine("MOVE:Direction Up Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.DOWN)
            {
                Point.Y += Velocity;
                center.Y += Velocity;
                //pivot = new Point(center.X, center.Y + RADIUS);
                r = new Rectangle(Point.X, Point.Y, 45, 45);
              //  Debug.WriteLine("MOVE:Direction Down Center:{0}, Pivot:{1}", center, pivot);
            }
        }

        public bool canPass(Tile[,] Map)
        {
            Point p;
            Tile t = new Tile();
            Tile t1 = new Tile();
            bool canPass = true;

            if (Direction == DIRECTION.DOWN)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y + Velocity, 40, 40);
            }
            if (Direction == DIRECTION.UP)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y - Velocity, 40, 40);
            }
            if (Direction == DIRECTION.RIGHT)
            {
                rectanglePivot = new Rectangle(Point.X + Velocity, Point.Y, 40, 40);
            }
            if (Direction == DIRECTION.LEFT)
            {
                rectanglePivot = new Rectangle(Point.X - Velocity, Point.Y, 40, 40);
            }

            bool flag = true;
            for (int i = 0; i < 11; i++)
            {
                Parallel.For(0, 11, (j, ParallelLoopResult) =>
               {
                   if (rectanglePivot.IntersectsWith(Map[i, j].Rectangle))
                   {
                       if (!Map[i, j].Passable)
                       {
                           //Debug.WriteLine("HAcked");
                           flag = false;
                           ParallelLoopResult.Stop();
                       }
                   }
               });
                if (!flag)
                {
                    return false;
                }
            }



            // TESTING IN PROGESs!!!
            foreach (KeyValuePair<Point, Bomb> b in Bombs)
            {
                if (distance(b.Value.Center, center) <= b.Value.Radius && b.Value.CanPass)
                {
                    return true;
                }
                else
                {
                    b.Value.CanPass = false;
                }
            }
            return true;
        }


        public double distance(Point t, Point p)
        {
            return Math.Sqrt((p.X - t.X) * (p.X - t.X)) + ((p.Y - t.Y) * (p.Y - t.Y));
        }

        /// <summary>
        /// Placing bombs on the map
        /// </summary>
        public void PlaceBomb(Tile[,] Map)
        {
            Point p = new Point();
            if (NumberOfBombs > Bombs.Count)
            {
                for (int i = 0; i < 11; i++)
                {
                    Parallel.For(0, 11, (j, ParallelLoopResult) =>
                    {
                        if (distance(Map[i, j].Point, Point) <= Map[i, j].Radius)
                        {
                            if (Map[i, j].Passable)
                            {
                                p = Map[i, j].Point;
                                //Debug.WriteLine("HAcked");
                                ParallelLoopResult.Stop();
                            }
                        }
                    });
                }
                Bomb nova = new Bomb(p);
                Bombs.Add(p, nova);
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
                g.DrawImage(Character, Point.X,Point.Y,45, 45);
            }
            if (Direction == DIRECTION.LEFT)
            {
                g.DrawImage(Character, Point.X, Point.Y, 45, 45);
            }
            if (Direction == DIRECTION.UP)
            {
                g.DrawImage(Character, Point.X, Point.Y, 45, 45);
            }
            if(Direction == DIRECTION.DOWN)
            {
                g.DrawImage(Character, Point.X, Point.Y, 45, 45);
            }
            foreach(KeyValuePair<Point, Bomb> b in Bombs)
            {
                b.Value.Draw(g);
            }       
            brush.Dispose();
        }
    }
}
