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
        txtAdventureGame adventure = new txtAdventureGame();
        Player player = new Player();
        public int file;
        
        public bool overWrite;
  

        

        public void startGame(int file ,MainWindow main  )
        {
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


        public void btnLeft()
        {
            Random random = new Random();
            int r = random.Next(1, 10);

            if (r == 1)
            {
                badMove(adventure);
            }
            else if (r == 2)
            {
                luckyMove(adventure);

            }
            else if (r >= 3)
            {
                normalMove(adventure);
            }
        }

        private void badMove(txtAdventureGame adventure)
        {
            int pos = player.getPos();
            Random random = new Random();
            int r = random.Next(1, 3);
            if(r == 1)
            {
                
                if (pos != 0)
                {
                    pos--;
                }
                
                adventure.txtStory.Text = "you had bad luck you lost your way so you went back when you know they way";
            }
            else
            {
                int coins = player.getCoins();
                r = random.Next(1,5);
                for(int i = 0; i <= r; i++)
                {
                    coins--;
                    if (coins <= 0)
                    {
                        coins = 0;

                    }
                }
                adventure.txtStory.Text = "your bag had an hole in it adn you have" + r + " some coins";
                adventure.txtCoins.Text = coins.ToString();
                
            }

            pos++;
            adventure.txtPos.Text = pos.ToString() + " / 10";
        }

        private void luckyMove(txtAdventureGame adventureGame)
        {
            Random random = new Random();
            int r = random.Next(10,15);
            adventure.txtStory.Text = "you had insane luck and found some lost gold coins" + r +"to be exact";
            int coins = player.getCoins();
            coins += r;
            adventure.txtCoins.Text = coins.ToString();

            int pos = player.getPos();
            pos++;
            adventure.txtPos.Text = pos.ToString() + " / 10";
        }

        private void normalMove(txtAdventureGame adventureGame)
        {
            int coins = player.getCoins();
            Random random = new Random();
            int r = random.Next(1,3);
            if (r == 1)
            {
                adventure.txtStory.Text = "you have moved fowards wihtout any trouble";
            }
            else if (r == 2)
            {
                r = random.Next(2,5);
                
                adventure.txtStory.Text = "you have travelled succesfull and found" + r + "coins";
            }
            else{
                 
            }
            coins += r;
            adventure.txtCoins.Text = coins.ToString();
            int pos = player.getPos();
            pos++;
            adventure.txtPos.Text = pos.ToString() + " / 10";
        }
        
        private void searchMove()
        {
            Random random = new Random();
            int r = random.Next(1,5);
        }
    }
}
