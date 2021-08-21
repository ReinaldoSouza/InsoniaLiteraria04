using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace InsoniaLiteraria04.Control
{
    public class AdmobControl : Xamarin.Forms.View
    {
        public static readonly BindableProperty AdUnitIdProperty = BindableProperty.Create(
                       nameof(AdUnitId),
                       typeof(string),
                       typeof(AdmobControl),
                       string.Empty);

        public string AdUnitId
        {
            get => (string)GetValue(AdUnitIdProperty);
            set => SetValue(AdUnitIdProperty, value);
        }
    }
}
