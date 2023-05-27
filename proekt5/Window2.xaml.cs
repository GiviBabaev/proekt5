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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);
            int k = int.Parse(vod2.Text);

            double sum = 0; 

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(i, k);
            }

            otv.Text=("Сумма выражения: " + sum);
        }
    }
}
