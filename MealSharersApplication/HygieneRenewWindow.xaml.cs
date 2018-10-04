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
    /// Interaction logic for HygieneWindow.xaml
    /// </summary>
    public partial class HygieneRenewWindow : Window
    {
        public MealSharers system
        {
            get;
            set;
        }

        public CookProfileWindow signup
        {
            get;
            set;
        }
        public String request
        {
            get;
            set;
        }

        public HygieneRenewWindow(MealSharers system, CookProfileWindow signup)
        {
            InitializeComponent();
            request = "NO";
            this.system = system;
            this.signup = signup;
        }

        

        private void obtainHygieneCer(object sender, RoutedEventArgs e)
        {
            if (request.Equals("OK"))
            {
                system.requestHygienic = true;
                signup.button.Visibility = Visibility.Hidden;
                    DateTime today = DateTime.Today;
                    today.AddYears(3);
                    system.currentCook.hygieneStatus = "OK";
                    String dateHygienic = today.ToShortDateString();
                    system.currentCook.hygieneExpiryDate = dateHygienic;
                    signup.labelhystatus.Content = "OK";
                    signup.labelhyexpire.Content = dateHygienic;
                    

            }
            this.Close();
        }

        private void cancelButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void yesChecked(object sender, RoutedEventArgs e)
        {
            request = "OK";

        }

        private void noChecked(object sender, RoutedEventArgs e)
        {
            request = "NO";
        }
    }
}
