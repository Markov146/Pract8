using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace lib
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string DesktopLink = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string ToSaveThemeLink = $"{DesktopLink}\\Themes.txt";
        static string ToSaveLanguageLink = $"{DesktopLink}\\Language.txt";
        private static string theme;
        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/Themes/Themes/{value}.xaml", UriKind.Absolute) };

                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);

                File.WriteAllText(ToSaveThemeLink, value);
            }
        }

        private static string language;
        public static string Language
        {
            get { return language; }
            set
            {
                language = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/LocaLib/Themes/{value}.xaml", UriKind.Absolute) };

                Current.Resources.MergedDictionaries.RemoveAt(1);
                Current.Resources.MergedDictionaries.Insert(1, dict);

                File.WriteAllText(ToSaveLanguageLink, value);
            }
        }

        public App()
        {
            InitializeComponent();
            CheckThemeAndLanguage();
        }
        private void CheckThemeAndLanguage()
        {
            if (File.Exists(ToSaveThemeLink)) Theme = File.ReadAllText(ToSaveThemeLink);
            if (File.Exists(ToSaveLanguageLink)) Language = File.ReadAllText(ToSaveLanguageLink);
        }
    }
}
