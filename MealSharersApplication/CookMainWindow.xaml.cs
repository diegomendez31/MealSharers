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
    /// Interaction logic for CookMainWindow.xaml
    /// </summary>
    public partial class CookMainWindow : Window
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

        public CookMainWindow(MealSharers system, Window main)
        {
            InitializeComponent();
            this.main = main;
            this.system = system;
            if (system.currentCook != null)
            labelUser.Content = "Welcome " + system.currentCook.name + "!";
            loadTable();
        }

        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!goback) { main.Close(); }
            
        }

        private void signupEater(object sender, RoutedEventArgs e)
        {

        }

        public void loadTable()
        {
            listView.ItemsSource = system.listMyMealsSystem();

        }
        private void logout(object sender, RoutedEventArgs e)
        {
            system.logout();
            goback = true;
            
            main.Show();
            this.Close();
        }

        private void viewProfile(object sender, RoutedEventArgs e)
        {
            CookProfileWindow win = new CookProfileWindow(system, this);
            win.Show();
            this.Hide();
        }

        private void showMyMeals(object sender, RoutedEventArgs e)
        {
            MyMealsCookWindow win = new MyMealsCookWindow(system, this);
            win.Show();
            this.Hide();
        }

        private void offerMeal(object sender, RoutedEventArgs e)
        {
            OfferMealWindow win = new OfferMealWindow(system, this);
            win.Show();
            this.Hide();
        }
    }
}
