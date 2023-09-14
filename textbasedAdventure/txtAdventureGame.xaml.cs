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
        readonly StartGame startGame;
        readonly Player player;
        
        int counterStory = 0;
        public txtAdventureGame()
        {
            InitializeComponent();
            txtStory.Text = "What is your username";
            btnOption1.Content = "Continue";
            btnOption2.Visibility = Visibility.Hidden;
            btnOption3.Visibility = Visibility.Hidden;
            btnOption4.Visibility = Visibility.Hidden;
            btnShop.Visibility = Visibility.Hidden;
        }

        public void btnOption1_Click(object sender, EventArgs e)
        {

           counterStory++;
           if (counterStory ==1)
            {
                player.Name = txtStory.Text;
                txtStory.Text = "We need your help Hero:" + player.Name + " and welcome to the Forrest Kingdom";
            }
           else if(counterStory == 2)
            {

            }
        }

        


    }
}
