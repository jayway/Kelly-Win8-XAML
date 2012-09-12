using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Kelly.App
{
    public sealed partial class VoteButtonCtrl : UserControl
    {
        public VoteButtonCtrl()
        {
            InitializeComponent();
        }

        private void rect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Increment();
            //HighlightRect.Seek(TimeSpan.FromMilliseconds(0));
            HighlightRect.Begin();
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
    }
}
