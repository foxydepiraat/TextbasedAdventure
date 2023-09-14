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


        private int startHp = 20;
        private int startMaxHp = 20;
        private int startDam = 5;
        private int startDef = 0;
        private int startCoins = 0;
        private int startPos = 1;

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

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            WindowInfo info = new WindowInfo();
            info.Show();

        }

        private void btnSaveFile1_Click(object sender, RoutedEventArgs e)
        { 
            if(showHide.Continue == false)
            {

                showHide.Overwrite();
                StartGame.file = 1;
            }
            else
            {
                StartGame.file = 3;
            }
        }
        private void btnSaveFile2_Click(object sender, RoutedEventArgs e)
        {
            if (showHide.Continue == false)
            {
                showHide.Overwrite();
                StartGame.file = 2;
            }
            else
            {
                StartGame.file = 4;
            }
        }

        

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
           
            if (StartGame.file == 1)
            {
                StartGame.startGame(startHp, startMaxHp, startDam, startDef, startCoins, startPos, StartGame.file, this );
            }
            else if (StartGame.file == 2)
            {
                StartGame.startGame(startHp, startMaxHp, startDam, startDef, startCoins, startPos, StartGame.file, this);
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
