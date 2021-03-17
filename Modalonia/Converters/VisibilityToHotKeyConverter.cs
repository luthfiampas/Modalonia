using System;
using System.Globalization;
using Avalonia.Data.Converters;
using Avalonia.Input;

namespace Modalonia.Converters
{
    internal class VisibilityToHotKeyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? KeyGesture.Parse((string) parameter) : null;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
