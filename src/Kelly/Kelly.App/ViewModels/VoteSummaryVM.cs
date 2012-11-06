using System;
using System.Collections.ObjectModel;
using Kelly.App.Common;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Media;
using Windows.UI;

namespace Kelly.App.ViewModels
{
    public class VoteSummaryVM : BindableBase
    {
       

        public VoteSummaryVM()
        {
            VoteData = new ObservableCollection<VoteData>();
#if DEBUG
            if (DesignMode.DesignModeEnabled)
            {
                VoteData.Add(new VoteData()
                {
                    Fill = new SolidColorBrush(Colors.Red),
                    VotePercentage = 0.1
                    });
                VoteData.Add(new VoteData()
                {
                    Fill = new SolidColorBrush(Colors.Yellow),
                    VotePercentage = 0.2
                });
                VoteData.Add(new VoteData()
                {
                    Fill = new SolidColorBrush(Colors.Green),
                    VotePercentage = 0.7
                });
            }
#endif
        }

        public VoteSummaryVM(VoteSet voteSet) : this()
        {
            VoteData.Add(voteSet.GetVoteData(voteSet.RedCount, Colors.Red));
            VoteData.Add(voteSet.GetVoteData(voteSet.YellowCount, Colors.Yellow));
            VoteData.Add(voteSet.GetVoteData(voteSet.GreenCount, Colors.Green));
        }

        public ObservableCollection<VoteData> VoteData { get; set; }

    }
}
