using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreboardText;
    public int score;

    public static Scoreboard instance;

    private void Start()
    {
        instance= this;
    }


}
