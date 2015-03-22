using UnityEngine;
using UnityEngine.UI;

public class ToggleAudio : MonoBehaviour
{
    private bool toggled = true;

    public void Toggle()
    {
        var image = GetComponent<Image>();
        var audioSource = FindObjectOfType<AudioSource>();
        if (toggled)
        {
            image.sprite = ResourceLocator.Sprites["mutedAudio"];
            audioSource.volume = 0f;
        }
        else
        {
            image.sprite = ResourceLocator.Sprites["audio"];
            audioSource.volume = 1f;
        }
        toggled = !toggled;
    }
}
