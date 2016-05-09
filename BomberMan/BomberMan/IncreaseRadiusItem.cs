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
        /// <summary>
        /// Image for powerUpRadius Item
        /// </summary>
        public static Bitmap PowerUpRaduis = new Bitmap(Properties.Resources.PowerUpBombR);

        /// <summary>
        /// Frame for the location of the IncreaseRadiusItem
        /// </summary>
        public Rectangle Location { get; set; }

        /// <summary>
        /// Constructor for the IncreaseRadiusItem
        /// </summary>
        /// <param name="location">Where is the item placed on the map</param>
        public IncreaseRadiusItem(Rectangle location) : base("Bomb radius")
        {
            Location = location;
        }

        /// <summary>
        /// Drawing the IncreaseRadiusItem
        /// </summary>
        /// <param name="g">Grapics that is used to draw the item</param>
        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpRaduis, Location);
        }

        /// <summary>
        /// Increase the radius of the bomb
        /// </summary>
        public override void PowerUp(BomberMan b)
        {
            b.IncreaseExplosionRadius();
        }

        /// <summary>
        /// Gets the location of the PowerUpRaduis item
        /// </summary>
        /// <returns>Point where the item is placed</returns>
        public override Rectangle getLocation()
        {
            return Location;
        }
    }
}
