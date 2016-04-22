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
        private Point center;
        public Point pivot { get; set; }
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
            RADIUS = 25;
            center = new Point(Point.X + (Point.X / 2), Point.Y + (Point.Y / 2));
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
                pivot = new Point(center.X + RADIUS, center.Y);
                Debug.WriteLine("MOVE:Direction Right Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.LEFT)
            {
                Point.X -= Velocity;
                center.X -= Velocity;
                pivot = new Point(center.X - RADIUS, center.Y);
                Debug.WriteLine("MOVE:Direction Left Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.UP)
            {
                Point.Y -= Velocity;
                center.Y -= Velocity;
                pivot = new Point(center.X, center.Y - RADIUS);
                Debug.WriteLine("MOVE:Direction Up Center:{0}, Pivot:{1}", center, pivot);
            }
            else if (Direction == DIRECTION.DOWN)
            {
                Point.Y += Velocity;
                center.Y += Velocity;
                pivot = new Point(center.X, center.Y + RADIUS);
                Debug.WriteLine("MOVE:Direction Down Center:{0}, Pivot:{1}", center, pivot);
            }
        }

        public bool canPass(Tile[,] Map)
        {
            bool willPass = true;
            Point p;
            Tile t = new Tile();
            Tile t1 = new Tile();

            if (Direction == DIRECTION.DOWN)
            {
                p = new Point(pivot.X, pivot.Y + 25);
                //p = new Point(center.X, center.Y + 25);
                Debug.WriteLine("canPass: Direction Down Pivot:{0}", p);
                
            }
            if (Direction == DIRECTION.UP)
            {
                p = new Point(pivot.X, pivot.Y - 25);
                //p = new Point(center.X, center.Y - 25);
                Debug.WriteLine("canPass: Direction Up Pivot:{0}", p);
            }
            if (Direction == DIRECTION.LEFT)
            {
                p = new Point(pivot.X - 25, pivot.Y);
                //p = new Point(center.X - 25, center.Y);
                Debug.WriteLine("canPass: Direction Left Pivot:{0}", p);
            }
            if (Direction == DIRECTION.RIGHT)
            {
                p = new Point(pivot.X + 25, pivot.Y);
                //p = new Point(center.X + 25, center.Y);
                Debug.WriteLine("canPass: Direction Right Pivot:{0}", p);
            }

            if (t != null)
            {
                t1 = t;
            }
            Debug.WriteLine("Point.X%11:{0}, Point.Y%11{1}, Map[Point.X%11, Point.Y%11].Point:{2}", Point.X % 50, Point.Y % 50, Map[Point.X % 50, Point.Y % 50].Point);

            if(Point == Map[Point.X/50, Point.Y/50].Point)
            {
                Debug.WriteLine("We finaly Made It");
                if (!t1.Passable)
                {
                    //Debug.WriteLine("{0}: Distance {1}, Center of Player{2}, Radius of tile:{3}, IsHardBlock: {4},  {5} {6}", i++, distance(t.Center, center), center.ToString(), t.Radius, t.IsHardBlock.ToString(), t.I, t.J);
                    Debug.WriteLine("We finaly Made It All The Way");
                    willPass = false;
                }
            }
            return willPass;
        }
            


        public double distance(Point t, Point p)
        {
            return Math.Sqrt((((p.X + Velocity) - t.X) * ((p.X + Velocity) - t.X)) + (((p.Y + Velocity) - t.Y) * ((p.Y + Velocity) - t.Y)));
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
                g.FillEllipse(brush, Point.X, Point.Y, 50, 50);
            }
            if (Direction == DIRECTION.LEFT)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 50, 50);
            }
            if (Direction == DIRECTION.UP)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 50, 50);
            }
            if(Direction == DIRECTION.DOWN)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 50, 50);
            }
            foreach(Bomb b in Bombs)
            {
                b.Draw(g);
            }       
            brush.Dispose();
        }
    }
}
