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

        public void Increment()
        {
            NbrVotes++;
        }

        public void Reset()
        {
            NbrVotes = 0;
        }

        public int NbrVotes { get; set; }

        private void button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
			Increment();
            //HighlightRect.Seek(TimeSpan.FromMilliseconds(0));
            HighlightRect.Begin();
        }
    }
}
