using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Kelly.App.UserControls
{
    public sealed partial class VoteButtonCtrl : UserControl
    {
        public VoteButtonCtrl()
        {
            InitializeComponent();
        }

        private void button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            //HighlightRect.Seek(TimeSpan.FromMilliseconds(0));
            HighlightRect.Begin();
            NbrVotes++;
        }

        public static readonly DependencyProperty NbrVotesProperty =
            DependencyProperty.Register("NbrVotes", typeof (int), typeof (VoteButtonCtrl), new PropertyMetadata(default(int)));

        public int NbrVotes
        {
            get { return (int) GetValue(NbrVotesProperty); }
            set { SetValue(NbrVotesProperty, value); }
        }
    }
}
