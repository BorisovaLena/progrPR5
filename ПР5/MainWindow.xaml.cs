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

namespace ПР5
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            oneClick.Visibility = Visibility.Visible;
            twoClick.Visibility = Visibility.Collapsed;
            reztwo.Visibility = Visibility.Collapsed;
            btnEnter.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            oneClick.Visibility = Visibility.Collapsed;
            twoClick.Visibility = Visibility.Visible;
            rezone.Visibility = Visibility.Collapsed;           
            btnEnter.Visibility = Visibility.Visible;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if(one.IsChecked==true)
            {
                double rez;
                int kolKm = Convert.ToInt32(txtKolKm.Text);
                int kolM = Convert.ToInt32(txtKolM.Text);
                switch (cmb1.SelectedIndex)
                {
                    case 0:
                        rez = (kolKm * 1000 + kolM) * 0.000621371;
                        txtRez.Text = Convert.ToString(kolM);
                        break;
                    case 1:
                        rez = (kolKm * 1000 + kolM) * 3.28084;
                        txtRez.Text = Convert.ToString(kolM);
                        break;
                    case 2:
                        rez = (kolKm * 1000 + kolM) * 1.09361;
                        txtRez.Text = Convert.ToString(kolM);
                        break;
                    case 3:
                        rez = (kolKm * 1000 + kolM) * 39.3701;
                        txtRez.Text = Convert.ToString(kolM);
                        break;
                    case 4:
                        rez = (kolKm * 1000 + kolM) * 0.000937383;
                        txtRez.Text = Convert.ToString(kolM);
                        break;
                }
                rezone.Visibility = Visibility.Visible;
                reztwo.Visibility = Visibility.Collapsed;
            }
            else if(two.IsChecked==true)
            {
                double kol = Convert.ToDouble(txtKol.Text);
                
                double qq;
                switch(cmb2.SelectedIndex)
                {
                    case 0:
                        qq = kol * 1609.34;
                        podsch(qq);
                        break;
                    case 1:
                        qq = kol * 0.3048;
                        podsch(qq);
                        break;
                    case 2:
                        qq = kol * 0.9144;
                        podsch(qq);
                        break;
                    case 3:
                        qq = kol * 0.0254;
                        podsch(qq);
                        break;
                    case 4:
                        qq = kol * 1066.8;
                        podsch(qq);
                        break;
                }
                reztwo.Visibility = Visibility.Visible;
                rezone.Visibility = Visibility.Collapsed;
            }
        }

        private void podsch(double qq)
        {
            int kolKm = 0;
            double kolM;
            while (qq > 999)
            {
                kolKm++;
                qq -= 1000;
            }
            kolM = qq;
            RezKm.Text = Convert.ToString(kolKm) + " км";
            RezM.Text = Convert.ToString(kolM) + " м";
        }

    }
}
