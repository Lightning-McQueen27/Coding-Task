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

namespace task_5_idle_game_finaly_version
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i;
        public MainWindow()
        {
            InitializeComponent();

            i = 0;
        }

        private void Batton_Click(object sender, MouseButtonEventArgs e)
        {
            i++;
            Texbox.Text = " " + i;
        }
    }
}
