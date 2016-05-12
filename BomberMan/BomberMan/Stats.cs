using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    public class Stats
    {
        /// <summary>
        /// Velocity of the player
        /// </summary>
        public int Velocity { get; set; }

        /// <summary>
        /// Number of bombs that the player can carry
        /// </summary>
        public int NumberOfBombs { get; set; }

        /// <summary>
        /// Explosion radius of the bomb
        /// </summary>
        public int ExplosionRadius { get; set; }

        /// <summary>
        /// Max velocity that the player can move
        /// </summary>
        public static readonly int MaxVelocity = 3;

        /// <summary>
        /// Max bombs that the player can carry
        /// </summary>
        public static readonly int MaxBombs = 4;

        /// <summary>
        /// Max radius that the bomb can explode
        /// </summary>
        public static readonly int MaxRadius = 3;

        private int score;

        public Stats(int v, int nb, int er)
        {
            Velocity = v;
            NumberOfBombs = nb;
            ExplosionRadius = er;
            score = 0;
        }

        /// <summary>
        /// Increase the number of bombs for the player
        /// </summary>
        public void IncreaseBombs()
        {
            if(MaxBombs > NumberOfBombs)
                NumberOfBombs++;
        }

        /// <summary>
        /// Increase the speed of the player
        /// </summary>
        public void IncreaseVelocity()
        {
            if(MaxVelocity >= Velocity)
                Velocity++;
        }

        /// <summary>
        /// Increase the radius of the explosion
        /// </summary>
        public void IncreaseExplosionRadius()
        {
            if(MaxRadius >= ExplosionRadius)
                ExplosionRadius++;
        }

        public void IncreaseScore(int s)
        {
            score += s;
            Debug.WriteLine("Socre:{0}", score);
        }

        public int Score
        {
            get
            {
                return score;
            }
        }
    }
}
