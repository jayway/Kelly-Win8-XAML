using System;
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

            var voteTitle = ApplicationData.Current.RoamingSettings.Values[Constants.VOTE_TITLE_SETTINGS_KEY] as string;
            if (string.IsNullOrEmpty(voteTitle))
            {
                voteTitle = Res.Instance.GetString("DefaultVoteTitle");
            }
            Title = voteTitle;
            Reset();
        }

        private string _title;
        private DateTime _startTime;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand ShowHistory { get; set; }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public void SetTitle(string text)
        {
            Title = text;
        }

        public void Reset()
        {
            _startTime = DateTime.Now;
        }
    }
}