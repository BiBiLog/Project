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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double db1, db2, result;
            db1 = Double.Parse(Text1.Text);
            db2 = Double.Parse(Text2.Text);
            result = db1 * db2;
            Text3.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Text1.Text = null;
            Text2.Text = null;
            Text3.Text = null;
        }
    }
}
