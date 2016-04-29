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
        public Rectangle Location { get; set; }

        public IncreaseRadiusItem(Rectangle location) : base("Bomb radius")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpRaduis, Location);
        }

        public override void PowerUp(BomberMan b)
        {
            b.Stats.IncreaseExplosionRadius();
        }

        public override Rectangle getLocation()
        {
            return Location;
        }
    }
}
