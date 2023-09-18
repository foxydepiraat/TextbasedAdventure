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
                txtStory.Text = "We need your help " + txtUsername.Text + " to save us from the Mountain Kingdom our golden coins got stolen. ";
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
            if( NextPosition == true)
            {
                player.getPos();
            }
        }

        private void btnOption2_Click(object sender, RoutedEventArgs e)
        {
            if(btnOption2.Content == "Move Left")
            {
                StartGame startgame = new StartGame();
                startgame.btnLeft();
            }
        }
    }
}
