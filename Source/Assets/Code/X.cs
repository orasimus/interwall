using UnityEngine;
using System.Collections;

public class X : MonoBehaviour
{	
	public static Level Level;

	void Start ()
	{
		Level = new Level()
		{
			Interval = "Sounds/ding",
			CorrectSheet = "A",
			WrongSheet = "C",
			WrongSheet2 = "G"
		};
	}
}
