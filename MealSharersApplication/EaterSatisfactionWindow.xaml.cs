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
    /// Interaction logic for EaterSatisfactionWindow.xaml
    /// </summary>
    public partial class EaterSatisfactionWindow : Window
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
        public EaterSatisfactionWindow(MealSharers system, Window main)
        {
            this.system = system;
            this.main = main;
            goback = false;
            InitializeComponent();
            loadTable();

        }

        public void loadTable()
        {
            listView.ItemsSource = system.listEatersSatisfactionRating();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }

        private void reviewMeal(object sender, RoutedEventArgs e)
        {
            MessageWindow win = new MessageWindow();
            win.Show();
        }
    }
}
