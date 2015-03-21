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
                CorrectSheet = "A",
                WrongSheet = "C",
                WrongSheet2 = "G"
            };
        }
    }

	void Start ()
	{
	}
}
