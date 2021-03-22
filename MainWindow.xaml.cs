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

namespace zadanie1
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

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void lb3_TextChanged(object sender, EventArgs e)
        {
        }
        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lb3.Content = "I = " + (double.Parse(tb1.Text) / double.Parse(tb2.Text));
            lb1.Content = "U = " + double.Parse(tb1.Text);
            lb2.Content = "R = " + double.Parse(tb2.Text);
        }
    }
}
