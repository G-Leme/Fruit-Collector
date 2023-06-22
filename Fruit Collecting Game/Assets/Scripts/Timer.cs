using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;

    private float delay;

    public float timer;
    void Start()
    {
        delay = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      

        if (delay >= 0)
        {
            delay = delay -= Time.deltaTime;
        }

        if (delay <= 0)
        {
            if (timer >= 0)
                timer = timer -= Time.deltaTime;

            timerText.text = (("TIME:" ) + timer.ToString("0"));
        }
    }

    IEnumerator EnableScoreUI()
    {
        yield return new WaitForSeconds(2f);
     

    }
}
