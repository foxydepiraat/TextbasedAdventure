using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace textbasedAdventure
{
    internal class Enemy
    {
        private string TypeEnemy;
        private int enemyCoins;
        private int coins;
        public int Hp;
        public int MaxHp;
        public int Dam;
        public int Def;
        public bool Alive;
        public Enemy()
        {
            this.Alive = true;
            this.Hp = 10;
            this.MaxHp = 5;
            this.Dam = 2;
            this.Def = 0;
        }

        public Enemy(int hp, int maxHp, int dam, int def, bool alive )
        {
            Alive = alive;
            Hp = hp;
            MaxHp = maxHp;
            Dam = dam;
            Def = def;
        }

        public void bossBattle()
        {
            TypeEnemy = "boss";
            Hp = 100;
            MaxHp = 100;
            Dam = 15;
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

        public bool getAlive()
        {
            return Alive;
        }

        public void SetHp(int hp)
        {
            Hp = hp;
        }

        public void setMaxHp(int maxhp)
        {
            MaxHp = maxhp;
        }

        public void setDam(int dam )
        {
            Dam = dam;
        }

        public void setDef(int def)
        {
            Def = def;
        }

        public void setAlive(bool alive)
        {
            Alive = alive;
        }

        public void easyEnemy(txtAdventureGame adventure)
        {
            
                adventure.txtStory.Text = "an easy enemy has appeared. with 20hp and does 5 damage ";
                this.Alive = true;
                this.Hp = 20;
                this.MaxHp = 20;
                this.Dam = 5;
                this.Def = 0;
                enemyCoins = 10;
            
            
        }
        public void mediumEnemy(txtAdventureGame adventure)
        {

            adventure.txtStory.Text = "an medium enemy has appeared. with 50 and does 10 damage";
            this.Alive = true;
            this.Hp = 50;
            this.MaxHp = 50;
            this.Dam = 10;
            enemyCoins = 20;


        }

        public void enemyTurn(txtAdventureGame adventure , Player player)
        {
            if (Hp <= 0)
            {
                if(TypeEnemy == "boss")
                {
;                    EndScreen end = new EndScreen(1);
                     end.Show();
                     adventure.Close();
                }
                StartGame startgame = new StartGame();
                startgame.btnMove(adventure);

                adventure.txtStory.Text = "you have killed the enemy";
                coins = player.getCoins();
                coins =coins + enemyCoins;
                player.setCoins(coins);
                adventure.txtCoins.Text = coins.ToString();
                adventure.shops = 1;
            }
            else
            {
                adventure.btnShop.Visibility = System.Windows.Visibility.Hidden;
                Random random = new Random();
                int r = random.Next(1, 10);
                if (r <= 6)
                {
                    int heal = random.Next(1, 9);
                    int hp = getHp();
                    int maxhp = getMaxHp();
                    for (int i = 0; i < heal; i++)
                    {
                        if (hp < maxhp)
                        {
                            hp++;
                        }

                        SetHp(hp);
                    }
                    adventure.txtStory.Text = "the enemy has healed himself for " + heal + " and now has " + hp + "hp left.";
                }
                else if (r > 6)
                {
                    
                    int PHp = player.getHp();
                    int pmaxHp = player.getMaxHp();
                    PHp -= Dam;
                    player.setHp(PHp);
                    adventure.txtHp.Text = PHp + "/" + pmaxHp;
                    adventure.txtStory.Text = String.Format("the enemy has {0} remaining health", Hp);
                    if (PHp <= 0)
                    {
                        EndScreen end = new EndScreen(3);
                        end.Show();
                        adventure.Close();
                    }
                }
            }
        }
    }
}
