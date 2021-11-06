using System;
using System.Globalization;
using System.Windows.Data;

namespace Video.Subtitles
{
    public class TestConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return double.TryParse(value.ToString(), out double doubleValue) &&
                double.TryParse(parameter.ToString(), out double doubleParameter) &&
                (int)doubleValue > (int)doubleParameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
