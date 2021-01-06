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

namespace CS_ASP_020
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

        private void buttonAction_Click(object sender, RoutedEventArgs e)
        {
            string result1 = string.Format("Thank you, {0} for your business.", textBoxName.Text);

            string result2 = string.Format("Phone Number is {0:(000)000-0000} ", textBoxPhone.Text);

            int ss = int.Parse(textBoxSS.Text);

            string result3 = string.Format("Social Security Number is: {0: 000-00-0000}", ss);

            double salary = double.Parse(textBoxSalary.Text);

            string result4 = string.Format("Salary: {0:c}", salary);

            string result5 = string.Format("Loan Date: {0}", loanDate.SelectedDate);

            labelResult1.Content = result1;
            labelResult2.Content = result2;
            labelResult3.Content = result3;
            labelResult4.Content = result4;
            labelResult5.Content = result5;

            //labelResult.Content = result;
        }
    }
}
