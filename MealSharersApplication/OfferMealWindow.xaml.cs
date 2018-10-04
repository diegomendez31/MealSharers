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
    /// Interaction logic for OfferMealWindow.xaml
    /// </summary>
    public partial class OfferMealWindow : Window
    {
        public MealSharers system
        {
            get;
            set;
        }

        public CookMainWindow main
        {
            get;
            set;
        }

        public Boolean goback
        {
            get;
            set;
        }

        public Eater selectedEater;


        public OfferMealWindow(MealSharers system, CookMainWindow main)
        {
            this.system = system;
            this.main = main;
            InitializeComponent();
            selectedEater = null;
            List <string> filters = new List<string>();
            filters.Add("Distance");
            filters.Add("Food preference");
            comboFilter.ItemsSource = filters;
            loadhours();
            comboFoodKind.ItemsSource = system.foodPreference;
        }

        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!goback) { main.Close(); }

        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }

        private void showMyMeals(object sender, RoutedEventArgs e)
        {
           
        }

        private void loadhours()
        {
            List<string> hours = new List<string>();
            hours.Add("16:00");
            hours.Add("16:30");
            hours.Add("17:00");
            hours.Add("17:30");
            hours.Add("18:00");
            hours.Add("18:30");
            hours.Add("19:00");
            hours.Add("19:30");
            hours.Add("20:00");
            hours.Add("20:30");
            hours.Add("21:00");
            hours.Add("21:30");
            hours.Add("22:00");
            comboHour.ItemsSource = hours;
        }

        private void loadKindFood(object sender, SelectionChangedEventArgs e)
        {
            if (comboFilter.SelectedItem.Equals("Food preference"))
            {
                comboFoodKind.Visibility = Visibility.Visible;
                labelFoodName.Visibility = Visibility.Visible;

            }
            else
            {
                comboFoodKind.Visibility = Visibility.Hidden;
                labelFoodName.Visibility = Visibility.Hidden;
                if(system.currentCook != null)
                    listView.ItemsSource = system.listEatersByDistance(system.currentCook.postCode);
                
            }
        }

        private void selectEater(object sender, SelectionChangedEventArgs e)
        {
            Eater eat = (Eater)listView.SelectedItem;
            labelNameEater.Content = eat.name;
            selectedEater = eat;
        }

        private void loadTableByFood(object sender, SelectionChangedEventArgs e)
        {
            String food = comboFoodKind.SelectedItem.ToString();
            if (system.currentCook != null)
                listView.ItemsSource = system.listEatersByFood(food);
                
        }

        private void offerMeal(object sender, RoutedEventArgs e)
        {
            if (selectedEater != null)
            {
                if(comboHour.SelectedItem != null){
                    if (calendar.SelectedDate != null)
                    {
                        String date = calendar.SelectedDate.Value.ToShortDateString() + " "+ comboHour.SelectedItem.ToString();
                        system.offerMeal(selectedEater, date);
                        main.loadTable();
                        goback = true;
                        main.Show();
                        this.Close();
                    }
                    else
                    {
                        labelError.Content = "Please select a date.";
                    }
                }else{
                    labelError.Content = "Please select an hour.";
                } 
            }else{
                labelError.Content = "Please select an Eater before.";
            }
        }
    }
}
