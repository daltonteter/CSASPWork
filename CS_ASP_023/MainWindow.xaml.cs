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

namespace CS_ASP_023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double[ , ] priceGrid;

        public MainWindow()
        {
            InitializeComponent();

            priceGrid = new double[3, 3];

            priceGrid[0, 1] = 350.00;
            priceGrid[0, 2] = 700.00;
            priceGrid[1, 0] = 400.00;
            priceGrid[1, 2] = 550.00;
            priceGrid[2, 0] = 375.00;
            priceGrid[2, 1] = 500.00;

            //label3.Content = priceGrid[1, 2].ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int fromCity;

            if (checkBoxFromChicago.IsChecked == true) fromCity = 0;
            else if (checkBoxFromNyYork.IsChecked == true) fromCity = 1;
            else fromCity = 2;


            int toCity;

            if (checkBoxToChicago.IsChecked == true) toCity = 0;
            else if (checkBoxToNyYork.IsChecked == true) toCity = 1;
            else toCity = 2;


            if (fromCity == toCity)
            {
                return;
                label3.Content = " ";
            }
            else label3.Content = priceGrid[fromCity, toCity].ToString();

        }
    }
}
