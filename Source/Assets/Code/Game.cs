﻿using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public static Level CurrentLevel { get; private set; }
    public static int Score { get; private set; }
    public static List<string> FailedIntervals { get; set; }

    private static IEnumerator<Level> Levels { get; set; }

    public static void StartGame(IEnumerable<Level> levels)
    {
        Levels = levels.GetEnumerator();
        Score = 0;
        FailedIntervals = new List<string>();
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
        CurrentLevel = level;
        Debug.Log("Playing " + CurrentLevel);
        Application.LoadLevel("Game");
    }

    public static void AddScore()
    {
        Score += 1;
    }

    public static void AddFailedInterval(string interval)
    {
        FailedIntervals.Add(interval);
    }

    public static void SetDummyLevel(Level level)
    {
        if (CurrentLevel != null) { return; }
        CurrentLevel = level;
    }
}
