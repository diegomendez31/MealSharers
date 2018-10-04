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
    /// Interaction logic for EaterProfileWindow.xaml
    /// </summary>
    public partial class EaterProfileWindow : Window
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
        public EaterProfileWindow(MealSharers system, Window main)
        {
            goback = false;
            this.system = system;
            this.main = main;
            InitializeComponent();
            Eater e = system.currentEater;
            if (e != null)
            {
                labelUserName.Content = e.userName;
                labelName.Content = e.name;
                labelAdress.Content = e.address;
                labelPhone.Content = e.phone;
                labelPostCode.Content = e.postCode;
                labelFood.Content = e.foodPreference;
                labelRating.Content = e.rating+""; 

            }
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }
    }
}
