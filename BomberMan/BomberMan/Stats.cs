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

        public static readonly int MaxVelocity = 3;
        public static readonly int MaxBombs = 4;
        public static readonly int MaxRadius = 3;

        public Stats(int v, int nb, int er)
        {
            Velocity = v;
            NumberOfBombs = nb;
            ExplosionRadius = er;
        }

        public void IncreaseBombs()
        {
            if(MaxBombs > NumberOfBombs)
                NumberOfBombs++;
        }

        public void IncreaseVelocity()
        {
            if(MaxVelocity >= Velocity)
                Velocity++;
        }

        public void IncreaseExplosionRadius()
        {
            if(MaxRadius >= ExplosionRadius)
                ExplosionRadius++;
        }
    }
}
