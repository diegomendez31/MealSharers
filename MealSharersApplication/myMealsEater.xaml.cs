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
    /// Interaction logic for myMealsEater.xaml
    /// </summary>
    public partial class myMealsEater : Window
    {
        public MealSharers system
        {
            get;
            set;
        }

        public Window lastWindow
        {
            get;
            set;
        }

        public Boolean goback
        {
            get;
            set;
        }

        public myMealsEater(MealSharers system, Window lastWindow)
        {
            InitializeComponent();
            this.system = system;
            this.lastWindow = lastWindow;
            goback = false;
            loadTable();
        }
        public void loadTable()
        {
            listView.ItemsSource = system.listMyMealsEater();

        }

        private void reviewMeal(object sender, RoutedEventArgs e)
        {
            Meal m = (Meal)((Button)sender).Tag;
            
            ReviewWindow reviewWindow = new ReviewWindow(m, system, this);
            reviewWindow.Show();
                
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            label.Content = "";
            goback = true;
            this.Close();
            lastWindow.Show();
        }
    }
}
