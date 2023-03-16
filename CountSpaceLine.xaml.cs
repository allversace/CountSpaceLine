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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            res.IsReadOnly = true;
            vvod.MaxLength = 50;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string vvod1 = Convert.ToString(vvod.Text);
            int n = 0;
            for (int i = 0; i < vvod.Text.Length; i++)
            {
                if (vvod.Text[i] == ' ')
                    n++;
            }
            res.Text = n.ToString();
        }
    }
}
