using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;


namespace HotDogs.Mobile.Converters
{
    public class Base64ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string base64Image = value as string;

            if (base64Image == null)
                return null;

            var imageBytes = System.Convert.FromBase64String(base64Image);

            return ImageSource.FromStream(() => { return new MemoryStream(imageBytes); });
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
