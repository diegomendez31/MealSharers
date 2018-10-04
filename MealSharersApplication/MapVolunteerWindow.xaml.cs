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
    /// Interaction logic for MapVolunteerWindow.xaml
    /// </summary>
    public partial class MapVolunteerWindow : Window
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

        public StringBuilder query
        {
            get;
            set;
        }
        public MapVolunteerWindow(MealSharers system, Window main)
        {
            InitializeComponent();
            goback = false;
            this.system = system;
            this.main = main;
            query = new StringBuilder();
            query.Append("http://maps.google.com/maps?q=");
     
            webMap.Navigate(query.ToString());
            loadTable();
        }

        public void loadTable()
        {
            listView.ItemsSource = system.ShowVolunteerMap();
        }
        private void searchUser(object sender, RoutedEventArgs e)
        {
            query = new StringBuilder();
            query.Append("http://maps.google.com/maps?q=");
            User m = (User)((Button)sender).Tag;
            query.Append(m.postCode + "," + "+");
            webMap.Navigate(query.ToString());
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
         
            goback = true;
            this.Close();
            main.Show();
     
        }

       
    }
}
