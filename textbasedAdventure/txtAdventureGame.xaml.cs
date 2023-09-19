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
    public partial class txtAdventureGame : Window
    {
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
            player.setPlayerStats();
            int hp = player.getHp();
            int maxHp = player.getMaxHp();
            txtHp.Text = hp + "/" + maxHp;

            txtDam.Text = player.getDam().ToString();
            txtDef.Text = player.getDef().ToString();
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

        public void btnOption1_Click(object sender, EventArgs e)
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
                btnOption1.Content = "YES";
                btnOption3.Visibility = Visibility.Visible;
                btnOption3.Content = "NO";
            }

            else if (counterStory == 3)
            {
                counterBtn3++;
                StartGame startgame = new StartGame();
                startgame.btnMove(this);
            }
            else if (btnOption1.Content == "Search this area")
            {
                StartGame startgame = new StartGame();
                startgame.searchMove(this);
            }
        }


        public void btnOption3_Click(object sender, EventArgs e)
        {
            if (counterBtn3 == 0)
            {
                counterBtn3++;
                ending = 2;
                EndScreen end = new EndScreen(ending);
                end.Show();
                this.Close();
            }
        }

        public void btnOption4_Click(object sender, EventArgs e)
        {
            if (NextPosition == true)
            {
                player.getPos();
            }
        }

        private void btnOption2_Click(object sender, RoutedEventArgs e)
        {
            if (btnOption2.Content == "Move Left")
            {
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
        private void badMove()
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

        private void normalMove()
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

                txtStory.Text = "you have travelled succesfull and found" + r + "coins";
            }
            else
            {

                txtStory.Text = "you have moved fowards wihtout any trouble";
            }
            coins += r;
            txtCoins.Text = coins.ToString();
            player.setCoins(coins);
            pos = player.getPos();
            
            player.setpos(pos);
            txtPos.Text = pos.ToString() + " / 10";
            MaxPos();
        }

        private void luckyMove()
        {
            Random random = new Random();
            int r = random.Next(10, 15);
            txtStory.Text = "you had insane luck and found some lost gold coins" + r + "to be exact";
            int coins = player.getCoins();
            coins += r;
            txtCoins.Text = coins.ToString();

            pos = player.getPos();
            
            txtPos.Text = pos.ToString() + " / 10";
            MaxPos();
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
            }
            player.setpos(pos);
            
        }
    }
}
