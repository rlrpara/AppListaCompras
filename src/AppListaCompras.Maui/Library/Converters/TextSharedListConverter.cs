using System.Globalization;

namespace AppListaCompras.Maui.Library.Converters;

public class TextSharedListConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        int? quantidadeUsuarios = (int?)value;

        if (!quantidadeUsuarios.HasValue)
            return null;

        return quantidadeUsuarios > 1 ? "(lista compartilhada)" : string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
