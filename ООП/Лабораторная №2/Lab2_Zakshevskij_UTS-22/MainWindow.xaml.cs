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

namespace Lab2_Zakshevskij_UTS_22
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            if (Rb1.IsChecked==true)
            {
                int ColorIndex = Cb1.SelectedIndex;
                switch (ColorIndex)
                {
                    case 0:
                        Wind.Background = Brushes.Red;
                        break;
                    case 1:
                        Wind.Background = Brushes.Orange;
                        break;
                    case 2:
                        Wind.Background = Brushes.Yellow;
                        break;
                    case 3:
                        Wind.Background = Brushes.Green;
                        break;
                    case 4:
                        Wind.Background = Brushes.Blue;
                        break;
                }
            }
            if (Rb2.IsChecked==true)
            {
                
                string A = Tb1.Text;
                string F = Tb2.Text;
                string C = Tb3.Text;
                int R = 0;
                int G = 0;
                int B = 0;
                bool res;
                if ((int.TryParse(A, out R))&&(int.TryParse(F, out G))&&(int.TryParse(C, out B)))
                {
                    res = true;
                    R = int.Parse(A);
                    G = int.Parse(F);
                    B = int.Parse(C);
                }
                else
                {
                    res = false;
                    MessageBox.Show("Данные введены некорректно! Повторите ввод.");
                }
                if (res == true)
                {
                    Wind.Background = new SolidColorBrush(Color.FromArgb(255, (byte)R, (byte)G, (byte)B));
                }
            }
        }
    }
}
