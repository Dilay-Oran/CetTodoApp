using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Globalization;
using Microsoft.Maui;

namespace CetTodoApp.Converters
{
    public class StrikeThrough : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if (value is bool isComplete)
            {
                if (isComplete)
                {
                    return TextDecorations.Strikethrough;
                }
                else
                {
                    return TextDecorations.None;
                }
            }
            return TextDecorations.None;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
    
