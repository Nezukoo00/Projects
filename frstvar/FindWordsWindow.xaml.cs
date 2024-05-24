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

namespace frstvar
{
    /// <summary>
    /// Логика взаимодействия для FindWordsWindow.xaml
    /// </summary>
    public partial class FindWordsWindow : Window
    {
        public FindWordsWindow()
        {
            InitializeComponent();
        }
        private void OnFindWordsClick(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                LongestWordTextBlock.Text = "Please enter a valid text.";
                ShortestWordTextBlock.Text = string.Empty;
                return;
            }

            var words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
            var shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();

            LongestWordTextBlock.Text = $"Longest Word: {longestWord}";
            ShortestWordTextBlock.Text = $"Shortest Word: {shortestWord}";
        }
    }
}

