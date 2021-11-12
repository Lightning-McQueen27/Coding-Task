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

namespace task_7_salary_tracke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (RadioProd.IsChecked.Value)
            {

                try
                {
                    //создаем новый объект класса продавец
                    Class_prodavez myCircle = new Class_prodavez();

                    //вызываем метод этого объекта
                    //устанавливаем базовую зарплату для продавца
                    myCircle.SetZpbaz(Double.Parse(TextZpbaz.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для продавца
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myCircle.Area(); //здесь получаем зарплату созданного объекта продавец
                    Stack_prod.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioStprod.IsChecked.Value)
            {
                try
                {
                    //создаем новый объект класса старший продавец
                    Class_starprod myCylinder = new Class_starprod();

                    //вызываем метод этого объекта
                    //устанавливаем бозовую зарплату для старшего продавца
                    //устанавливаем прибыль магазина для старшего продавца
                    myCylinder.SetZpbaz(Double.Parse(TextZpbaz.Text));

                    myCylinder.SetPrib(Double.Parse(TextPrib.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для старшего продавца
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myCylinder.Volume(); //здесь получаем зарплату созданного объекта старший продавец
                    Stack_stprod.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioMened.IsChecked.Value)
            {
                try
                {
                    //создаем новый объект класса менеджер
                    Class_maned mySphere = new Class_maned();

                    //вызываем метод этого объекта
                    //устанавливаем базовую зарплату для  менеджера
                    mySphere.SetZpbaz(Double.Parse(TextZpbaz.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для менеджера
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + mySphere.Volume(); //здесь получаем объем созданного объекта менеджера
                    Stack_mened.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (RadioRider.IsChecked.Value)
            {

                try
                {
                    //создаем новый объект класса водитель
                    Class_rider myRider = new Class_rider();

                    //вызываем метод этого объекта
                    //устанавливаем базовую зарплату для водителя
                    myRider.SetZpbaz(Double.Parse(TextZpbaz.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для водителя
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myRider.Area(); //здесь получаем зарплату созданного объекта водитель
                    Stack_rider.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
        }

        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LabelZpbaz.Foreground != Brushes.Black)
                LabelZpbaz.Foreground = Brushes.Black;
        }
    }
}
