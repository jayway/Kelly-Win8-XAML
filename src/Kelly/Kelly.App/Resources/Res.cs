using Windows.ApplicationModel.Resources;

namespace Kelly.App.Resources
{
    public class Res
    {
        private static ResourceLoader _instance;
        public static ResourceLoader Instance
        {
            get { return _instance ?? (_instance = new ResourceLoader()); }
        }

    }
}