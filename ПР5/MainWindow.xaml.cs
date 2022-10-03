using System;
using System.Windows;
using System.Windows.Input;

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
            cmb2.SelectedIndex = -1;
            txtKol.Text = "";
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            oneClick.Visibility = Visibility.Collapsed;
            twoClick.Visibility = Visibility.Visible;
            rezone.Visibility = Visibility.Collapsed;
            btnEnter.Visibility = Visibility.Visible;
            cmb1.SelectedIndex = -1;
            txtKolKm.Text = "";
            txtKolM.Text = "";
        }
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (one.IsChecked == true)
            {
                if (txtKolKm.Text!="" && txtKolM.Text != "")
                {
                    double rez;
                    int kolKm = Convert.ToInt32(txtKolKm.Text);
                    int kolM = Convert.ToInt32(txtKolM.Text);
                    switch (cmb1.SelectedIndex)
                    {
                        case 0:
                            rez = (kolKm * 1000 + kolM) * 0.000621371;
                            txtRez.Text = Convert.ToString(rez);
                            showRez();
                            break;
                        case 1:
                            rez = (kolKm * 1000 + kolM) * 3.28084;
                            txtRez.Text = Convert.ToString(rez);
                            showRez();
                            break;
                        case 2:
                            rez = (kolKm * 1000 + kolM) * 1.09361;
                            txtRez.Text = Convert.ToString(rez);
                            showRez();
                            break;
                        case 3:
                            rez = (kolKm * 1000 + kolM) * 39.3701;
                            txtRez.Text = Convert.ToString(rez);
                            showRez();
                            break;
                        case 4:
                            rez = (kolKm * 1000 + kolM) * 0.000937383;
                            txtRez.Text = Convert.ToString(rez);
                            showRez();
                            break;
                        default:
                            MessageBox.Show("Выберите из списка единицу измерения, в которую нужно перевести!!!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные!");
                }
            }
            if (two.IsChecked == true)
            {
                if (txtKol.Text!="")
                {
                    try
                    {
                        double kol = Convert.ToDouble(txtKol.Text);
                        double qq;
                        switch (cmb2.SelectedIndex)
                        {
                            case 0:
                                qq = kol * 1609.34;
                                podsch(qq);
                                showRez2();
                                break;
                            case 1:
                                qq = kol * 0.3048;
                                podsch(qq);
                                showRez2();
                                break;
                            case 2:
                                qq = kol * 0.9144;
                                podsch(qq);
                                showRez2();
                                break;
                            case 3:
                                qq = kol * 0.0254;
                                podsch(qq);
                                showRez2();
                                break;
                            case 4:
                                qq = kol * 1066.8;
                                podsch(qq);
                                showRez2();
                                break;
                            default:
                                MessageBox.Show("Выберите из списка единицу измерения, которую нужно перевести!!!");
                                break;
                        }
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Вы ввели данные неправильного формата! Для выделения дробных частей используйте запятую!");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите единицу измерения и введите данные!");
                }
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
        private void txtKolKm_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        private void showRez()
        {
            rezone.Visibility = Visibility.Visible;
            reztwo.Visibility = Visibility.Collapsed;
        }
        private void showRez2()
        {
            reztwo.Visibility = Visibility.Visible;
            rezone.Visibility = Visibility.Collapsed;
        }
    }
}
