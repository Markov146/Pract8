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

namespace lib
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThemesWindow w = new ThemesWindow();
            w.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Deser_SerialWindow w = new Deser_SerialWindow();
            w.Show();
            Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.Language = "RU";
            ReloadWindow();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Language = "EN";
            ReloadWindow();
        }
        private void ReloadWindow()
        {
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}
