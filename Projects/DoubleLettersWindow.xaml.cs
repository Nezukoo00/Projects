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
using System.Text.RegularExpressions;

namespace Projects
{
    /// <summary>
    /// Логика взаимодействия для DoubleLettersWindow.xaml
    /// </summary>
    public partial class DoubleLettersWindow : Window
    {
        public DoubleLettersWindow()
        {
            InitializeComponent();
        }
        private void FindDoubleLetters(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            var matches = Regex.Matches(input, @"(\w)\1");
            ResultTextBlock.Text = string.Join(", ", matches);
        }
    }
}
