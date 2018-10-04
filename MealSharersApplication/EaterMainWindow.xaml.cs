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
    /// Interaction logic for EaterMainWindow.xaml
    /// </summary>
    public partial class EaterMainWindow : Window
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

        public EaterMainWindow(MealSharers system, Window main)
        {
            InitializeComponent();
            this.main = main;
            this.system = system;
            goback = false;
            if (system.currentEater != null)
            labelUser.Content = "Welcome " + system.currentEater.name+"!";
            loadTable();
        }

        private void loadTable()
        {
            listView.ItemsSource = system.listMyMealsSystem();
           
        }

        private void signupEater(object sender, RoutedEventArgs e)
        {
            

        }

        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!goback) { main.Close(); }
            
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            main.Show();
            system.logout();
            goback = true;
            this.Close();
            
        }

        private void listMyMeals(object sender, RoutedEventArgs e)
        {
            myMealsEater mymeals = new myMealsEater(system, this);
            mymeals.Show();
            this.Hide();
        }

        private void showProfile(object sender, RoutedEventArgs e){
            EaterProfileWindow win = new EaterProfileWindow(system, this);
            win.Show();
            this.Hide();
        }

        private void showInvitations(object sender, RoutedEventArgs e)
        {
            InvitationsWindow win = new InvitationsWindow(system, this);
            win.Show();
            this.Hide();
        }
        
    }
}
