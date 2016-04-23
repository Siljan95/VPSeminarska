using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BomberMan
{
    public class Tile
    {
        public enum BLOCK_TYPE
        {
            Hard,
            Soft,
            Empty
        }

        public BLOCK_TYPE type { get; set; }
        public Rectangle Rectangle { get; set; }
        public Point Point { get; set; }
        public Point Center { get; set; }
        public float Radius { get; }
        public bool Passable { get; set; }
        public bool IsHardBlock { get; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public int I { get; set; }
        public int J { get; set; }
      

        public Tile():base()
        {
            Passable = true;
            IsHardBlock = false;
            Width = 0;
            Height = 0;
            Color = Color.Empty;
            I = 0;
            J = 0;
            
        }

        public Tile(Rectangle r,Point point, bool isHardBlock, bool passable, int width, int height, Color c, int i, int j)
        {
            Point = point;
            Rectangle = r;
            Width = width;
            Height = height;
            IsHardBlock = isHardBlock;
            Passable = passable;
            Color = c;
            Radius = 25;
            Center = new Point(point.X + Width/2, point.Y + Height/2);
            I = i;
            J = j;
        }

        public void DestroyBlock()
        {
            type = BLOCK_TYPE.Empty;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkGray);
            Brush b = new SolidBrush(Color);
            if (type == BLOCK_TYPE.Hard)
            {
                g.DrawRectangle(p, Rectangle);
                g.FillRectangle(b, Rectangle);
            }
            else if (type == BLOCK_TYPE.Soft)
            {
                g.DrawRectangle(p, Rectangle);
                g.FillRectangle(b, Rectangle);
            }
            else if (type == BLOCK_TYPE.Empty)
            {
                g.DrawRectangle(p, Rectangle);
            }

        }

        public float makeCircleRadius()
        {
            int r = Width/2;
            return r;
        }
    }
}
