using UnityEngine;

public class OnClickPlayInterval : MonoBehaviour
{
    public void PlayInterval()
    {
        var level = Game.CurrentLevel;
        var sound = (AudioClip)Resources.Load("Sounds/" + level.Interval);
        var audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(sound);
    }
}
