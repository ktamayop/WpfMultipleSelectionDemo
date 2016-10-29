using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;

namespace MultipleSelectionDemo.Infrastructure
{
    public class SelectedItemsCollectionToIEnumerableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectedItems = (ObservableCollection<object>) value;
            return selectedItems;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}