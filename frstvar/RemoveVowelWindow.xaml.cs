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
    /// Логика взаимодействия для RemoveVowelWindow.xaml
    /// </summary>
    public partial class RemoveVowelWindow : Window
    {
        public RemoveVowelWindow()
        {
            InitializeComponent();
        }

        private void OnReplaceVowelsClick(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                ResultTextBlock.Text = "Please enter a valid text.";
                return;
            }

            string result = ReplaceVowelsWithAsterisk(input);
            ResultTextBlock.Text = result;
        }

        private string ReplaceVowelsWithAsterisk(string input)
        {
            string vowels = "AEIOUaeiouУЕАОЭЯИЮуеаоэяию";
            foreach (char vowel in vowels)
            {
                input = input.Replace(vowel, '*');
            }
            return input;
        }
    }
}

