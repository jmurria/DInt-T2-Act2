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

namespace Act2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int operando1 = int.Parse(operando1TextBox.Text);
            int operando2 = int.Parse(operando2TextBox.Text);
            char operador = char.Parse(operadorTextBox.Text);

            string resultado;

            switch (operador)
            {
                case '+':
                    resultado = (operando1 + operando2).ToString();
                    break;
                case '-':
                    resultado = (operando1 - operando2).ToString();
                    break;
                case '*':
                    resultado = (operando1 * operando2).ToString();
                    break;
                case '/':
                    resultado = (operando1 / operando2).ToString();
                    break;
                default:
                    resultado = "ERROR";
                    break;
            }

            resultadoTextBox.Text = resultado.ToString();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = null;
            operando2TextBox.Text = null;
            operadorTextBox.Text = null;
            resultadoTextBox.Text = null;
        }

        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                LimpiarButton_Click(sender, e);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }


    }
}
