using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();

        private void Login_Click_1(object sender, RoutedEventArgs e)
        {
            User userobj = new User();
            try
            {
                if (combo.Text == "admin")
                {
                    deleteORsearch dORs = new deleteORsearch();
                    this.NavigationService.Navigate(dORs);
                }


                else if (combo.Text == "user")
                {


                    userobj = DB.Users.First(x => x.userName == userText.Text);
                    if (userobj.userName == userText.Text && userobj.password == passText.Password)
                    {
                        string name = userText.Text;
                        profile profileobj = new profile(name);
                        this.NavigationService.Navigate(profileobj);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void forgetpass_Click(object sender, RoutedEventArgs e)
        {
            forgetpass frgtp = new forgetpass();
            this.NavigationService.Navigate(frgtp);
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
                signUP signup = new signUP();
                this.NavigationService.Navigate(signup);
        }
            
        
    }
}
