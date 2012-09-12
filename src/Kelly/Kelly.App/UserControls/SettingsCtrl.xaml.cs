using Kelly.App.Common;
using Kelly.App.ViewModels;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Kelly.App.UserControls
{
    public sealed partial class SettingsCtrl : UserControl
    {
        public SettingsCtrl()
        {
            InitializeComponent();
        }

        public void Initialize(MainPageVM viewModel)
        {
            DataContext = viewModel;
        }

        private void voteTitleTextBox_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            ((MainPageVM) DataContext).Title = voteTitleTextBox.Text;
            ApplicationData.Current.RoamingSettings.Values[Constants.VOTE_TITLE_SETTINGS_KEY] = ((TextBox)sender).Text;
        }
    }
}
