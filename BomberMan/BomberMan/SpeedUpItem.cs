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
        public Point Location { get; set; }

        public SpeedUpItem(Point location) : base("Speed Up")
        {
            Location = location;
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(SpeedUpLogo, Location);
        }
    }
}
