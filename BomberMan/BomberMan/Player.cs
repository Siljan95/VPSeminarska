using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    public class Player
    {
        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Score of the player
        /// </summary>
        private int score;

        public Player(string n)
        {
            Name = n;
            score = 0;
        }

        public Player(string n, int s)
        {
            Name = n;
            score = s;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}\n", Name, score);
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
