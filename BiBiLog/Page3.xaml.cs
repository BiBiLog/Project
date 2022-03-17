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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double db1, result;
            db1 = Double.Parse(Text1.Text);
            result = Math.Sqrt(db1);
            Text2.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text1.Text = null;
            Text2.Text = null;
        }
    }
}
