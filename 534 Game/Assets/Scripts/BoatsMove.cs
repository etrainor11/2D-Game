using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatsMove : MonoBehaviour {

    [Tooltip("the speed at which the boat can move")]
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
        
        //Destroy the boat after it leaves the screen on the left
        if(transform.position.x <= -20.0f)
        { 
            Destroy(gameObject);
        }

        //Destroy the boat after it leaves the screen on the right
        if(transform.position.x <= 10.0f)
        {
            //NOTE: remember to add the variables of the boat to the country before destroying the object
            Destroy(gameObject);
        }

	}

    
}
