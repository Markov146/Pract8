using System;
using System.Collections.Generic;
using System.Windows;
using Serealize_deserLib;

namespace lib
{
    /// <summary>
    /// Логика взаимодействия для Deser_SerialWindow.xaml
    /// </summary>
    public partial class Deser_SerialWindow : Window
    {
        public static string way = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string message;
        public Deser_SerialWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Model_TXT.Text) || string.IsNullOrEmpty(Mileage_TXT.Text) || string.IsNullOrEmpty(Price_TXT.Text))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            Car st = new Car();
            st.Model = Model_TXT.Text;
            st.Mileage = Mileage_TXT.Text;
            st.Price = Price_TXT.Text;

            Serealize_deser.Serialize(new List<Car>() { st }, way);
            if (App.Language == "RU") message = "Сериализация прошла успешно!";
            else message = "Serialization was successful!";
            MessageBox.Show(message);

            Model_TXT.Text = null;
            Mileage_TXT.Text = null;
            Price_TXT.Text = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Car> students = new List<Car>();
            cars = Serealize_deser.Deserialize<Car>(way);
            if (students.Count == 0)
            {
                if (App.Language == "RU") message = "Файл пустой!";
                else message = "File is empty!";
                MessageBox.Show(message);
                return;
            }

            Model_TXT.Text = cars[0].Name;
            Mileage_TXT.Text = cars[0].Surname;
            Price_TXT.Text = cars[0].Group;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            Close();
        }
    }
}
