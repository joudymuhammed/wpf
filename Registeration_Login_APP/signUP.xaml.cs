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
    /// Interaction logic for signUP.xaml
    /// </summary>
    public partial class signUP : Page
    {
        public signUP()
        {
            InitializeComponent();
        }
        loginAndRegistrstionEntities DB = new loginAndRegistrstionEntities();

        public bool isvalid(string pass)
        {

              bool upper, lower, spechialchar, numbers;
              upper = lower = spechialchar = numbers = false;
              string set = "!@#$%^&*";
              foreach ( var s in set)
              {
                if(s>='a'&& s<='z')
                {
                    lower = true;
                }
                else if  (s >= 'A' && s <= 'Z')
                {
                        upper = true;
                }
                else if (s >= 0 && s <= 9)
                {
                    numbers = true;
                }
                else if (set.Contains(s))
                {
                    spechialchar = true;
                }
                

              }
            return lower && spechialchar && upper && numbers;

        }
        private void Button_Click(object sender, RoutedEventArgs e) //sign up button
        {
            User userobj = new User();
            try
            {


              int AGE=int.Parse( ageText.Text);

                if (isvalid(passText.Password) && AGE>18 && AGE<60)
               {

                    userobj.userName = userText.Text;
                    userobj.password = passText.Password;
                    userobj.age = int.Parse(ageText.Text);
                    userobj.phone_number = phonenum.Text;
                    userobj.gender = combogender.Text;
                    userobj.city = combocities.Text;
                    DB.Users.Add(userobj);
                    DB.SaveChanges();

                    MessageBox.Show("you have an account now");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        



        
            try
            {
                

                if (passText.Password.Length > 6 && passText.Password.Length< 15 && Regex.IsMatch(passText.Password, @"^(?=.*[a-z])  (?=.*[A-Z])  (?=.*\d) ()?=.*\w"))
                {
                    userobj.userName = userText.Text;
                    userobj.password = passText.Password;
                    userobj.age = int.Parse(ageText.Text);
                     userobj.phone_number = phonenum.Text;
                    userobj.gender = combogender.Text;
                    userobj.city = combocities.Text;
                    DB.Users.Add(userobj);
                    DB.SaveChanges();

                    MessageBox.Show("you have an account now");

                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }

        }

        //private void Button_Click(object sender, object e)
        //{

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login loginobj = new login();
            this.NavigationService.Navigate(loginobj);
        }
    }
}
