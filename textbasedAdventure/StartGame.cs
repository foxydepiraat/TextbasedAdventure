using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textbasedAdventure
{
    internal class StartGame
    {
        txtAdventureGame adventure = new txtAdventureGame();

        public int file;
        private int conHp = 30;
        private int conMaxHp = 04;
        private int conDam = 8;
        private int conDef = 1;
        private int conCoins = 4;
        private int conPos = 3;
        public bool overWrite;
  


        public void startGame(int hp, int maxhp, int dam, int def, int coins, int pos ,int file, MainWindow main)
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

        public void ContinueGame(int hp, int maxhp, int dam, int def, int coins, int pos , int file ,MainWindow main)
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
            
        }

        

    }
}
