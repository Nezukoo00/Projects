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
            
            ResultTextBlock.Text = IsBalanced(input) ? "Balanced" : "Not Balanced";
        }
        private bool IsBalanced(string input)
        { 
            if (string.IsNullOrWhiteSpace(input)) return false;

          bool containsDigit = input.Any(char.IsDigit);
            if(!containsDigit) return false;
            
            int balance = 0;
            bool hasContentBetweenBrekets = false;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch ==  '(')
                {
                    balance++;
                    if ( i+ 1 < input.Length && input[i+1] != ')')
                    {
                        hasContentBetweenBrekets = true;
                    }
                }
                else if (ch == ')')
                {
                    balance--;
                    if (balance < 0)
                    {
                        return false;
                    }
                }
                else if(!char.IsWhiteSpace(ch) && balance < 0)
                {
                    hasContentBetweenBrekets = true;
                }

            }
            return balance == 0 && hasContentBetweenBrekets;
        }
        
    }
}
