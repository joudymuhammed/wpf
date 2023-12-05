using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        public profile(string name)
        {
            InitializeComponent();
            welcomelabel.Content = name + " profile";
        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();
        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            var show = DB.Users.Where(u => u.phone_number == phonenum.Text).ToList();
            datagrid.ItemsSource =DB.Users.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // login Login = new login();
            //login.NavigationService.Navigate(Login);
        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void refresh_Click(object sender, object e)
        {

        //   User userobj = new User();

            
        //   userobj = DB.Users.FirstOrDefault(u => u.phone_number == phonenum.Text.Select(u.userID,u.userName,u.phone_number,u.gender,u.age,u.city));
           
        //   datagrid.ItemsSource = DB.Users.ToList();
        }
    }
}
