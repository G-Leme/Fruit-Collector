using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private GameObject fruitSpawner;

    

    public float countdown;
    public float timer;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        countdown = countdown - Time.deltaTime;
        countdownText.text = (countdown.ToString("0"));
        
        if(countdown <= 0.5 )
        {
            countdownText.text = ("GO");
            Destroy(countdownText, 1);
        }
              
            if (timer >= 0 && countdown <= 0)
                timer = timer - Time.deltaTime;

            timerText.text = (("TIME:" ) + timer.ToString("0"));

        if(timer <= 1)
        {
            fruitSpawner.SetActive(false);
        }
        
    }

}
