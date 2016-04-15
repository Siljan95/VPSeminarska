using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class Scene
    {
        public List<BomberMan> BomberMen { get; set; }

        public Scene()
        {
            BomberMen = new List<BomberMan>();
            
        }

        public void AddPlayer(BomberMan bomas)
        {
            BomberMen.Add(bomas);
        }

        public void Draw(Graphics g)
        {
            foreach(BomberMan b in BomberMen)
            {
                b.Draw(g);
            }
        }

    }
}
