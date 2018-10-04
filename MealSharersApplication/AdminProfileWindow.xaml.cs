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
    /// Interaction logic for AdminProfileWindow.xaml
    /// </summary>
    public partial class AdminProfileWindow : Window
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
        public AdminProfileWindow(MealSharers system, Window main)
        {
            goback = false;
            this.system = system;
            this.main = main;
            InitializeComponent();
            Administrator e = system.currentAdmin;
            if (e != null)
            {
                labelUserName.Content = e.username;
                labelName.Content = e.name;
                labelPhone.Content = e.phone;
                labelPost.Content = e.postcodeArea;
                
            }
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            system.logout();
            goback = true;
            this.Close();
            main.Show();
        }

    }
}
