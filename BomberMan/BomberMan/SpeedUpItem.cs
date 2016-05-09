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

        /// <summary>
        /// Image for speedUp Item
        /// </summary>
        static public Bitmap SpeedUpLogo = new Bitmap(Properties.Resources.PowerUpSpeed);

        /// <summary>
        /// Frame for the location of the SpeedUpItem
        /// </summary>
        public Rectangle Location { get; set; }

        /// <summary>
        /// Constructor for the SpeedUpItem
        /// </summary>
        /// <param name="location">Where is the item placed on the map</param>
        public SpeedUpItem(Rectangle location) : base("Speed Up")
        {
            Location = location;
        }

        /// <summary>
        /// Drawing the SpeedUpItem
        /// </summary>
        /// <param name="g">Grapics that is used to draw the item</param>
        public override void Draw(Graphics g)
        {
            g.DrawImage(SpeedUpLogo, Location);
        }

        /// <summary>
        /// Gets the location of the SpeedUpItem item
        /// </summary>
        /// <returns>Point where the item is placed</returns>
        public override Rectangle getLocation()
        {
            return Location;
        }

        /// <summary>
        /// Increase the speed of the player
        /// </summary>
        public override void PowerUp(BomberMan b)
        {
            b.IncreaseVelocity();
        }
    }
}
