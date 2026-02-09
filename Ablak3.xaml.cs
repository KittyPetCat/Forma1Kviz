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
    /// Interaction logic for Ablak3.xaml
    /// </summary>
    public partial class Ablak3 : Window
    {
        public Ablak3(int pontszam)
        {
            InitializeComponent();
            PontszamRun.Text = pontszam.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ablak1 = new MainWindow();
            ablak1.Show();
            this.Close();
        }
    }
}

