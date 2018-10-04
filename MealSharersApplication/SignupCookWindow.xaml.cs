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
    /// Interaction logic for SignupCookWindow.xaml
    /// </summary>
    public partial class SignupCookWindow : Window
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

        public Boolean form
        {
            get;
            set;
        }

        public SignupCookWindow(MealSharers system, Window main)
        {
            InitializeComponent();
            this.main = main;
            this.system = system;
            goback = false;
            form = false;
            comboBoxFood.ItemsSource = system.foodPreference.ToList();
            comboBoxTransport.ItemsSource = system.transport.ToList();
        }


        private void requestPVG(object sender, RoutedEventArgs e)
        {
            PVGWindow window = new PVGWindow(system, this);
            window.ShowDialog();
        }

        private void hygieneOpen(object sender, RoutedEventArgs e)
        {
            HygieneWindow window = new HygieneWindow(system, this);
            window.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!goback)
            { main.Close(); }
      
        }

        private void signupCook(object sender, RoutedEventArgs e)
        {
            form = false;
            String foodPreference = "None";
            String transport = "None";
            String error = "Please fill the form correctly";
            String name = textBoxName.Text;
            if(name.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            String username = textBoxUsername.Text;
            if(username.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            String password = textBoxPassword.Password.ToString();
            if(password.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            String address = textBoxAddress.Text;
            if(address.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            String postcode = textBoxPostcode.Text;
            if(postcode.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            String phone = textBoxPhone.Text;
            if(phone.Equals("")){
                label_Copy7.Content = error;
                form = true;
            }
            if (comboBoxFood.SelectedItem != null)
            {
                foodPreference = comboBoxFood.SelectedItem.ToString();
            }
            else { label_Copy7.Content = error; }
            if (comboBoxTransport.SelectedItem != null)
            {
                 transport = comboBoxTransport.SelectedItem.ToString();
            }
             else { label_Copy7.Content = error; form = true; }
            if (!form)
            {
                if (!system.cooks.ContainsKey(username))
                {

                    system.registerCook(username, password, name, address, postcode, phone, foodPreference, transport);
                    goback = true;
                    main.Show();
                    this.Close();
                }
                else { label_Copy7.Content = "User already exists"; }
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
