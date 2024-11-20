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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int correctAnswers = 0;
            foreach (RadioButton radioButton in Question_1.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Name == "Answer_1")
                {
                    correctAnswers += 1;
                }
            }
            foreach (RadioButton radioButton in Question_2.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Name == "Answer_24")
                {
                    correctAnswers += 1;
                }
            }
            foreach (RadioButton radioButton in Question_3.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Name == "Answer_34")
                {
                    correctAnswers += 1;
                }
            }
            foreach (RadioButton radioButton in Question_4.Children)
            {
                if (radioButton.IsChecked == true && radioButton.Name == "Answer_42")
                {
                    correctAnswers += 1;
                }
            }
            MessageBox.Show($"Правильных ответов: {correctAnswers.ToString()}");
        }
    }
}
