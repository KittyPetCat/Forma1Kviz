using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace Forma1Kviz
{
    public class Kerdes1
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string Difficulty { get; set; }
    }

    public partial class Nehez : Window
    {
        List<Kerdes1> kerd = new List<Kerdes1>();
        int currentIndex = 0;
        int score = 0;

        public Nehez()
        {
            InitializeComponent();
            LoadQuestionsFromJson();
            LoadQuestion();
        }

        private void LoadQuestionsFromJson()
        {
            string json = File.ReadAllText("questions_utf8.json", Encoding.UTF8);
            kerd = JsonSerializer.Deserialize<List<Kerdes1>>(json);
        }

        private void LoadQuestion()
        {
            Kerdes1 q = kerd[currentIndex];

            QuestionText.Text = q.Text;

            valasz1.Content = q.Options[0];
            valasz2.Content = q.Options[1];
            valasz3.Content = q.Options[2];
            valasz4.Content = q.Options[3];

            valasz1.IsChecked = false;
            valasz2.IsChecked = false;
            valasz3.IsChecked = false;
            valasz4.IsChecked = false;

            NextButton.IsEnabled = false;
        }

        private void Answer_Checked(object sender, RoutedEventArgs e)
        {
            NextButton.IsEnabled = true;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = GetSelectedAnswerIndex();

            if (selectedIndex == kerd[currentIndex].CorrectAnswerIndex)
            {
                score++;
            }

            currentIndex++;

            if (currentIndex < kerd.Count())
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show($"Kvíz vége!\nPontszám: {score}/{kerd.Count}");
                Close();
            }
            ;
        }

        private int GetSelectedAnswerIndex()
        {
            if (valasz1.IsChecked == true) return 0;
            if (valasz2.IsChecked == true) return 1;
            if (valasz3.IsChecked == true) return 2;
            return 3;
        }

        private void GiveUp_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Biztos feladod?",
                "Feladás",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show($"Eddigi pontszám: {score}");
                Close();
            }
        }
    }
}
