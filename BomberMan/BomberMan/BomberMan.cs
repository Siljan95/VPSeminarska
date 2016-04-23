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
        public Rectangle rectanglePivot { get; set; }
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
            Bombs = new List<Bomb>();
            NumberOfBombs = 3;
            RADIUS = 25;
            center = new Point(Point.X + (Point.X / 2), Point.Y + (Point.Y / 2));
            r = new Rectangle(Point.X, Point.Y, 40, 40);
            Character = new Bitmap(@"C:\Users\eniko\Desktop\FINKI\Cetvrt Semestar\Visual Programing\testGit\VPSeminarska\BomberMan\BomberMan\resources\char1.png");
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

            if(Direction == DIRECTION.DOWN)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y + Velocity, 40, 40);
            }
            if(Direction == DIRECTION.UP)
            {
                rectanglePivot = new Rectangle(Point.X, Point.Y - Velocity, 40, 40);
            }
            if(Direction == DIRECTION.RIGHT)
            {
                rectanglePivot = new Rectangle(Point.X + Velocity, Point.Y, 40, 40);
            }
            if(Direction == DIRECTION.LEFT)
            {
                rectanglePivot = new Rectangle(Point.X - Velocity, Point.Y, 40, 40);
            }
            
           
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                   if (rectanglePivot.IntersectsWith(Map[i,j].Rectangle))
                    {
                        if (!Map[i, j].Passable) {
                           // Debug.WriteLine("HAcked");
                        return false;
                        }
                    }
                   

                }
               
            }

            // TESTING IN PROGESs!!!
            foreach (Bomb b in Bombs)
            {

                if (Point.X == b.Cordinates.X && Point.Y == b.Cordinates.Y)
                {
                    canPass = true;
                    
                }

               else  if (rectanglePivot.IntersectsWith(new Rectangle(b.Cordinates.X, b.Cordinates.Y, 40, 40)) && canPass == true)
                {
                    Debug.WriteLine("NORect");
                    canPass = true;
                    

                }
               else  if (!rectanglePivot.IntersectsWith(new Rectangle(b.Cordinates.X, b.Cordinates.Y, 40, 40)) )
                {
                    Debug.WriteLine("RECT");
                    canPass = true;
                   


                }
                 
                    



            }
            return canPass;
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
            foreach(Bomb b in Bombs)
            {
                b.Draw(g);
            }       
            brush.Dispose();
        }
    }
}
