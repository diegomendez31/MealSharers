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

namespace MealSharersApplication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public MealSharers system
        {
            get;
            set;
        }

        public Window main
        {
            get;
            set;
        }

        public Boolean goback
        {
            get;
            set;
        }
        public Window1(MealSharers system, Window main)
        {
            InitializeComponent();
            goback = false;
            this.system = system;
            this.main = main;
        }

        private void login(object sender, RoutedEventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Password.ToString();
            if(system.loginAdmin(username, password))
            {
                if (system.currentAdmin.username.Equals("manager"))
                {
                    goback = true;
                    this.Close();

                    label.Content = "";
                    ManagerMainWindow eaterWindow = new ManagerMainWindow(system, main);
                    eaterWindow.Show();
                }
                else
                {
                    goback = true;
                    this.Close();

                    label.Content = "";
                    AdminMainWindow eaterWindow = new AdminMainWindow(system, main);
                    eaterWindow.Show();
                }
            }else if (system.loginEater(username, password))
            {

                goback = true;
                this.Close();
                
                label.Content = "";
                EaterMainWindow eaterWindow = new EaterMainWindow(system, main);
                eaterWindow.Show();
            }else if(system.loginCook(username, password))
            {
                goback = true;
                this.Close();
                
                label.Content = "";
                CookMainWindow cookWindow = new CookMainWindow(system, main);
                cookWindow.Show();
            }else
            {
                label.Content = "User name or password is incorrect.";
            }
            
        }

        private void openMain(object sender, System.ComponentModel.CancelEventArgs e)
        {
            label.Content = "";
            if (!goback)
            { main.Close(); }
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            label.Content = "";
            goback = true;
            this.Close();
            main.Show();
        }
    }
}
