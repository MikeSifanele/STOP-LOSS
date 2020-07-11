using System.Text.RegularExpressions;
using System.Windows.Input;

namespace MtApi5TestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private ViewModel viewModel { get; }

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ViewModel();
            mainGrid.DataContext = viewModel;

            resolution.SelectionChanged += Resolution_SelectionChanged;

            viewModel.ExecuteConnect(null);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            viewModel.Close();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void buttonTrain_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (mainChart != null)
            {

            }
        }

        private void Resolution_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (viewModel != null)
                viewModel.Resolution = resolution.SelectedItem.ToString();
        }
        ~MainWindow()
        {
            resolution.SelectionChanged -= Resolution_SelectionChanged;
        }
    }
}
