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
using System.IO;
using System.Text.Json;




namespace Forma1Kviz
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string Difficulty { get; set; }
    }

    public partial class MainWindow : Window
    {
        public List<Question> Questions { get; set; }

        public MainWindow()
        {
            InitializeComponent(); // kötelező WPF-ben

            // JSON beolvasása
            var json = File.ReadAllText("questions_utf8.json");

            Questions = JsonSerializer.Deserialize<List<Question>>(json);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ablak4 ablak4 = new Ablak4();
            ablak4.Show();       // új ablak megnyitása
            this.Close();
        }

        private void kozepes_Click(object sender, RoutedEventArgs e)
        {
            Ablak4 ablak4 = new Ablak4();
            ablak4.Show();       // új ablak megnyitása
            this.Close();
        }

        private void btnNehez_Click(object sender, RoutedEventArgs e)
        {
            Ablak4 ablak4 = new Ablak4();
            ablak4.Show();       // új ablak megnyitása
            this.Close();
        }
    }
}
