using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    private const string Message = "Your Score: {0} / {1}";

    void Start()
    {
        var text = GetComponent<Text>();
        text.text = string.Format(Message, Game.Score, LevelGenerator.Levels);
    }
}
