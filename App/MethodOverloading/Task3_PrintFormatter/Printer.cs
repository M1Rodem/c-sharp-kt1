using System.Globalization;

namespace App.MethodOverloading.Task3_PrintFormatter;

public static class Printer
{
    public static string Print(int value)
    {
        return value.ToString();
    }

    public static string Print(double value, int decimals)
    {
        return Math.Round(value, decimals, MidpointRounding.AwayFromZero).ToString($"F{decimals}", CultureInfo.InvariantCulture);
    }

    public static string Print(params int[] values)
    {
        if (values == null || values.Length == 0)
            return "<empty>";

        return string.Join(",", values);
    }

    public static string Print<T>(IEnumerable<T> values)
    {
        if (values == null || !values.Any())
            return "<empty>";

        return string.Join(",", values);
    }
}