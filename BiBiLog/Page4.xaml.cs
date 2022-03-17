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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int fact, result;
            int factorial = 1;
            fact = int.Parse(Text1.Text);

            for (int i = 2; i <= fact; i++) 
            {
                factorial = factorial * i;
                result = factorial;
                Text2.Text = result.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text1.Text = null;
            Text2.Text = null;
        }
    }
}
