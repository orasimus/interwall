using UnityEngine;
using System.Collections;

public class OnClickPlayInterval : MonoBehaviour {

	public AudioClip interval;

	public void PlayInterval()
	{
		var audioSource = FindObjectOfType<AudioSource> ();
		audioSource.PlayOneShot (interval);
	}
}
