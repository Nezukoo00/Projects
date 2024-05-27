using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string result = Regex.Replace(input, "[AEIOUaeiouАУЕОЭЯЮИуеаоэяию]", "");
            ResultTextBlock.Text = result;
        }
    }
}
