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
        /// <summary>
        /// Image for increaseBomb Item
        /// </summary>
        public static Bitmap PowerUpBombs = new Bitmap(Properties.Resources.PowerUpBomb_);

        /// <summary>
        /// Frame for the location of the IncraseBombsItem
        /// </summary>
        public Rectangle Location { get; set; }

        /// <summary>
        /// Constructor for the IncraseBombsItem
        /// </summary>
        /// <param name="location">Where is the item placed on the map</param>
        public IncraseBombsItem(Rectangle location) : base("Bomb +")
        {
            Location = location;
        }

        /// <summary>
        /// Drawing the IncraseBombsItem
        /// </summary>
        /// <param name="g">Grapics that is used to draw the item</param>
        public override void Draw(Graphics g)
        {
            g.DrawImage(PowerUpBombs, Location);
        }

        /// <summary>
        /// Gets the location of the IncraseBombsItem item
        /// </summary>
        /// <returns>Point where the item is placed</returns>
        public override Rectangle getLocation()
        {
            return Location;
        }

        /// <summary>
        /// Increase the bombs that the player can carry
        /// </summary>
        public override void PowerUp(BomberMan b)
        {
            b.IncreaseBombs();
        }
    }
}
