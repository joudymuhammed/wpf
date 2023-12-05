using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        public delete()
        {
            InitializeComponent();
        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();

        private void delete_Click(object sender, RoutedEventArgs e)
        {


        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                User userobj = new User();
                var del = DB.Users.Remove(DB.Users.First(x => x.phone_number == deletetext.Text));
                DB.SaveChanges();
                
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void datagridDelete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            datagridDelete.ItemsSource = DB.Users.ToList();
        }
    }
}
