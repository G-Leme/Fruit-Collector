using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private string[] fruitID;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private float timeBetweenFruits;
    private float timeStamp = 0f;

    private void Start()
    {
     
    }

    void FixedUpdate()
    {
        

        if ((Time.time >= timeStamp))
        {
            FruitPooler.instance.SpawnFromPool(fruitID[Random.Range(0, fruitID.Length)], spawnPoint[Random.Range(0, spawnPoint.Length)].position, Quaternion.identity);

            timeStamp = Time.time + timeBetweenFruits;
        }
    }

   


}
