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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        public search()
        {
            InitializeComponent();
        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();

      

        private void search_Click_1(object sender, RoutedEventArgs e)
        {
            User user = new User();
           
                var searchitem = DB.Users.Where(x => user.city.Contains(searchtext.Text)).ToList();
                if (searchitem.Any())
                {
                    datagridsearch.ItemsSource = searchitem;
                }
                else
                {


                    MessageBox.Show("no data found");
                }




         
           
        }

        private void datagridsearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            datagridsearch.ItemsSource = DB.Users.ToList();
        }
    }
}
