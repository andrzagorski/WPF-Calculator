using System.Windows;
using System.Windows.Controls;

namespace JustAnOrdinaryCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CalResult.Text = string.Empty;
            CurrOperation.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalResult.Text = string.Empty;

            var button = sender as Button;
            var curr_number = button.Name[button.Name.Length-1];
            CurrOperation.Text += curr_number;
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            var Result = CurrOperation.Text;

            if (Type_of_operation(Result)){
                CurrOperation.Text = Final_Result(Result).ToString();
            }
                CurrOperation.Text += "+";
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            var Result = CurrOperation.Text;

            if (Type_of_operation(Result)){
                CurrOperation.Text = Final_Result(Result).ToString();
            }

            CurrOperation.Text += "-";
        }

        private void Button_multipli_Click(object sender, RoutedEventArgs e)
        {
            var Result = CurrOperation.Text;

            if (Type_of_operation(Result)){
                CurrOperation.Text = Final_Result(Result).ToString();
            }

            CurrOperation.Text += "*";
        }

        private void Button_divide_Click(object sender, RoutedEventArgs e)
        {
            var Result = CurrOperation.Text;

            if (Type_of_operation(Result)) {
                CurrOperation.Text = Final_Result(Result).ToString();
            }

            CurrOperation.Text += "/";
        }

        private void Button_result_Click(object sender, RoutedEventArgs e)
        {
            var Result = CurrOperation.Text;

            CalResult.Text = Final_Result(Result).ToString();


            CurrOperation.Text = string.Empty;
        }


        private bool Type_of_operation(string operation) {
            return operation.Contains('+') || operation.Contains('-') || operation.Contains('/') || operation.Contains('*');
        }

        private int Final_Result(string Result)
        {

            if (Result.Contains('+')) {

                var addEl = Result.Split('+');

                return  int.Parse(addEl[0]) + int.Parse(addEl[1]);
            }

            if (Result.Contains('-')) {

                var addEl = Result.Split('-');

                return  int.Parse(addEl[0]) - int.Parse(addEl[1]);
            }

            if (Result.Contains('*')) {

                var addEl = Result.Split('*');

                return int.Parse(addEl[0]) * int.Parse(addEl[1]);

            }

            if (Result.Contains('/')) {

                var addEl = Result.Split('/');

                return int.Parse(addEl[0]) / int.Parse(addEl[1]);
            }
            return default;
        }

    }
}
