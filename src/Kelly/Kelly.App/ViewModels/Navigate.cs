using Windows.UI.Xaml.Controls;

namespace Kelly.App.ViewModels
{
    public class Navigate
    {
        private static Frame _rootFrame;

        public static void ToHistoryPage()
        {
            _rootFrame.Navigate(typeof (HistoryPage));
        }

        public static void Init(Frame rootFrame)
        {
            _rootFrame = rootFrame;
        }
    }
}