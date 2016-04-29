using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class SpeedUpItem : Item
    {
        static public Bitmap SpeedUpLogo = new Bitmap(Properties.Resources.PowerUpSpeed);
        public Rectangle Location { get; set; }

        public SpeedUpItem(Rectangle location) : base("Speed Up")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(SpeedUpLogo, Location);
        }

        public override Rectangle getLocation()
        {
            return Location;
        }

        public override void PowerUp(BomberMan b)
        {
            b.Stats.IncreaseVelocity();
        }
    }
}
