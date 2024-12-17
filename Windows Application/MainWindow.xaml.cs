using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get input text from TextBox
            string inputText = InputTextBox.Text;

            // Display input text in the Label
            OutputLabel.Content = $"You entered: {inputText}";
        }
    }
}
