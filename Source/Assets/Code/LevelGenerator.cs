using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public const int Levels = 8;

    private readonly List<string> intervals = new List<string>
    {
        "1_priimi", "2_sekunti", "3_terssi", "4_kvartti",
        "5_kvintti", "6_seksti", "7_septimi", "8_oktaavi"
    };

    void Start()
    {
        var levels = GenerateLevels(Levels);
        Game.StartGame(levels);
    }

    private IEnumerable<Level> GenerateLevels(int tests)
    {
        var last = string.Empty;
        var secondLast = string.Empty;
        for (var _ = 0; _ < tests; _++)
        {
            var randomInterval = intervals
                .Where(i => i != last && i != secondLast)
                .ToList()
                .GetRandom();
            var randomWrongInterval1 = intervals
                .Where(i => i != randomInterval)
                .ToList()
                .GetRandom();
            var randomWrongInterval2 = intervals
                .Where(i => i != randomInterval && i != randomWrongInterval1)
                .ToList()
                .GetRandom();
            var level = new Level
            {
                Interval = randomInterval,
                WrongInterval1 = randomWrongInterval1,
                WrongInterval2 = randomWrongInterval2
            };
            yield return level;
            secondLast = last;
            last = randomInterval;
        }
    }
}
