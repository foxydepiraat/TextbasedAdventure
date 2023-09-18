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
    /// Interaction logic for EndScreen.xaml
    /// </summary>
    public partial class EndScreen : Window
    {
        public EndScreen(int ending)
        {
            InitializeComponent();
            if (ending == 1)
            {
                txtEndings.Text = "The good ending you ahve saved the forest kingdom adn got all there stolen golden coins back ending 1/3";
            }
            else if (ending == 2)
            {
                txtEndings.Text = "The coward ending you said no to help the inhabitants of the forest kingdom ending 2/3";
            }
            else if (ending == 3)
            {
                txtEndings.Text = "The dead ending you died and dissapointed the forrest kingdom ending 3/3";
            }
            
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
