﻿using System.Collections.Generic;
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
        foreach (var image in sheets.Select(s => s.GetComponent<Image>()))
        {
            var randomInterval = intervals.GetRandom();
            intervals.Remove(randomInterval);
            image.sprite = GetSprite(randomInterval);
        }
    }

    private Sprite GetSprite(string interval)
    {
        return Resources.Load<Sprite>("Sprites/" + interval);
    }
}
