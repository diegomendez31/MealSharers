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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MealSharersApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MealSharers system
        {
            get;
            set;
        }
        public MainWindow()
        {
            InitializeComponent();
            system = new MealSharers();

        }
        
        private void openLogIn(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 loginW = new Window1(system, this);
            loginW.Show();
        }

        private void openSignupEater(object sender, RoutedEventArgs e)
        {
            this.Hide();
            signupEaterWindow signWin = new signupEaterWindow(system, this);
            signWin.Show();
        }

        private void openSignupCook(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SignupCookWindow signWin = new SignupCookWindow(system, this);
            signWin.Show();
        }
    }
}
