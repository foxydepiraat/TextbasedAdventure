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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace textbasedAdventure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShowHide showHide;
        StartGame StartGame = new StartGame();
        
        int file = 0;
        bool overwrite = false;
        public MainWindow()
        {
            InitializeComponent();
            showHide = new ShowHide(this);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            showHide.hideMenu();
            showHide.showStart();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            showHide.hideMenu();
            showHide.showContinue();
        }


        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveFile1_Click(object sender, RoutedEventArgs e)
        { 
            if(showHide.Continue == false)
            {

                showHide.Overwrite();
                file = 1;
            }
            else
            {
                file = 3;
            }
        }
        private void btnSaveFile2_Click(object sender, RoutedEventArgs e)
        {
            if (showHide.Continue == false)
            {
                showHide.Overwrite();
                file = 2;
            }
            else
            {
                file = 4;
            }
        }

        

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
           
            if (file == 1)
            {
                StartGame.File1();
            }
            else if (file == 2)
            {
                StartGame.File2();
            }
            showHide.Overwritehidden();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            showHide.Overwritehidden();
        }

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Visible;
            btnContinue.Visibility = Visibility.Visible;
            btnQuit.Visibility = Visibility.Visible;
            btnSaveFile1.Visibility = Visibility.Hidden;
            btnSaveFile2.Visibility = Visibility.Hidden;
            btnBack.Visibility = Visibility.Hidden;
        }
    }
}
