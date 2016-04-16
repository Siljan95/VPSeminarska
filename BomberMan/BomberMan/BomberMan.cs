using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Treba da se implementira vo Constructor
        public Keys PutBomb { get; set; }

        /// <summary>
        ///  Initilazing the Name, the starting point
        ///  and the commands
        /// </summary>
        public BomberMan(String name, Point startingPoint, 
            Keys cUp, Keys cDown, Keys cLeft, Keys cRight)
        {
            Name = name;
            Point = new Point(startingPoint.X, startingPoint.Y);
            CommandUp = cUp;
            CommandDown = cDown;
            CommandLeft = cLeft;
            CommandRight = cRight;
            Velocity = 2;
            Color = new Color();
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
        /// Drawing the BomberMan
        /// </summary>
        public void Draw(System.Drawing.Graphics g)
        {
            Brush brush = new SolidBrush(Color.Black);
            if (Direction == DIRECTION.RIGHT)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
            }
            if (Direction == DIRECTION.LEFT)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
            }
            if (Direction == DIRECTION.UP)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
            }
            if(Direction == DIRECTION.DOWN)
            {
                g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
            }
            brush.Dispose();
        }
    }
}
