using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbasedAdventure
{
    internal class Player
    {
        public int hp;
        public int maxHp;
        public int dam;
        public int def;
        public int coins;
        public int Pos;
        public void playerStart()
        {
            this.hp = 30;
            this.maxHp = 30;
            this.dam = 5;
            this.def = 0;
            this.coins = 0;
            this.Pos = 0;

        }
    }
}
