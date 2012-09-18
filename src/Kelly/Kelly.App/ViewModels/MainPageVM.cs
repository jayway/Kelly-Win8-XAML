using System;
using System.Linq;
using System.Windows.Input;
using Kelly.App.Common;
using Kelly.App.Resources;
using Windows.Storage;

namespace Kelly.App.ViewModels
{
    public class MainPageVM : BindableBase
    {
        public MainPageVM()
        {
            ShowHistory = new ShowHistoryCommand();

            InitRunningSet();
        }

        private void InitRunningSet()
        {
            var runningSet = VoteSetRepo.Instance.AllSets.FirstOrDefault(x => !x.HasEnded);
            if (runningSet == null)
            {
                Reset();
            }
            else
            {
                VoteSet = runningSet;
                Title = runningSet.Title;
            }
        }

        private void SetTitleFromSettingsOrDefault()
        {
            var voteTitle = ApplicationData.Current.RoamingSettings.Values[Constants.VOTE_TITLE_SETTINGS_KEY] as string;
            if (string.IsNullOrEmpty(voteTitle))
            {
                voteTitle = Res.Instance.GetString("DefaultVoteTitle");
            }
            Title = voteTitle;
        }

        public VoteSet VoteSet
        {
            get { return _voteSet; }
            set { SetProperty(ref _voteSet, value); }
        }

        private string _title;
        private VoteSet _voteSet;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
                VoteSet.Title = value;
            }
        }

        public ICommand ShowHistory { get; set; }

        public void SetTitle(string text)
        {
            Title = text;
        }

        public void Reset()
        {
            VoteSet = new VoteSet
                          {
                              StartTime = DateTime.Now
                          };
            SetTitleFromSettingsOrDefault();
        }

        public void HandleResetCountersCommand()
        {
            PutVoteSetInHistory();
            Reset();
        }

        private void PutVoteSetInHistory()
        {
            VoteSet.EndNow();
            VoteSetRepo.Instance.Ensure(VoteSet);
            Reset();
        }

        public void HandleShowHistoryCommand()
        {
            VoteSetRepo.Instance.Ensure(VoteSet);
            ShowHistory.Execute(null);
        }
    }
}