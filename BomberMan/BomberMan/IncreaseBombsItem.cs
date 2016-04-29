using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class IncraseBombsItem : Item
    {
        public static Bitmap PowerUpBombs;
        public Point Location { get; set; }

        public IncraseBombsItem(Point location) : base("Bomb +")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpBombs, Location);
        }
    }
}
