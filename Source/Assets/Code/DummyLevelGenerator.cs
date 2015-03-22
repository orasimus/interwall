using UnityEngine;

public class DummyLevelGenerator : MonoBehaviour
{
    void Awake()
    {
        if (Game.CurrentLevel != null) { return; }

        Game.SetDummyLevel(new Level
        {
            Interval = "6_seksti",
            WrongInterval1 = "1_priimi",
            WrongInterval2 = "8_oktaavi"
        });
    }
}
