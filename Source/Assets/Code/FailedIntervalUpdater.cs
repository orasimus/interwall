using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class FailedIntervalUpdater : MonoBehaviour
{
    const string Message = "Practice the following intervals: {0}";

    void Start()
    {
        var text = GetComponent<Text>();
        var failedIntervals = Game.FailedIntervals
            .GroupBy(i => i)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key)
            .Select(g => g.First())
            .ToArray();
        text.text = string.Format(Message, string.Join(", ", failedIntervals));
    }
}
