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
        private DIRECTION Direction;
        public Keys CommandUp { get; set; }
        public Keys CommandDown { get; set; }
        public Keys CommandLeft { get; set; }
        public Keys CommandRight { get; set; }
        public Keys CommandPutBomb { get; set; }
        //public Dictionary<Point, Bomb> Bombs { get; set; }
        public List<Bomb> Bombs{ get; set; }
        public int NumberOfBombs { get; set; }
        public Rectangle r { get; set; }
        public Bitmap Character { get; set; }
        public Point Key { get; set; }



        /// <summary>
        ///  Initilazing the Name, the starting point
        ///  and the commands
        /// </summary>
        public BomberMan(String name, Point startingPoint,
            Keys cUp, Keys cDown, Keys cLeft, Keys cRight, Keys putbomb)
        {
            Point = new Point(startingPoint.X, startingPoint.Y);
            CommandUp = cUp;
            CommandDown = cDown;
            CommandLeft = cLeft;
            CommandRight = cRight;
            Velocity = 1;
            CommandPutBomb = putbomb;
            Bombs = new List<Bomb>();
            NumberOfBombs = 5;
            r = new Rectangle(Point.X, Point.Y, 45, 45);

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
                r = new Rectangle(Point.X, Point.Y, 45, 45);
            }
            else if (Direction == DIRECTION.LEFT)
            {
                Point.X -= Velocity;
                r = new Rectangle(Point.X, Point.Y, 45, 45);
            }
            else if (Direction == DIRECTION.UP)
            {
                Point.Y -= Velocity;
                r = new Rectangle(Point.X, Point.Y, 45, 45);
            }
            else if (Direction == DIRECTION.DOWN)
            {
                Point.Y += Velocity;
                r = new Rectangle(Point.X, Point.Y, 45, 45);
            }
        }


        /// <summary>
        /// Testing to see if the player can move that way
        /// </summary>
        public bool canPass(Dictionary<Point, Tile> Map)
        {
            Point pivotKey = new Point();
            Rectangle rectanglePivot = new Rectangle();

            if (Direction == DIRECTION.DOWN)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y + Velocity, 45, 45);
                pivotKey = new Point(Key.X, Key.Y + 50);
            }
            if (Direction == DIRECTION.UP)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y - Velocity, 45, 45);
                pivotKey = new Point(Key.X, Key.Y - 50);
            }
            if (Direction == DIRECTION.RIGHT)
            {
                rectanglePivot = new Rectangle(Point.X + Velocity, Point.Y, 45, 45);
                pivotKey = new Point(Key.X + 50, Key.Y);
            }
            if (Direction == DIRECTION.LEFT)
            {
                rectanglePivot = new Rectangle(Point.X - Velocity, Point.Y, 45, 45);
                pivotKey = new Point(Key.X - 50, Key.Y);
            }

            if (rectanglePivot.IntersectsWith(Map[pivotKey].Rectangle))
            {
                if (!Map[pivotKey].Passable || Map[pivotKey].IsHardBlock)
                {
                    //Debug.WriteLine("You Shall Not Pass WHOOMSH!");
                    return false;
                }
                else
                {
                    Debug.WriteLine("You Will Pass");
                    Key = pivotKey;
                }
            }

            // TESTING IN PROGESs!!!
            foreach (Bomb b in Bombs)
            {
                //Vrednosta vo size se menja
                Rectangle tempRect = new Rectangle(b.Coordinates, new Size(30, 30));
                if(r.IntersectsWith(tempRect))
                {
                    return true;
                }
                else
                {
                    Map[b.Coordinates].Passable = false;
                }
            }
            return true;
        }

        /// <summary>
        /// Placing bombs on the map
        /// </summary>
        public void PlaceBomb(Dictionary<Point, Tile> Map)
        {
            if (NumberOfBombs > Bombs.Count)
            {
                if (!Map[Key].ContainsBomb)
                {
                    Map[Key].ContainsBomb = true;
                    Bomb nova = new Bomb(Map[Key].Point);
                    Bombs.Add(nova);
                }
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
                g.DrawImage(Character, Point.X,Point.Y, 45, 45);
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
            foreach(Bomb b in Bombs)
            {
                b.Draw(g);
            }       
            brush.Dispose();
        }
    }
}
