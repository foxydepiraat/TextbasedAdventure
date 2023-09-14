using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbasedAdventure
{
    internal class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Dam { get; set; } 
        public int Def { get; set; }
        public int Coins { get; set; }
        public int Pos { get; set; }
        public void playerStart(int hp, int maxhp, int dam, int def, int coins, int pos)
        {
            this.Name = "user";
            this.Hp = hp;
            this.MaxHp = maxhp;
            this.Dam = dam;
            this.Def = def;
            this.Coins = coins;
            this.Pos = pos;

        }
    }
}
