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
    /// Interaction logic for CookProfileWindow.xaml
    /// </summary>
    public partial class CookProfileWindow : Window
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
        public CookProfileWindow(MealSharers system, Window main)
        {
            goback = false;
            this.system = system;
            this.main = main;
            InitializeComponent();
            Cook e = system.currentCook;
            if (e != null)
            {
                labelUserName.Content = e.userName;
                labelName.Content = e.name;
                labelAdress.Content = e.address;
                labelPhone.Content = e.phone;
                labelPostCode.Content = e.postCode;
                labelFood.Content = e.foodPreference;
                labelRating.Content = e.rating + "";
                labelpvgissue.Content = e.PVGIssueDate;
                labelpvgstatus.Content = e.PVGstatus;
                if (e.hygieneStatus.Equals("renewal"))
                {
                    labelhystatus.Content = "Renewal";
                    labelhystatus.Foreground = new SolidColorBrush(Colors.Red);
                    button.Visibility = Visibility.Visible;
                }
                else
                {
                    labelhystatus.Content = e.hygieneStatus;
                }
                labelhyexpire.Content = e.hygieneExpiryDate;
                

            }
            loadTable();
        }
        private void loadTable()
        {
            listView.ItemsSource = system.listMyReviewsCook();

        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            goback = true;
            main.Show();
            this.Close();
        }

        private void renewalHygiene(object sender, RoutedEventArgs e)
        {
            HygieneRenewWindow window = new HygieneRenewWindow(system, this);
            window.Show();
        }

        
    }
}
