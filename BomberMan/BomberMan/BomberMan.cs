using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public class BomberMan : Stats
    {

        /// <summary>
        /// Enumeration for the direction
        /// </summary>
        public enum DIRECTION
        {
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        public enum CHARACTER
        {
            Blue,
            Yellow,
            Red
        }

        CHARACTER type;
        /// <summary>
        /// Images for the character1 
        /// </summary>
        static public Bitmap[] Character1 = { Properties.Resources.char1, Properties.Resources.char1_back, Properties.Resources.char1_left, Properties.Resources.char1_right };

        /// <summary>
        /// Images for the character2
        /// </summary>
        static public Bitmap[] Character2 = { Properties.Resources.char2, Properties.Resources.char2_back, Properties.Resources.char2_left, Properties.Resources.char2_right };

        /// <summary>
        /// Images for the character3
        /// </summary>
        static public Bitmap[] Character3 = { Properties.Resources.char3, Properties.Resources.char3_back, Properties.Resources.char3_left, Properties.Resources.char3_right };


        /// <summary>
        /// Name of the player
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Current location on the map
        /// </summary>
        private Point Point;

        /// <summary>
        /// Direction in which the player is moving
        /// </summary>
        private DIRECTION Direction;

        /// <summary>
        /// Command for moving the player up
        /// </summary>
        public Keys CommandUp { get; set; }

        /// <summary>
        /// Command for moving the player down
        /// </summary>
        public Keys CommandDown { get; set; }

        /// <summary>
        /// Command for moving the player to the left
        /// </summary>
        public Keys CommandLeft { get; set; }

        /// <summary>
        /// Command for moving the player to the right
        /// </summary>
        public Keys CommandRight { get; set; }

        /// <summary>
        /// Command for placing bomb on the map
        /// </summary>
        public Keys CommandPutBomb { get; set; }

        /// <summary>
        /// All the bombs that the player placed
        /// </summary>
        public Dictionary<Point, Bomb> Bombs { get; set; }

        /// <summary>
        /// Invisible frame for the player
        /// </summary>
        public Rectangle Frame { get; set; }

        /// <summary>
        /// Point that tells the player in which tile he is in
        /// </summary>
        public Point Key { get; set; }

        /// <summary>
        /// Boolean that tells if the player is alive
        /// </summary>
        public bool IsAlive { get; set; }

        /// <summary>
        ///  Constructor for the player. Initilazing the Name, starting point, frame, commands
        ///  and the list for the bombs he placed
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="startingPoint">Starting point</param>
        /// <param name="cUp">Key for moving up</param>
        /// <param name="cDown">Key for moving down</param>
        /// <param name="cLeft">Key for moving left</param>
        /// <param name="cRight">Key for moving right</param>
        /// <param name="putbomb">Key for placing the bomb</param>
        public BomberMan(String name, Point startingPoint,
            Keys cUp, Keys cDown, Keys cLeft, Keys cRight, Keys putbomb, CHARACTER ch) : base(1, 1, 1)
        {
            Name = name;
            IsAlive = true;
            Point = new Point(startingPoint.X, startingPoint.Y);
            Key = Point;
            CommandUp = cUp;
            CommandDown = cDown;
            CommandLeft = cLeft;
            CommandRight = cRight;
            CommandPutBomb = putbomb;
            Bombs = new Dictionary<Point, Bomb>();
            Frame = new Rectangle(Point.X + 5, Point.Y + 5, 40, 40);
            type = ch;
        }


        /// <summary>
        /// Changes direction that the player is moving
        /// </summary>
        /// <param name="direction"></param>
        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }

        /// <summary>
        /// Moves the player in the given direction and creates an invisible frame around him
        /// </summary>
        public void Move()
        {
            if (Direction == DIRECTION.RIGHT)
            {
                Point.X += Velocity;
                Frame = new Rectangle(Point.X, Point.Y, 40, 40);
            }
            else if (Direction == DIRECTION.LEFT)
            {
                Point.X -= Velocity;
                Frame = new Rectangle(Point.X, Point.Y, 40, 40);
            }
            else if (Direction == DIRECTION.UP)
            {
                Point.Y -= Velocity;
                Frame = new Rectangle(Point.X, Point.Y, 40, 40);
            }
            else if (Direction == DIRECTION.DOWN)
            {
                Point.Y += Velocity;
                Frame = new Rectangle(Point.X, Point.Y, 40, 40);
            }
        }

        /// <summary>
        /// Calculates the pivots for the next tile
        /// </summary>
        /// <param name="pivotKey"></param>
        /// <param name="framePivot"></param>
        public void calculatePivots(ref Point pivotKey, ref Rectangle framePivot)
        {
            if (Direction == DIRECTION.RIGHT)
            {
                framePivot = new Rectangle(Point.X + Velocity, Point.Y, 45, 45);
                pivotKey = new Point(Key.X + 50, Key.Y);
            }
            else if (Direction == DIRECTION.LEFT)
            {
                framePivot = new Rectangle(Point.X - Velocity, Point.Y, 45, 45);
                pivotKey = new Point(Key.X - 50, Key.Y);
            }
            else if (Direction == DIRECTION.UP)
            {
                framePivot = new Rectangle(Point.X, Point.Y - Velocity, 45, 45);
                pivotKey = new Point(Key.X, Key.Y - 50);
            }
            else if (Direction == DIRECTION.DOWN)
            {
                framePivot = new Rectangle(Point.X, Point.Y + Velocity, 45, 45);
                pivotKey = new Point(Key.X, Key.Y + 50);
            }
        }


        /// <summary>
        /// Testing to see if the player can pass
        /// </summary>
        /// <returns>if he can pass</returns>
        public bool canPass(Dictionary<Point, Tile> Tiles)
        {
            Rectangle framePivot = new Rectangle();
            Point pivotKey = new Point();

            calculatePivots(ref pivotKey, ref framePivot);
            if (framePivot.IntersectsWith(Tiles[pivotKey].Rectangle))
            {
                if (!Tiles[pivotKey].IsPassable || Tiles[pivotKey].type == Tile.BLOCK_TYPE.Hard)
                {
                    return false;
                }
                else
                {
                    Key = pivotKey;
                }
            }

            foreach (KeyValuePair<Point, Bomb> b in Bombs)
            {
                Rectangle tempRect = new Rectangle(b.Value.Coordinates, new Size(30, 30));
                if (Frame.IntersectsWith(tempRect))
                {
                    return true;
                }
                else
                {
                    Tiles[b.Value.Coordinates].IsPassable = false;
                }
            }
            return true;
        }

        /// <summary>
        /// Placing bombs on the map
        /// </summary>
        public void PlaceBomb(Map Map)
        {
            if (NumberOfBombs > Bombs.Count)
            {
                if (!Map.Tiles[Key].ContainsBomb)
                {
                    Map.Tiles[Key].ContainsBomb = true;
                    Map.Tiles[Key].WhoPlaced = this;
                    Bomb nova = new Bomb(Map.Tiles[Key].Rectangle.Location, ExplosionRadius);
                    Bombs.Add(Key, nova);
                    Map.placedBombs.Add(Key, nova);
                }
            }
        }

        /// <summary>
        /// Drawing the BomberMan
        /// </summary>
        public void Draw(Graphics g)
        {
            if (type == CHARACTER.Blue)
            {
                if (Direction == DIRECTION.RIGHT)
                {
                    g.DrawImage(Character1[3], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.LEFT)
                {
                    g.DrawImage(Character1[2], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.UP)
                {
                    g.DrawImage(Character1[1], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.DOWN)
                {
                    g.DrawImage(Character1[0], Point.X, Point.Y, 45, 45);
                }
            }
            else if (type == CHARACTER.Yellow)
            {
                if (Direction == DIRECTION.RIGHT)
                {
                    g.DrawImage(Character2[3], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.LEFT)
                {
                    g.DrawImage(Character2[2], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.UP)
                {
                    g.DrawImage(Character2[1], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.DOWN)
                {
                    g.DrawImage(Character2[0], Point.X, Point.Y, 45, 45);
                }
            }
            else
            {
                if (Direction == DIRECTION.RIGHT)
                {
                    g.DrawImage(Character3[3], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.LEFT)
                {
                    g.DrawImage(Character3[2], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.UP)
                {
                    g.DrawImage(Character3[1], Point.X, Point.Y, 45, 45);
                }
                if (Direction == DIRECTION.DOWN)
                {
                    g.DrawImage(Character3[0], Point.X, Point.Y, 45, 45);
                }
            }
            foreach (KeyValuePair<Point, Bomb> b in Bombs)
            {
                b.Value.Draw(g);
            }
        }

        /// <summary>
        /// Sees which bomberman is in the tile that has fire in it and kills it
        /// </summary>
        /// <param name="Bombermen">List of all the Bombermen that are alive</param>
        /// <param name="tile">Tile that is currently on fire</param>
        public int Kill(List<BomberMan> Bombermen, Tile tile)
        {
            int sum = 0;
            if (tile.Rectangle.IntersectsWith(Frame))
            {
                sum -= 2500;
            }
            foreach (BomberMan b in Bombermen)
            {
                if (tile.Rectangle.IntersectsWith(b.Frame))
                {
                    b.IsAlive = false;
                    sum += 1000;
                }
            }
            return sum;
        }
    }
}
