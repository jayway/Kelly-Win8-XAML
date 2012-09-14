using System;
using System.Collections.ObjectModel;
using Kelly.App.Common;
using Windows.ApplicationModel;

namespace Kelly.App.ViewModels
{
    public class HistoryPageVM : BindableBase
    {
        public HistoryPageVM()
        {
            VoteSets = new ObservableCollection<VoteSet>();
#if DEBUG
            if (DesignMode.DesignModeEnabled)
            {
                VoteSets.Add(new VoteSet()
                {
                    StartTime = DateTime.Now.AddHours(-1),
                    EndTime = DateTime.Now,
                    RedCount = 5,
                    GreenCount = 0,
                    YellowCount = 100,
                    HasEnded = true,
                    Title = "Session that has ended"
                });
                VoteSets.Add(new VoteSet()
                {
                    StartTime = DateTime.Now.AddHours(-1),
                    EndTime = DateTime.Now,
                    RedCount = 5,
                    GreenCount = 0,
                    YellowCount = 100,
                    HasEnded = true,
                    Title = "Session that has ended"
                });
                VoteSets.Add(new VoteSet()
                {
                    StartTime = DateTime.Now.AddHours(-1),
                    EndTime = DateTime.Now,
                    RedCount = 5,
                    GreenCount = 0,
                    YellowCount = 100,
                    HasEnded = true,
                    Title = "Session that has ended"
                });
                VoteSets.Add(new VoteSet()
                {
                    StartTime = DateTime.Now,
                    RedCount = 1,
                    GreenCount = 1,
                    YellowCount = 1,
                    HasEnded = false,
                    Title = "Session that is running"
                });
            }
#endif
        }

        public ObservableCollection<VoteSet> VoteSets { get; set; }
    }
}
