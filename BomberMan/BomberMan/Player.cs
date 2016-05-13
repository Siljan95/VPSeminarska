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
        public int Score { get; set; }

        public Player(string n)
        {
            Name = n;
            Score = 0;
        }

        public Player(string n, int s)
        {
            Name = n;
            Score = s;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Score);
        }
    }
}
