using UnityEngine;
using System.Collections;

public class OnClickPlayInterval : MonoBehaviour {

	public void PlayInterval()
	{
		var level = X.Level;
		Debug.Log (level.Interval);
		var sound = (AudioClip)Resources.Load (level.Interval);
		var audioSource = FindObjectOfType<AudioSource> ();
		audioSource.PlayOneShot (sound);


	}
}
