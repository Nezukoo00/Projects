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
            bool isBalanced = isBalanced(input);
            ResultTextBlock.Text = isBalanced ? "Balanced" : "Not Balance"
        }
        private bool isBalanced(string input)
        {

        }
    }
}
