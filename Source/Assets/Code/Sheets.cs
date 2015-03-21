using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Sheets : MonoBehaviour
{
    void Start()
    {
        var level = Game.CurrentLevel;
        var sheets = GetComponentsInChildren<Notes>();
        var intervals = new List<string>
        {
            level.Interval, 
            level.WrongInterval1, 
            level.WrongInterval2
        };
        var resultText = FindObjectOfType<Text>();
        foreach (var image in sheets.Select(s => s.GetComponent<Image>()))
        {
            var randomInterval = intervals.GetRandom();
            intervals.Remove(randomInterval);
            image.sprite = GetSprite(randomInterval);
            var parentButton = image.transform.parent.GetComponent<Button>();
            var isCorrectAnswer = (randomInterval == level.Interval);
            AddListeners(isCorrectAnswer, parentButton, resultText);
        }
    }

    private static Sprite GetSprite(string interval)
    {
        return ResourceLocator.Sprites[interval];
    }

    private static void AddListeners(bool isCorrectAnswer, Button parentButton, Text resultText)
    {
        var result = isCorrectAnswer
            ? "<color=#00ff00ff>Correct</color>"
            : "<color=#ff0000ff>Wrong</color>";
        parentButton.onClick.AddListener(() => resultText.text = result);
        if (isCorrectAnswer)
        {
            parentButton.onClick.AddListener(Game.AddScore);
        }
    }
}
