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
    /// Логика взаимодействия для BracketsBalanceWindow.xaml
    /// </summary>
    public partial class BracketsBalanceWindow : Window
    {
        public BracketsBalanceWindow()
        {
            InitializeComponent();
        }

        private void CheckBracketsBalance(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            bool isBalanced = IsBalanced(input);
            ResultTextBlock.Text = isBalanced ? "Balanced" : "Not Balanced";
        }
        private bool IsBalanced(string input)
        { if (string.IsNullOrWhiteSpace(input)) return false;
          bool containsDigit = input.Any(char.IsDigit);
            if(!containsDigit) return false;
            int balance = 0;
            foreach (char c in input)
            {
                if (c == '(') balance++;
                if (c == ')') balance--;
                if (balance < 0) return false;
            }
            return balance == 0;
        }
        
    }
}
