using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Game.AdvanceLevel();
        }
    }
}
