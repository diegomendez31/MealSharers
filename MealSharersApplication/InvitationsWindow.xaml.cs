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
    /// Interaction logic for InvitationsWindow.xaml
    /// </summary>
    public partial class InvitationsWindow : Window
    {
        public MealSharers system
        {
            get;
            set;
        }

        public EaterMainWindow main
        {
            get;
            set;
        }

        public Boolean goback
        {
            get;
            set;
        }
        public InvitationsWindow(MealSharers system,EaterMainWindow main )
        {
            this.system = system;
            this.main = main;
            InitializeComponent();
            loadTable();
            
        }

        public void loadTable()
        {
            listView.ItemsSource = system.listMealsInvitations();
        }

        private void acceptMeal(object sender, RoutedEventArgs e)
        {
            Meal m = (Meal)((Button)sender).Tag;
            m.acceptMeal();
            loadTable();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }
    }
}
