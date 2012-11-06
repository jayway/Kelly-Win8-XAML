using Kelly.App.ViewModels;
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

namespace Kelly.App.UserControls
{
    public sealed partial class VoteSummaryCtrl : UserControl
    {
        public VoteSummaryCtrl()
        {
            this.InitializeComponent();
            this.Loaded += VoteSummaryCtrl_Loaded;

        }

        void VoteSummaryCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            var voteSet = DataContext as VoteSet;

            var vm = new VoteSummaryVM(voteSet);
            DataContext = vm;
        }
    }
}
