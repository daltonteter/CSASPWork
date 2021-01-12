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

namespace CS_ASP_022
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

        string[] temp = new string[5];

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string[] values = new string[5] { "Bob", "Steve", "Mike", "Bill", "Don" };

            temp = values;
        }

        private void ButtonRecieve_Click(object sender, RoutedEventArgs e)
        {
            textBox0.Text = temp[0];
            textBox1.Text = temp[1];
            textBox2.Text = temp[2];
            textBox3.Text = temp[3];
            textBox4.Text = temp[4];
        }
    }
}
