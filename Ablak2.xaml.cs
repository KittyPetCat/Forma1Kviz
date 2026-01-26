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
using System.Windows.Shapes;

namespace Forma1Kviz
{
    /// <summary>
    /// Interaction logic for Ablak2.xaml
    /// </summary>
    public partial class Ablak2 : Window
    {
        public Ablak2()
        {
            InitializeComponent();
        }

        private void tovabb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void felad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ablak1 = new MainWindow();
            ablak1.Show();
            this.Close();
        }
    }
}
