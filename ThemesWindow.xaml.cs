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

namespace lib
{
    /// <summary>
    /// Логика взаимодействия для ThemesWindow.xaml
    /// </summary>
    public partial class ThemesWindow : Window
    {
        public ThemesWindow()
        {
            InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = ListBox.SelectedIndex;

            switch (selected)
            {
                case 0:
                    App.Theme = "BlueTheme";
                    break;
                case 1:
                    App.Theme = "Greentheme";
                    break;
                case 2:
                    App.Theme = "OrangeTheme";
                    break;
                case 3:
                    App.Theme = "RedTheme";
                    break;
                case 4:
                    App.Theme = "YellowTheme";
                    break;

                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}
