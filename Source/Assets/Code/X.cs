using UnityEngine;
using System.Collections;

public class X : MonoBehaviour
{
    public static Level Level
    {
        get
        {
            return new Level()
            {
                Interval = "Sounds/ding",
                CorrectSheet = "Sprites/C",
                WrongSheet = "A",
                WrongSheet2 = "G"
            };
        }
    }

	void Start ()
	{
	}
}
