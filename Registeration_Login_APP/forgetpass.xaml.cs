using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpass.xaml
    /// </summary>
    public partial class forgetpass : Page
    {
        public forgetpass()
        {
            InitializeComponent();
            
        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User userobj = new User();
            try
            {


                userobj = DB.Users.First(x => x.phone_number == phonenumber.Text);
                if (newpass.Password == passconfirm.Password)
                {
                    userobj.password = newpass.Password;
                    DB.Users.AddOrUpdate(userobj);
                    DB.SaveChanges();
                    MessageBox.Show("password has changed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
