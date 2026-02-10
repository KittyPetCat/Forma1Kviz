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
using System.Windows;

namespace Forma1Kviz
{
    public partial class Ablak3 : Window
    {
        public Ablak3(int pontszam)
        {
            InitializeComponent();

            // Pontszám megjelenítése
            PontszamRun.Text = pontszam.ToString();

            // Teljesítmény szöveg beállítása pontszám alapján
            if (pontszam >= 18)
            {
                TeljesitmenyText.Text = "Nagyon jó teljesítmény!";
            }
            else if (pontszam >= 11)
            {
                TeljesitmenyText.Text = "Jó teljesítmény!";
            }
            else
            {
                TeljesitmenyText.Text = "Próbáld újra!";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Újraindítás: vissza a MainWindow-hoz
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
