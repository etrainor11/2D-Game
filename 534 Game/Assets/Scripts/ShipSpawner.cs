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

    private Transform trans;
	// Update is called once per frame
	void Update () {

        //Increase the time as the game plays
        time += Time.deltaTime;

        //Spawn ship when time passes the spawn time and reset the time to 0
        if (time >= spawnTime)
        {
            time = 0.0f;
            //Debug.Log("Time is now past spawn time");
            Instantiate(obj, transform.position, transform.rotation);
        }
	}

    

}
