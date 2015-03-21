using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnStartSetImage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var sheet1 = X.Level;
		Debug.Log (sheet1.CorrectSheet);
		var img = Resources.Load<Sprite>(sheet1.CorrectSheet);
		var imageSource = GetComponent<Image> ();
		Texture2D sheet;
		imageSource.sprite = img;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
