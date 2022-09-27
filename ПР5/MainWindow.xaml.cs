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
            vvodKmM.Visibility = Visibility.Visible;
            choiceOfUnits.Visibility = Visibility.Visible;
            choiceOfUnits2.Visibility = Visibility.Collapsed;
            vvodKol.Visibility = Visibility.Collapsed;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            vvodKmM.Visibility = Visibility.Collapsed;
            choiceOfUnits.Visibility = Visibility.Collapsed;
            choiceOfUnits2.Visibility = Visibility.Visible;
            vvodKol.Visibility = Visibility.Visible;

        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            double rez;
            int kolKm = Convert.ToInt32(txtKolKm.Text);
            int kolM = Convert.ToInt32(txtKolM.Text);
            switch (cmb1.SelectedIndex)
            {
                case 0:
                    rez = (kolKm * 1000 + kolM) * 0.000621371;
                    txtRez.Text = rez+ " миля";
                    break;
                case 1:
                    rez = (kolKm * 1000 + kolM) * 3.28084;
                    txtRez.Text = rez + " фут";
                    break;
                case 2:
                    rez = (kolKm * 1000 + kolM) * 1.09361;
                    txtRez.Text = rez + " ярд";
                    break;
                case 3:
                    rez = (kolKm * 1000 + kolM) * 39.3701;
                    txtRez.Text = rez + " дюйм";
                    break;
                case 4:
                    rez = (kolKm * 1000 + kolM) * 0.000937383;
                    txtRez.Text = rez + " верст";
                    break;
            }
        }

        private void cmb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(cmb2.SelectedIndex)
            {
                case 0:
                    units.Text = "м";
                    break;
                case 1:
                    units.Text = "фнт";
                    break;
                case 2:
                    units.Text = "ярд";
                    break;
                case 3:
                    units.Text = "дм";
                    break;
                case 4:
                    units.Text = "врст";
                    break;
            }
        }
    }
}
