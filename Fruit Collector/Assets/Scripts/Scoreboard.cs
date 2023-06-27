using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI scoreboardText;
    public TextMeshProUGUI finalScoreText;
    public int score;
    public int finalScore;

    public static Scoreboard instance;

    private void Start()
    {
        instance= this;
    }


    private void Update()
    {
        finalScore = score;

        finalScoreText.text = ("SCORE: " + finalScore.ToString());
    }
}
