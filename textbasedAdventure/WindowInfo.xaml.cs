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
    /// Interaction logic for WindowInfo.xaml
    /// </summary>
    public partial class WindowInfo : Window
    {
        private string Default = "Hover over something to know what it means.";
        private string Options = "This is button wil make you move or an attack move or for the shop to buy.";
        public WindowInfo()
        {
            InitializeComponent();
            txtTutorial.Text = Default;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is your username nothing special.";
        }

        private void txtUsername_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtHp_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This shows how much hp you have left out of maximum.";
        }

        private void txtHp_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtDam_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is how much damage you would to to the enemy.";
        }

        private void txtDam_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtDef_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is how much defense you have that removes the damage from the enemy.";
        }

        private void txtDef_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtCoins_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "this is how much coins you have with these coins you can buy hp, damage or defense coins are gained from killing enemys or finding special locations.";
        }

        private void txtCoins_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void btnOption1_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Options;
        }

        private void btnOption1_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }
        private void btnOption2_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Options;
        }

        private void btnOption2_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void btnOption3_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Options;
        }

        private void btnOption3_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }
        private void btnOption4_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Options;
        }

        private void btnOption4_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void btnShop_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "to go to the shop to buy upgrades and you wont be able to buy upgrades in a fight.";
        }

        private void btnShop_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtTutorial_MouseEnter(object sender,EventArgs e)
        {
            txtTutorial.Text = "This is where the story wil be told.";
        }
        private void txtTutorial_MouseLeave(object sender, EventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtWin_MouseEnter(object sender,MouseEventArgs e)
        {
            txtTutorial.Text = "you need to survive 10 moves until you have reached the mountain kingdom";
        }

        private void txtWin_MouseLeave(object sender,MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }
        private void txtPos_MouseEnter(object sender,MouseEventArgs e)
        {
            txtTutorial.Text = "you need to survive 10 moves until you have reached the mountain kingdom";
        }

        private void txtPos_MouseLeave(object sender,MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        
    }
}
