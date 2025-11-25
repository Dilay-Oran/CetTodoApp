using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CetTodoApp.Converters
{
    public class RedOverDue : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime dueDate = (DateTime)value;
            if (dueDate < DateTime.Now.Date)
            {
                return Colors.Red;
            }
            else
            {
                return Colors.Black;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}
