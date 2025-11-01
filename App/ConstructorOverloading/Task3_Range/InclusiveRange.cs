using System;

namespace App.ConstructorOverloading.Task3_Range;

public class InclusiveRange
{
    public int Start { get; private set; }
    public int End { get; private set; }

    public InclusiveRange(int start, int end)
    {
        if (start > end)
            throw new ArgumentOutOfRangeException();

        Start = start;
        End = end;
    }

    public InclusiveRange(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            throw new ArgumentException("Input string cannot be null or empty");

        var parts = s.Split("..", StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2)
            throw new FormatException();

        if (!int.TryParse(parts[0].Trim(), out int start))
            throw new FormatException();

        if (!int.TryParse(parts[1].Trim(), out int end))
            throw new FormatException();

        if (start > end)
            throw new ArgumentOutOfRangeException();

        Start = start;
        End = end;
    }

    public InclusiveRange(int single)
    {
        Start = single;
        End = single;
    }
}