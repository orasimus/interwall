using UnityEngine;
using UnityEngine.UI;

public class ToggleAudio : MonoBehaviour
{
    private bool toggled = true;

    public void Toggle()
    {
        var image = GetComponent<Image>();
        var audioSources = FindObjectsOfType<AudioSource>();
        if (toggled)
        {
            image.sprite = ResourceLocator.Sprites["mutedAudio"];
            foreach (var audioSource in audioSources) { audioSource.volume = 0f; }
        }
        else
        {
            image.sprite = ResourceLocator.Sprites["audio"];
            foreach (var audioSource in audioSources) { audioSource.volume = 1f; }
        }
        toggled = !toggled;
    }
}
