using System;
using System.Globalization;
using Foundation;
using MvvmCross.Converters;
using UIKit;

namespace Wanted.iOS.Converter
{
    public class StringToImageConverter : MvxValueConverter<string, UIImage>
    {
        protected override UIImage Convert(string value, Type poTargetType, object poParameter, CultureInfo poCulture)
        {
            var url = new NSUrl(value);
            var data = NSData.FromUrl(url);
            return UIImage.LoadFromData(data);
        }
    }
}
