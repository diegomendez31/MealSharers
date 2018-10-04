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
    /// Interaction logic for AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
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

        public AdminMainWindow(MealSharers system, Window main)
        {
            this.system = system;
            this.main = main;
            InitializeComponent();
            labelUser.Content = "Welcome " + system.currentAdmin.name + "!";
        }

        private void showMap(object sender, RoutedEventArgs e)
        {
            MapVolunteerWindow win = new MapVolunteerWindow(system, this);
            win.Show();
            this.Hide();
        }

        private void showCriticalCooks(object sender, RoutedEventArgs e)
        {
            CookCriticalWindow win = new CookCriticalWindow(system, this);
            win.Show();
            this.Hide();
        }

        private void showSatisfactionEaters(object sender, RoutedEventArgs e)
        {
            EaterSatisfactionWindow win = new EaterSatisfactionWindow(system, this);
            win.Show();
            this.Hide();

        }

        private void logout(object sender, RoutedEventArgs e)
        {
            system.logout();
            goback = true;
            main.Show();
            this.Close();
           
        }

        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!goback) { main.Close(); }

        }
        private void viewProfile(object sender, RoutedEventArgs e)
        {
            AdminProfileWindow win = new AdminProfileWindow(system, this);
            win.Show();
            this.Hide();
        }
    }
}
