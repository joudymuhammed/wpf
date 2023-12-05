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

namespace Registeration_Login_APP
{
    /// <summary>
    /// Interaction logic for deleteORsearch.xaml
    /// </summary>
    public partial class deleteORsearch : Page
    {
        public deleteORsearch()
        {
            InitializeComponent();
        }

        private void searchBTN_Click(object sender, RoutedEventArgs e)
        {
            search s = new search();
            this.NavigationService.Navigate(s);
        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            delete s = new delete();
            this.NavigationService.Navigate(s);
        }
    }
}
