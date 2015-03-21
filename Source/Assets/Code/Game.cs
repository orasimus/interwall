using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public static Level Current { get; private set; }

    private static IEnumerator<Level> Levels { get; set; }

    public static void StartGame(IEnumerable<Level> levels)
    {
        Levels = levels.GetEnumerator();
        AdvanceLevel();
    }

    public static void AdvanceLevel()
    {
        if (Levels == null) { return; }
        if (Levels.MoveNext() && Levels.Current != null)
        {
            Play(Levels.Current);
            return;
        }
        Application.LoadLevel("End");
    }

    private static void Play(Level level)
    {
        Current = level;
        Debug.Log("Playing " + Current);
        Application.LoadLevel("Game");
    }

    public static void SetDummyLevel(Level level)
    {
        if (Current != null) { return; }
        Current = level;
    }
}
