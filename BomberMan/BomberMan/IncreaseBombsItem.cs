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
        public static Bitmap PowerUpBombs = new Bitmap(Properties.Resources.PowerUpBomb_);
        public Rectangle Location { get; set; }

        public IncraseBombsItem(Rectangle location) : base("Bomb +")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpBombs, Location);
        }

        public override Rectangle getLocation()
        {
            return Location;
        }

        public override void PowerUp(BomberMan b)
        {
            b.Stats.IncreaseBombs();
        }
    }
}
