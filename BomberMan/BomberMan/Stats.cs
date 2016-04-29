using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    public class Stats
    {
        public int Velocity { get; set; }
        public int NumberOfBombs { get; set; }
        public int ExplosionRadius { get; set; }

        public Stats(int v, int nb, int er)
        {
            Velocity = v;
            NumberOfBombs = nb;
            ExplosionRadius = er;
        }
    }
}
