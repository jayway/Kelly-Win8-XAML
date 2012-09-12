using Kelly.App.Common;

namespace Kelly.App.ViewModels
{
    public class MainPageVM : BindableBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


    }
}