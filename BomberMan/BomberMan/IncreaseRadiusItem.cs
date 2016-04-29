using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class IncreaseRadiusItem : Item
    {
        public static Bitmap PowerUpRaduis = new Bitmap(Properties.Resources.PowerUpBombR);
        public Point Location { get; set; }

        public IncreaseRadiusItem(Point location) : base("Bomb radius")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpRaduis, Location);
        }
    }
}
