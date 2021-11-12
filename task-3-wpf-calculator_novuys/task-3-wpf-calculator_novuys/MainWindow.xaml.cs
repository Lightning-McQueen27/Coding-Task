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

namespace task_3_wpf_calculator_novuys
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

       
        float a, b, zona;
        int count, chisla = 0;
        bool znak = true, nul = true, zap = false, ravno = false;
        int lenght;
        char f;

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '7';
            Buttons_0_to_9();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '6';
            Buttons_0_to_9();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '5';
            Buttons_0_to_9();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '4';
            Buttons_0_to_9();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '3';
            Buttons_0_to_9();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '2';
            Buttons_0_to_9();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '1';
            Buttons_0_to_9();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '8';
            Buttons_0_to_9();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            textBox.Text += '9';
            Buttons_0_to_9();
        }

        private void Button_null_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            if (nul == true)
            {
                textBox.Text += '0';
                chisla += 1;
                nul = false;
            }
            else if (zap == true)
            {
                textBox.Text += '0';
                chisla += 1;
            }
            else
            {
                zona = float.Parse(textBox.Text);
                if (zona > 0)
                {
                    nul = true;
                    textBox.Text += '0';
                    chisla += 1;
                }
            }
        }

        private void Button_zap_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            if (zap == false && chisla >= 1)
            {
                textBox.Text += ',';
                zap = true;
            }
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Function(1);
            Functions();
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Function(2);
            Functions();
        }

        private void Button_pr_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Function(3);
            Functions();
        }

        private void Button_del_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            Function(4);
            Functions();
        }

        private void Button_c_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            label.Content = "";
            Functions();
        }

        private void Button_ce_Click(object sender, RoutedEventArgs e)
        {
            Clear();

            lenght = textBox.Text.Length;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght - 1; i++)
            {
                textBox.Text += text[i];
            }

            while (chisla != 0)
            {
                chisla -= 1;
            }
        }

        private void Button_ravno_Click(object sender, RoutedEventArgs e)
        {
            ravno = true;
            Calculate();
            label.Content = "";
            nul = true;
            zap = false;
            chisla = 0;
        }

        private void Button_change_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            if (znak == true)
            {
                textBox.Text = "-" + textBox.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox.Text = textBox.Text.Replace("-", "");
                znak = true;
            }
        }


        private void Calculate()
        {
            try
            {
                switch (count)
                {
                    case 1:
                        b = a + Convert.ToSingle(textBox.Text);
                        textBox.Text = Convert.ToString(b);
                        break;
                    case 2:
                        b = a - Convert.ToSingle(textBox.Text);
                        textBox.Text = Convert.ToString(b);
                        break;
                    case 3:
                        b = a * Convert.ToSingle(textBox.Text);
                        textBox.Text = Convert.ToString(b);
                        break;
                    case 4:
                        b = a / Convert.ToSingle(textBox.Text);
                        textBox.Text = Convert.ToString(b);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                Clear();
            }
        }
        private void Function(int funct)
        {
            if (chisla > 0)
            {
                switch (funct)
                {
                    case 1:
                        f = '+';
                        count = 1;
                        break;
                    case 2:
                        f = '-';
                        count = 2;
                        break;
                    case 3:
                        f = '*';
                        count = 3;
                        break;
                    case 4:
                        f = '/';
                        count = 4;
                        break;

                    default:
                        break;
                }

                a = Convert.ToSingle(textBox.Text);
                textBox.Clear();
                label.Content = Convert.ToString(a) + f;
                znak = true;
                chisla = 0;
            }

        }

        private void Clear()
        {
            if (ravno == true)
            {
                textBox.Text = "";
                ravno = false;
            }
        }

        private void Buttons_0_to_9()
        {
            nul = true;
            chisla += 1;
        }

        private void Functions()
        {
            nul = true;
            zap = false;
            chisla = 0;
        }
    }
}
