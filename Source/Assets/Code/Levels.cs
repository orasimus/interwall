using System.Collections.Generic;
using UnityEngine;

public class Levels
{
    public static Level Current { get; private set; }

    public static void StartGame(IEnumerable<Level> levels)
    {
        foreach (var level in levels)
        {
            Play(level);
        }
    }

    private static void Play(Level level)
    {
        Current = level;
        Debug.Log("Playing " + Current);
    }

    public static void SetDummyLevel(Level level)
    {
        if (Current != null) { return; }

        Current = level;
    }
}
