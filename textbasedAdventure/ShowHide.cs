using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace textbasedAdventure
{
    
    internal class ShowHide
    {
        MainWindow mainWindow;
        public bool Continue = false;
        public ShowHide(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void hideMenu()
        {
            mainWindow.btnStart.Visibility = Visibility.Hidden;
            mainWindow.btnContinue.Visibility = Visibility.Hidden;
            mainWindow.btnQuit.Visibility = Visibility.Hidden;
        }
        public void showStart()
        {
            mainWindow.btnSaveFile1.Visibility = Visibility.Visible;
            mainWindow.btnSaveFile2.Visibility = Visibility.Visible;
            mainWindow.btnBack.Visibility = Visibility.Visible;
        }
        public void showContinue()
        {
            hideMenu();
            Continue = true;
            showStart();
        }

        public void Overwrite()
        {
            mainWindow.mbYesNo.Visibility = Visibility.Visible;
            mainWindow.txtYesNo.Visibility = Visibility.Visible;
            mainWindow.btnYes.Visibility = Visibility.Visible;
            mainWindow.btnNo.Visibility = Visibility.Visible;
        }

        public void Overwritehidden()
        {
            mainWindow.mbYesNo.Visibility = Visibility.Hidden;
            mainWindow.txtYesNo.Visibility = Visibility.Hidden;
            mainWindow.btnYes.Visibility = Visibility.Hidden;
            mainWindow.btnNo.Visibility = Visibility.Hidden;
        }
    }
}
