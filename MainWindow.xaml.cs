using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows;

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
            InitializeComponent(); // ⭐ kötelező WPF-ben

            // JSON beolvasása
            string json = File.ReadAllText("questions.json");

            Questions = JsonSerializer.Deserialize<List<Question>>(json);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ablak2 ablak2 = new Ablak2();
            ablak2.Show();       // új ablak megnyitása
            this.Close();
        }
    }
}
