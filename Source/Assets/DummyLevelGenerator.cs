using System.Collections;
using UnityEngine;

public class DummyLevelGenerator : MonoBehaviour
{
    void Start()
    {
        if (Levels.Current != null) { return; }

        Levels.SetDummyLevel(new Level
        {
            Interval = "6_seksti",
            WrongInterval1 = "1_priimi",
            WrongInterval2 = "8_oktaavi"
        });
    }
}
