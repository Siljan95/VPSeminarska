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
        public string Name { get; set; }
        public Point Position { get; set; }

        public Item(string name)
        {
            Name = name;
            Position = new Point();
        }

        public abstract void Draw(Graphics g);
    }
}
