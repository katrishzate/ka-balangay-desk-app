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

namespace KaBalangay.Views
{
    /// <summary>
    /// Interaction logic for NavBarView.xaml
    /// </summary>
    public partial class NavBarView : Window
    {
        public NavBarView()
        {
            InitializeComponent();
            LoadHomeView();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            LoadHomeView();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAboutView();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRegisterView();
        }

        private void ServicesButton_Click(object sender, RoutedEventArgs e)
        {
            LoadServicesView();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoadLogoutView();
        }

        private void LoadHomeView()
        {
            MainContentControl.Content = new HomeView();
        }
        private void LoadAboutView()
        {
            MainContentControl.Content = new AboutView();
        }

        private void LoadRegisterView()
        {
            MainContentControl.Content = new RegisterView();
        }
        private void LoadServicesView()
        {
            MainContentControl.Content = new ServicesView();
        }

        private void LoadLogoutView()
        {

        }
    }
}
