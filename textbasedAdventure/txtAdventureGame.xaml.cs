using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace textbasedAdventure
{
    /// <summary>
    /// Interaction logic for txtAdventureGame.xaml
    /// </summary>
    public partial class txtAdventureGame : Window {

        private int counter;
        private int coins;
        private int RestoreCost = 5;
        private int HpCost = 10;
        private int DamCost = 15;
        private int DefCost = 15;
        private string RestoreShop = "Restore 5 hp for ";
        private string MaxHpStore = "upgrade 5 max hp for ";
        private string DamShop = "upgrade your damage";
        private string DefShop = "upgrade your defense";
        
        public int shops = 1;
        Enemy enemy = new Enemy();
        private int pos;
        Player player = new Player();
        private bool NextPosition;
        private int counterStory = 0;
        private int counterBtn3 = 0;
        private int ending;
        public txtAdventureGame()
        {
            InitializeComponent();
            int hp = player.getHp();
            int maxHp = player.getMaxHp();
            txtHp.Text = hp + "/" + maxHp;

            txtDam.Text = player.getDam().ToString();
            txtCoins.Text = player.getCoins().ToString();
            txtPos.Text = player.getPos().ToString();
            txtCoins.Text = player.getCoins().ToString();
            txtPos.Text = player.getCoins().ToString();
            txtStory.Text = "What is your username:";
            btnOption1.Content = "Continue";
            btnOption2.Visibility = Visibility.Hidden;
            btnOption3.Visibility = Visibility.Hidden;
            btnOption4.Visibility = Visibility.Hidden;
            btnShop.Visibility = Visibility.Hidden;
        }

        public void btnOption1_Click(object sender, RoutedEventArgs e)
        {

            if (btnOption1.Content == "Continue" || btnOption1.Content == "YES")
            {
                counterStory++;

                if (counterStory == 1)
                {
                    txtUsername.Text = txtInput.Text;
                    txtStory.Text = string.Format("We need your help {0} to save us from the Mountain Kingdom our golden coins got stolen.", txtUsername.Text);

                    txtInput.Visibility = Visibility.Hidden;
                }

                else if (counterStory == 2)
                {
                    txtStory.Text = "Would you like to help us get our coins back";
                    btnOption1.Content = "YES";
                    btnOption3.Visibility = Visibility.Visible;
                    btnOption3.Content = "NO";
                }

                else if (counterStory == 3)
                {
                    StartGame startGame = new StartGame();
                    counterBtn3++;
                    startGame.btnMove(this);
                    txtStory.Text = "where would you like to go or do.";
                }
            }
            else if (shops == 1)
            {
                searchMove();
            }
            else if (shops == 2)
            {
                coins = player.getCoins();
                if (coins >= RestoreCost)
                {
                    coins-= RestoreCost;
                    for (int i = 0; i < RestoreCost;)
                    {
                        
                        i++;

                        int hp = player.getHp();
                        int maxhp = player.getMaxHp();
                        if (maxhp > hp)
                        {

                            hp++;
                            txtHp.Text = hp + "/" + maxhp;
                            player.setHp(hp);

                        }
                    }
                    txtCoins.Text = coins.ToString();
                    player.setCoins(coins);
                }
            }
            else if (shops == 0)
            {
                int Pdam = player.getDam();
                int Edef = enemy.Def;
                int Ehp = enemy.Hp;
                
                if (Ehp > 0)
                {
                    Ehp -= Pdam; 
                    enemy.SetHp(Ehp);
                    if (enemy.Alive == true)
                        enemy.enemyTurn(this, player); 
                }
                else 
                {
                    enemy.setAlive(false);
                    StartGame startgame = new StartGame();
                    startgame.btnMove(this);
                    
                }
        }
    }

        public void searchMove()
        {
            counter++;
            Random random = new Random();
            int r = random.Next(1, 10);

            if (counter <= 3)
            {
                int coins = Convert.ToInt16(txtCoins.Text);
                txtStory.Text = "you have search this here and found " + r + " golden coins.";
                coins = coins + r;
                player.setCoins(coins);
                txtCoins.Text = coins.ToString();
            }
            else
            {
                txtStory.Text = "you have already seacrhed this area";
            }
        }
        public void btnOption3_Click(object sender, RoutedEventArgs e)
        {
            if (counterBtn3 == 0)
            {
                counterBtn3++;
                ending = 2;
                EndScreen end = new EndScreen(ending);
                end.Show();
                this.Close();
            }
            else if (shops == 2)
            {
                coins = Convert.ToInt16(txtCoins.Text);
                if (coins >= DamCost)
                {
                    int dam = player.getDam();
                    dam += 2;
                    player.setDam(dam);
                    coins -= DamCost;
                    player.setCoins(coins);
                    txtDam.Text = dam.ToString();
                    txtCoins.Text = coins.ToString();
                    txtStory.Text = "You have bought the upgrade.";
                }
                else
                {
                    txtStory.Text = "you dont have enough Coins";
                }
            }
            else if (shops == 1)
            {
                counter = 0;
                Random random = new Random();
                int r = random.Next(1, 10);

                if (r == 1)
                {
                    badMove();
                }
                else if (r == 2)
                {
                    luckyMove();

                }
                else if (r >= 3)
                {
                    normalMove();
                }
            }
            else if(shops == 0)
            {

            }
        }

        public void btnOption4_Click(object sender,RoutedEventArgs e)
        {
            string DefShopText = DefShop + DefCost;
            if (NextPosition == true)
            {
                player.getPos();
            }
            if(shops == 2)
            {
                coins = Convert.ToInt16(txtCoins.Text);
                if (coins >=  HpCost)
                {
                    int def = player.getDef();
                    def++;
                    player.setDef(def);
                    coins -= DefCost;
                    player.setCoins(coins);
                    txtCoins.Text = coins.ToString();
                    txtStory.Text = "You have bought the upgrade."; 
                }
                else
                {
                    txtStory.Text = "you dont have enough Coins";
                }
            }
            else if(shops == 1)
            {
                counter = 0;
                Random random = new Random();
                int r = random.Next(1, 10);

                if (r == 1)
                {
                    badMove();
                }
                else if (r == 2)
                {
                    luckyMove();

                }
                else if (r >= 3)
                {
                    normalMove();
                }
            }
        }

        private void btnOption2_Click(object sender, RoutedEventArgs e)
        {

            if (shops ==1 )
            {
                counter = 0;
                Random random = new Random();
                int r = random.Next(1, 10);

                if (r == 1)
                {
                    badMove();
                }
                else if (r == 2)
                {
                    luckyMove();

                }
                else if (r >= 3)
                {
                    normalMove();
                }
            }
            else if (shops == 2)
            {
                coins = Convert.ToInt16(txtCoins.Text);
                if (coins >= HpCost)
                {
                    int hp = player.getHp();
                    int maxhp = player.getMaxHp();

                    hp += 5;
                    maxhp += 5;
                    player.setHp(hp);
                    player.setmaxHp(maxhp);
                    coins -= HpCost;
                    player.setCoins(coins);
                    txtHp.Text = hp +"/"+ maxhp;
                    txtCoins.Text = coins.ToString();
                    txtStory.Text = "You have bought the upgrade.";
                }
                else
                {
                    txtStory.Text = "you dont have enough Coins";
                }
            }
            else if(shops == 0)
            {
                Random random = new Random();
                int r = random.Next(1, 15);
                int hp = player.getHp();
                for(int i = 0; i < r; i++)
                {
                    int maxhp = player.getMaxHp();
                    if (maxhp > hp)
                    {
                        hp++;
                    }
                    player.setHp(hp);
                    txtHp.Text = hp + "/" + maxhp;
                }
            }
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            if (shops == 1)
            {
                btnOption1.Content = (RestoreShop + RestoreCost);
                btnOption2.Content = (MaxHpStore + HpCost);
                btnOption3.Content = (DamShop + DamCost);
                btnOption4.Visibility = Visibility.Hidden;
                btnOption4.Content = (DefShop + DefCost);
                btnShop.Content = "Back";
                shops = 2;
            }
            else
            {
                StartGame startGame = new StartGame();
                startGame.btnMove(this);
                shops = 1;
            }
        }

        
        private void badMove()
        {
            if (player.Pos >= 10)
            {
                encounterEnemy();
                enemy.bossBattle();
            }
            else
            {
                pos = player.getPos();
                Random random = new Random();
                int r = random.Next(1, 3);
                if (r == 1)
                {

                    if (pos != 0)
                    {
                        pos--;
                    }
                    player.setpos(pos);

                    txtStory.Text = "you had bad luck you lost your way so you went back when you know they way";
                }
                else
                {
                    int coins = player.getCoins();
                    r = random.Next(1, 5);
                    for (int i = 0; i <= r; i++)
                    {
                        coins--;
                        if (coins <= 0)
                        {
                            coins = 0;

                        }
                    }
                    txtStory.Text = "your bag had an hole in it adn you have" + r + " some coins";
                    txtCoins.Text = coins.ToString();
                    player.setCoins(coins);
                }


                txtPos.Text = pos.ToString() + " / 10";
                MaxPos();
            }
        }

        private void normalMove()
        {
            if (player.Pos >= 10)
            {
                encounterEnemy();
                enemy.bossBattle();
            }
            else
            {
                int coins = player.getCoins();
                Random random = new Random();
                int r = random.Next(1, 3);
                if (r == 1)
                {
                    txtStory.Text = "you have moved fowards wihtout any trouble";
                }
                else if (r == 2)
                {
                    r = random.Next(2, 5);

                    txtStory.Text = "you have travelled succesfull and found " + r + " coins";
                }
                else
                {

                    txtStory.Text = "you have moved fowards wihtout any trouble";
                }
                coins += r;
                txtCoins.Text = coins.ToString();
                player.setCoins(coins);
                pos = player.getPos();
                encounterEnemy();
                if(player.getPos() >= 6)
                {
                    enemy.mediumEnemy(this);
                }
                else
                {
                    enemy.easyEnemy(this);
                }
                player.setpos(pos);
                txtPos.Text = pos.ToString() + " / 10";
                MaxPos();
            }
        }

        private void luckyMove()
        {
            if (player.Pos >= 10)
            {
                encounterEnemy();
                enemy.bossBattle();
            }
            else
            {
                Random random = new Random();
                int r = random.Next(20, 40);
                txtStory.Text = "you had insane luck and found some lost gold coins " + r + " to be exact";
                int coins = player.getCoins();
                coins += r;
                txtCoins.Text = coins.ToString();

                pos = player.getPos();

                txtPos.Text = pos.ToString() + " / 10";
                MaxPos();
            }
        }

        private void MaxPos()
        {
            pos = player.getPos();
            if (pos < 10)
            {
                pos++;
            }
            else if (pos == 10)
            {
                enemy.bossBattle();
                encounterEnemy();
            }
            player.setpos(pos);
            
        }
        
        private void btnBack_Click()
        {
            MainWindow main = new MainWindow();
            main.Show();
            StartGame startGane = new StartGame();
            startGane.saveGame(this);
            this.Close();
        }

         


        public void encounterEnemy()
        {
            shops = 0;
            btnOption1.Content = "Attack";
            btnOption2.Content = "Rest";
            btnOption3.Content = "block";
            btnOption4.Content = "buff";
            btnOption3.Visibility = Visibility.Hidden;
            btnOption4.Visibility = Visibility.Hidden;
            btnShop.Visibility = Visibility.Hidden;
            btnBack.Visibility = Visibility.Hidden;

        }
    }
}
