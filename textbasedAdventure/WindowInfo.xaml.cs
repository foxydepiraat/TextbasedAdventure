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
        private string Default = "hover over something to know what it means";
        public WindowInfo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is your username";
        }

        private void txtUsername_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtHp_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This shows how much hp you have left out of maximum";
        }

        private void txtHp_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtDam_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is how much damage you would to to the enemy";
        }

        private void txtDam_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtDef_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "This is how much defense you have that removes the damage from the enemy";
        }

        private void txtDef_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

        private void txtCoins_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = "this is how much coins you have with these coins you can buy hp, damage or defense";
        }

        private void txtCoins_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTutorial.Text = Default;
        }

    }
}
