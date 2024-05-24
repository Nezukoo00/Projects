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

namespace Projects
{
    /// <summary>
    /// Логика взаимодействия для WordCountWindow.xaml
    /// </summary>
    public partial class WordCountWindow : Window
    {
        public WordCountWindow()
        {
            InitializeComponent();
        }
        private void CountWords(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            int wordCount = CountWordsInString(input);
            ResultTextBlock.Text = $"Word count: {wordCount}";
        }

        private int CountWordsInString(string input)
        {
            return input.Split(new[] { ' ', '\t', '\n' }, System.StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
