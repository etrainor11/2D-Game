using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatsMove : MonoBehaviour {

    public float speed;
    public bool entering;

	// Use this for initialization
	void Start () {
        entering = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (entering)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (!entering)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        

	}
}
