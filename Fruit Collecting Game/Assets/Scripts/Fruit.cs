using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;


    private void Start()
    {
       
    }

    private void OnEnable()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0;
        StartCoroutine(DisableFruit());
    }

    private void OnDisable()
    {
        StopCoroutine(DisableFruit());
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<Player>(out Player playerComponent))
        {
            if (playerComponent != null)
            {
                Scoreboard.instance.score += 50;
                Scoreboard.instance.scoreboardText.text = ("SCORE: " + Scoreboard.instance.score.ToString());
                gameObject.SetActive(false);
            }

            else
                return;

        }
    }

    IEnumerator DisableFruit()
    {
        yield return new WaitForSeconds(3.0f);
        gameObject.SetActive(false);
    }

   
}
