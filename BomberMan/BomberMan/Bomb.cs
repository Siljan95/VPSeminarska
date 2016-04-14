using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class Bomb : Item
    {
        public float BombRadius { get; set; }   
        public int CountDown { get; set; }


        public Bomb(string name) : base(name)
        {
            //Staveno e random kje treba da se smeni vo zavisnost od mapata
            BombRadius = 3;
            CountDown= 5;
        }

        //Treba da se implementira countdown na bombata pred da eksplodira
        public override void Action()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
