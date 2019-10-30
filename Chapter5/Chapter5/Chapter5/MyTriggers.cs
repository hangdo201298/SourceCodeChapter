using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Chapter5
{
    class IsEmptyStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            return ((int)value > 0) ? true : false;
        }
        public object ConvertBack(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
    public class EntryTextLogger : TriggerAction<Entry>
    {
        public EntryTextLogger() { }
        protected override void Invoke(Entry entry)
        {
            Console.WriteLine(entry.Text);
        }
    }
}
