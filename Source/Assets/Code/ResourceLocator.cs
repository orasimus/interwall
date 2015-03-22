using System.Collections.Generic;
using UnityEngine;

public class ResourceLocator : MonoBehaviour
{
    public Sprite Priimi;
    public Sprite Sekunti;
    public Sprite Terssi;
    public Sprite Kvartti;
    public Sprite Kvintti;
    public Sprite Seksti;
    public Sprite Septimi;
    public Sprite Oktaavi;
    public Sprite Audio;
    public Sprite MutedAudio;

    public static Dictionary<string, Sprite> Sprites;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Sprites = new Dictionary<string, Sprite>
        {
            { "1_priimi", Priimi },
            { "2_sekunti", Sekunti },
            { "3_terssi", Terssi },
            { "4_kvartti", Kvartti },
            { "5_kvintti", Kvintti },
            { "6_seksti", Seksti },
            { "7_septimi", Septimi },
            { "8_oktaavi", Oktaavi },
            { "audio", Audio },
            { "mutedAudio", MutedAudio }
        };
    }
}
