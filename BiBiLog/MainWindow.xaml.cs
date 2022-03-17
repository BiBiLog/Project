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

namespace BiBiLog
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
            FR.Content = new Page1();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            FR.Content = new Page2();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FR.Content = new Page3();
        }

        private void Page1_Copy_Click(object sender, RoutedEventArgs e)
        {
            FR.Content = new Page4();
        }
    }
}
