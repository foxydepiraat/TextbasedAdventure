using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbasedAdventure
{
    internal class Player 
    {

        
        public string Name;
        public int Hp;
        public int MaxHp;
        public int Dam;
        public int Def;
        public int Coins;
        public int Pos;
        public bool Alive;

        

        public Player()
        {
            Name = "username";
            Hp = 20;
            MaxHp = 20;
            Dam = 5;
            Def = 0;
            Coins = 0;
            Pos = 1;
        }
        public Player(string name, int hp, int maxhp, int dam, int def, int coins, int pos, bool alive)
        {
            Alive = alive;
            Name = name;
            Hp = hp;
            MaxHp = maxhp;
            Dam = dam;
            Def = def;
            Coins = coins;
            Pos = pos;
        }


        public string GetName()
        {
            return Name;
        }
        

        public int getHp()
        {
            return Hp;
        }
        public int getMaxHp()
        {
            return MaxHp;
        }
        public int getDam()
        {
            return Dam;
        }
        public int getDef()
        {
            return Def;
        }
        public int getCoins()
        {
            return Coins;
        }

        public int getPos()
        {
            return Pos;
        }

        public bool getAlive()
        {
            return Alive;
        }

        public void setName(string name)
        {
            Name = name;
        }

        public void setCoins(int coins)
        {
            Coins = coins;
        }
        public void setHp(int hp)
        {
            Hp = hp;
        }
        public void setmaxHp(int maxhp)
        {
            MaxHp = maxhp;
        }
        public void setDam(int dam)
        {
            Dam = dam;
        }
        public void setDef(int def)
        {
            Def = def;
        }

        public void setpos(int pos)
        {
            Pos = pos;
        }

        public void setAlive(bool alive)
        {
            Alive = alive;
        }
    }
}
