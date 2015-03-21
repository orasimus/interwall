using UnityEngine;
using UnityEngine.UI;

public class OnStartSetImage : MonoBehaviour
{
    void Start()
    {
        var level = Game.Current;
        var image = GetComponent<Image>();
        var sprite = Resources.Load<Sprite>("Sprites/" + level.Interval);
        image.sprite = sprite;
    }
}
