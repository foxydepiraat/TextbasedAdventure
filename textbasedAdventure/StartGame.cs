using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace textbasedAdventure
{
    internal class StartGame : txtAdventureGame
    {
        private txtAdventureGame txtAdventure = new txtAdventureGame();
        Player player = new Player();
        public int file;
        private int counter = 0;
        public bool overWrite;

        public void startGame(int file ,MainWindow main  )
        {
            txtAdventureGame adventure = new txtAdventureGame();
            if (file ==1)
            {
                
                adventure.Show();
                main.Close();
            }
            else if (file == 2 )
            {
                adventure.Show();
                main.Close();
            }
        }

        public void ContinueGame(int file, MainWindow main)
        {
            if( file == 3)
            {
                getData(file);
            }
            else if( file == 4)
            {
                getData(file);
            }
        }
        
        public void getData(int file)
        { 
            if(file == 3)
            {
                //load file 1
            }
            else if(file == 4)
            {
                //load file 2
            }
               
        }

        public void CheckPlayerPos(int file, int Pos)
        {
            if(file == 1)
            {

            }
            else if(file == 2)
            {

            }
        }

        public void btnMove(txtAdventureGame adventure)
        {
            txtAdventure = adventure;
            adventure.btnOption1.Content = "Search this area";
            adventure.btnOption2.Content = "Move Left";
            adventure.btnOption3.Content = "Move Foward";
            adventure.btnOption4.Content = "Move Right";
            adventure.btnShop.Visibility = Visibility.Visible;
            adventure.btnOption1.Visibility = Visibility.Visible;
            adventure.btnOption2.Visibility = Visibility.Visible;
            adventure.btnOption3.Visibility = Visibility.Visible;
            adventure.btnOption4.Visibility = Visibility.Visible;
        }
        
        
        public void searchMove( txtAdventureGame adventure)
        {
            counter++;
            Random random = new Random();
            int r = random.Next(1,10);

            if(counter <=1)
            {
                int coins = Convert.ToInt16(adventure.txtCoins.Text);
                adventure.txtStory.Text = "you have search this here and found " + r + " golden coins.";
                coins = coins + r;
                player.setCoins(coins);
                adventure.txtCoins.Text = coins.ToString();
            }
            else
            {
                adventure.txtStory.Text = "you have already seacrhed this area";
            }
        }
    }
}
