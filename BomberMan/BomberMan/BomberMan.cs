using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Color color;

        /// <summary>
        ///  Initilazing the Name and the starting point
        /// </summary>
        public BomberMan(String name, Point startingPoint)
        {
            color = Color.Black;
            Name = name;
            Point = new Point(startingPoint.X, startingPoint.Y);
            Velocity = 10;
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
               else if (Direction == DIRECTION.LEFT)
               {
                   g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
               }
               else if (Direction == DIRECTION.UP)
               {
                   g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
               }
               else
               {
                   g.FillEllipse(brush, Point.X, Point.Y, 30, 30);
               }
               
        }
    }
}
