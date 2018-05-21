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

namespace NewFlashCardApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Hide();
            var LoginForm = new frm_Login();
            LoginForm.Show();

        }

        private void btn_HighScore_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Hide();
            var HighScoresForm = new HighScores();
            HighScoresForm.Show();
        }

        private void btn_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Hide();
            var CreateUsersForm = new CreateUser();
            CreateUsersForm.Show();
        }

        private void btn_Admin_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Hide();
            var AdminForm = new Admin();
            AdminForm.Show();
        }
    }
}
