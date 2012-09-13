using System;
using System.Collections.Generic;
using System.Text;
using Kelly.App.Resources;
using Kelly.App.UserControls;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

namespace Kelly.App
{
    /// <summary>
    /// A page that displays a grouped collection of items.
    /// </summary>
    public sealed partial class MainPage : Kelly.App.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Create an appropriate data model for your problem domain to replace the sample data
            //var sampleDataGroups = SampleDataSource.GetGroups((String)navigationParameter);
            //this.DefaultViewModel["Groups"] = sampleDataGroups;
        }

        private async void ShowSummaryButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var summaryText = CreateSummaryText();
            var dialog = new MessageDialog(summaryText, Res.Instance.GetString("SummaryTitle"));
            await dialog.ShowAsync();
        }

        public void ShowSettingsPanel()
        {
            Thickness th = new Thickness(0);
            settingsCtrl.Margin = th;
            settingsCtrl.Visibility = Visibility.Visible;
            settingsCtrl.Initialize(_viewModel);
            // PointerPressed dismisses SettingsPanel
            this.PointerPressed += new PointerEventHandler(HideSettingsPanel);
        }
        private void HideSettingsPanel(object sender, PointerRoutedEventArgs e)
        {
            settingsCtrl.Visibility = Visibility.Collapsed;
            this.PointerPressed -= new PointerEventHandler(HideSettingsPanel);
        }

        private string CreateSummaryText()
        {
            var builder = new StringBuilder();
            ForEachVoteButton(ctrl => builder.AppendLine(string.Format("{0}: {1}", ctrl.Name, ctrl.NbrVotes)));
            return builder.ToString();
        }

        private void ResetCountButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            ForEachVoteButton(ctrl => ctrl.Reset());
            ShowAndFadeOutCountersResetText.Begin();
        }

        private void ForEachVoteButton(Action<VoteButtonCtrl> forEachAction)
        {
            foreach (var child in votingGrid.Children)
            {
                var ctrl = child as VoteButtonCtrl;
                if (ctrl == null) continue;

                forEachAction(ctrl);
            }
        }

        private void ShowHistoryButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            
        }
    }
}
