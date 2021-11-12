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

namespace task_6_circles
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
            if (RadioCircle.IsChecked.Value)
            {
                
                try
                {
                    //создаем новый объект класса круг
                    Circle myCircle = new Circle();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для круга
                    myCircle.SetRadius(Double.Parse(TextRadius.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для кругов
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Площадь: " + myCircle.Area(); //здесь получаем площадь созданного объекта круга
                    StackCircles.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
            if (RadioCylinder.IsChecked.Value)
            {
                try
                {
                    //создаем новый объект класса цилиндр
                    Cylinder1 myCylinder = new Cylinder1();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для цилиндра
                    //устанавливаем высоту для цилиндра
                    myCylinder.SetRadius(Double.Parse(TextRadius.Text));

                    myCylinder.SetHeight(Double.Parse(TextHeight.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для цилиндров
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объём: " + myCylinder.Volume(); //здесь получаем объём созданного объекта цилиндра
                    StackCylinders.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
            if (RadioSphere.IsChecked.Value)
            {
                try
                {
                    //создаем новый объект класса сфера
                    Sphere1 mySphere = new Sphere1();

                    //вызываем метод этого объекта
                    //устанавливаем радиус для сферы
                    mySphere.SetRadius(Double.Parse(TextRadius.Text));

                    //создаем новый блок с текстом, который отправится в StackPanel для сфер
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Объём: " + mySphere.Volume(); //здесь получаем объем созданного объекта сферы
                    StackSpheres.Children.Add(myTextBlock);
                }
                catch (Exception ex)
                {
                    LabelRadius.Foreground = Brushes.Red;
                }
            }
        }

        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(LabelRadius.Foreground!=Brushes.Black)
                LabelRadius.Foreground = Brushes.Black;
        }
    }
}
