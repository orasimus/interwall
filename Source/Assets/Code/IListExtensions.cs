using System;
using System.Collections.Generic;

public static class IListExtensions
{
    private static readonly Random random = new Random();

    public static T GetRandom<T>(this IList<T> source)
    {
        var index = random.Next(source.Count);
        return source[index];
    }
}
