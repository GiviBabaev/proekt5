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
using System.Windows.Shapes;

namespace proekt5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);

            double sum = 1; 
            int factorial = 1; 

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }

            otv.Text=("Сумма выражения: " + sum);
        }
    }
}
