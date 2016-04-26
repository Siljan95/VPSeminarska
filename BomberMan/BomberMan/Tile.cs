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
        public bool Passable { get; set; }
        public bool IsHardBlock { get; }
        public Color Color { get; set; }
        public bool ContainsBomb { get; set; }

        public Tile(Rectangle r,Point point, bool isHardBlock, bool passable, Color c)
        {
            Point = point;
            Rectangle = r;
            IsHardBlock = isHardBlock;
            Passable = passable;
            Color = c;
            Center = new Point(point.X + Rectangle.Width / 2, point.Y + Rectangle.Height / 2);
            ContainsBomb = false;
        }

        public void DestroyBlock()
        {
            type = BLOCK_TYPE.Empty;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkGray);
            Brush b = new SolidBrush(Color);
            if (type == BLOCK_TYPE.Empty)
            {
                g.DrawRectangle(p, Rectangle);
            }
            else
            {
                g.DrawRectangle(p, Rectangle);
                g.FillRectangle(b, Rectangle);
            }

        }

    }
}
