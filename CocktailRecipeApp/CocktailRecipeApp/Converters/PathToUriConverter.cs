using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace CocktailRecipeApp.Converters
{
    public class PathToUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string path && !string.IsNullOrWhiteSpace(path))
            {
                try
                {
                    Uri imageUri;

                    // Check if the path is an absolute URI (for external images)
                    if (Uri.TryCreate(path, UriKind.Absolute, out imageUri) &&
                        (imageUri.Scheme == Uri.UriSchemeHttp || imageUri.Scheme == Uri.UriSchemeHttps))
                    {
                        // External image URL (HTTP/HTTPS)
                        return new BitmapImage(imageUri);
                    }
                    else if (System.IO.File.Exists(path))
                    {
                        // Local file path (external images stored on user's computer)
                        return new BitmapImage(new Uri(path));
                    }
                    else
                    {
                        // Internal image (local project resources)
                        return new BitmapImage(new Uri($"pack://application:,,,/{path}"));
                    }
                }
                catch
                {
                    // Return a placeholder or null if the path is invalid
                    return null;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
