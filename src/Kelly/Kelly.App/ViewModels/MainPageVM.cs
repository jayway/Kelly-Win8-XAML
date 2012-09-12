using Kelly.App.Common;
using Kelly.App.Resources;
using Windows.Storage;

namespace Kelly.App.ViewModels
{
    public class MainPageVM : BindableBase
    {
        public MainPageVM()
        {
            var voteTitle = ApplicationData.Current.RoamingSettings.Values[Constants.VOTE_TITLE_SETTINGS_KEY] as string;
            if (string.IsNullOrEmpty(voteTitle))
            {
                voteTitle = Res.Instance.GetString("DefaultVoteTitle");
            }
            Title = voteTitle;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

    }
}