using System;
using System.Diagnostics;
using Windows.UI.Xaml;

namespace Kelly.App.UserControls
{
    public class DoubleToStarConverter : Windows.UI.Xaml.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                double val = (double)value;
                return new GridLength(val, GridUnitType.Star);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return new GridLength(0.0001, GridUnitType.Star);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
