using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour {

    [Tooltip("The object we want to instantiate")]
    public GameObject obj;
    [Space(10)]
    [Tooltip("The time between spawns")]
    public float spawnTime;
    [Tooltip("The current time")]
    public float time;

    private Vector2 spawnPoint;
    private Transform spawnTrans;
    private BoxCollider2D box;
    private Vector2 boxBound1, boxBound2;

    private void Start()
    {
        box = GetComponent<BoxCollider2D>();
        boxBound1 = box.bounds.min;
        boxBound2 = box.bounds.max;

        
    }

    // Update is called once per frame
    void Update () {

        //Increase the time as the game plays
        time += Time.deltaTime;

        

        //Spawn ship when time passes the spawn time and reset the time to 0
        if (time >= spawnTime)
        {
            time = 0.0f;
            //Debug.Log("Time is now past spawn time");
            randomSpawnPoint();
            Instantiate(obj, spawnPoint, Quaternion.identity);
            
        }
	}

    void randomSpawnPoint ()
    {
        //randomise a X and Y positon based on the edge of the spawner box
        float randomX, randomY;
        randomX = Random.Range(boxBound1.x, boxBound2.x);
        randomY = Random.Range(boxBound1.y, boxBound2.y);

        spawnPoint.x = randomX;
        spawnPoint.y = randomY;
        //Debug.Log(spawnPoint);
        
    }

}
