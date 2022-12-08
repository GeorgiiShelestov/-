using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PassengerTransportCompany
{
    public class DateTimeToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dateTime;

            if (value != null && DateTime.TryParse(value.ToString(), out dateTime))
            {
                return dateTime.ToString("dd.MM.yyyy");
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime dateTime;

            if (value != null && DateTime.TryParse(value.ToString(), out dateTime))
            {
                return dateTime;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}
