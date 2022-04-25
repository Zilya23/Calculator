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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double first_number;
        public double second_number;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "1";
        }

        private void btn_two_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "2";
        }

        private void btn_three_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "3";
        }

        private void btn_four_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "4";
        }

        private void btn_five_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "5";
        }

        private void btn_six_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "6";
        }

        private void btn_seven_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "7";
        }

        private void btn_eight_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "8";
        }

        private void btn_nine_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "9";
        }

        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran2.Text += "0";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(tb_ekran2.Text);
            tb_ekran2.Text += "+";
            tb_ekran1.Text = tb_ekran2.Text;
            tb_ekran2.Text = "";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(tb_ekran2.Text);
            tb_ekran2.Text += "-";
            tb_ekran1.Text = tb_ekran2.Text;
            tb_ekran2.Text = "";
        }

        private void btn_um_Click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(tb_ekran2.Text);
            tb_ekran2.Text += "*";
            tb_ekran1.Text = tb_ekran2.Text;
            tb_ekran2.Text = "";
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            first_number = Convert.ToDouble(tb_ekran2.Text);
            tb_ekran2.Text += "/";
            tb_ekran1.Text = tb_ekran2.Text;
            tb_ekran2.Text = "";
        }

        private void btn_ravno_Click(object sender, RoutedEventArgs e)
        {
            second_number = Convert.ToDouble(tb_ekran2.Text);
            if(tb_ekran1.Text.Last() == '+')
            {
                tb_ekran1.Text = "";
                tb_ekran2.Text = "";
                tb_ekran2.Text = Convert.ToString(first_number + second_number);
            }
            else if(tb_ekran1.Text.Last() == '-')
            {
                tb_ekran1.Text = "";
                tb_ekran2.Text = "";
                tb_ekran2.Text = Convert.ToString(first_number - second_number);
            }
            else if (tb_ekran1.Text.Last() == '*')
            {
                tb_ekran1.Text = "";
                tb_ekran2.Text = "";
                tb_ekran2.Text = Convert.ToString(first_number * second_number);
            }
            else if (tb_ekran1.Text.Last() == '/')
            {
                try
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "";
                    tb_ekran2.Text = Convert.ToString(first_number / second_number);
                }
                catch
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "Ошибка";
                }
            }
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran1.Text = "";
            tb_ekran2.Text = "";
        }
    }
}
