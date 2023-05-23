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

namespace Pr3_3453
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
            int a = int.Parse(secondsTextBox.Text);
            int sum = (a / 10) + (a % 10);
            if (sum % 3 == 0)
            {
                txtOtv.Text = $"Сумма цифр кратна 3";
            }
            else
            {
                txtOtv.Text = $"Сумма цифр не кратна 3";
            }

        }
    }
}
