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
            if (tb_ekran2.Text.First() == '∞')
            {
                MessageBox.Show("Очистите запись");
                tb_ekran2.Text = "";
            }
            else
            {
                first_number = Convert.ToDouble(tb_ekran2.Text);
                tb_ekran2.Text += "+";
                tb_ekran1.Text = tb_ekran2.Text;
                tb_ekran2.Text = "";
            }
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (tb_ekran2.Text.First() == '∞')
            {
                MessageBox.Show("Очистите запись");
                tb_ekran2.Text = "";
            }
            else
            {
                first_number = Convert.ToDouble(tb_ekran2.Text);
                tb_ekran2.Text += "-";
                tb_ekran1.Text = tb_ekran2.Text;
                tb_ekran2.Text = "";
            }
        }

        private void btn_um_Click(object sender, RoutedEventArgs e)
        {
            if (tb_ekran2.Text.First() == '∞')
            {
                MessageBox.Show("Очистите запись");
                tb_ekran2.Text = "";
            }
            else
            {
                first_number = Convert.ToDouble(tb_ekran2.Text);
                tb_ekran2.Text += "*";
                tb_ekran1.Text = tb_ekran2.Text;
                tb_ekran2.Text = "";
            }
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            if (tb_ekran2.Text.First() == '∞')
            {
                MessageBox.Show("Очистите запись");
                tb_ekran1.Text = "";
            }
            else
            {
                first_number = Convert.ToDouble(tb_ekran2.Text);
                tb_ekran2.Text += "/";
                tb_ekran1.Text = tb_ekran2.Text;
                tb_ekran2.Text = "";
            }
        }

        private void btn_ravno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                second_number = Convert.ToDouble(tb_ekran2.Text);
                if (tb_ekran1.Text.Last() == '+')
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "";
                    tb_ekran2.Text = Plus(first_number, second_number);
                }
                else if (tb_ekran1.Text.Last() == '-')
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "";
                    tb_ekran2.Text = Minus(first_number, second_number);
                }
                else if (tb_ekran1.Text.Last() == '*')
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "";
                    tb_ekran2.Text = Umnoj(first_number, second_number);
                }
                else if (tb_ekran1.Text.Last() == '/')
                {
                    tb_ekran1.Text = "";
                    tb_ekran2.Text = "";
                    tb_ekran2.Text = Delit(first_number, second_number);
                }
            }
            catch
            {

            }    
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            tb_ekran1.Text = "";
            tb_ekran2.Text = "";
        }

        public string Plus(double first, double second)
        {
            tb_ekran1.Text = "";
            tb_ekran2.Text = "";
            return Convert.ToString(first + second);
        }

        public string Minus(double first, double second)
        {
            tb_ekran1.Text = "";
            tb_ekran2.Text = "";
            return Convert.ToString(first - second);
        }

        public string Umnoj(double first, double second)
        {
            tb_ekran1.Text = "";
            tb_ekran2.Text = "";
            return Convert.ToString(first * second);
        }

        public string Delit(double first, double second)
        {
            try
            {
                tb_ekran1.Text = "";
                tb_ekran2.Text = "";
                return Convert.ToString(first / second);
            }
            catch
            {
                tb_ekran1.Text = "";
                return "Ошибка";
            }
        }
    }
}
