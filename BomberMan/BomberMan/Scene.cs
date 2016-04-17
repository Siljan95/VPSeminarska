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

        public void AddPlayer(BomberMan bomberMan)
        {
            BomberMen.Add(bomberMan);
        }

        public void Count()
        {
            foreach (BomberMan b in BomberMen)
            {
                foreach (Bomb bomb in b.Bombs)
                {
                    bomb.CountDown -= 1;
                }
            }
        }

        public void Draw(Graphics g)
        {
            bool flag = false;
            int position = 0;
            foreach(BomberMan b in BomberMen)
            {
                b.Draw(g);
                for(int i = 0; i < b.Bombs.Count; i++)
                {
                    flag = b.Bombs[i].Explode(g);
                    if (flag)
                    {
                        position = i;
                    }
                }
                if (flag)
                {
                    flag = false;
                    b.Bombs.RemoveAt(position);
                }
                
            }
        }

    }
}
