using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter5
{
    public static class MyBehavior
    {
        public static readonly BindableProperty PropertyNameProperty =
        BindableProperty.CreateAttached("PropertyName", typeof(bool), typeof(MyBehavior), false, propertyChanged: OnPropertyNameChanged);
        public static bool GetPropertyName(BindableObject view)
        {
            return (bool)view.GetValue(PropertyNameProperty);
        }
        public static void SetPropertyName(BindableObject view, bool value)
        {
            view.SetValue(PropertyNameProperty, value);
        }
        static void OnPropertyNameChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry;
            if (entry == null)
            {
                return;
            }
            /* Validate Entry */
        }
    }
}
