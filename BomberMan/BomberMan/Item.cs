using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    public abstract class Item
    {
        /// <summary>
        /// The name of the Item
        /// </summary>
        public string Name { get; set; }

        public Item(string n)
        {
            Name = n;
        }

        public abstract Rectangle getLocation();
        public abstract void Draw(Graphics g);
        public abstract void PowerUp(BomberMan b);
    }
}
