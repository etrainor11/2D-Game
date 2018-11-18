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

        if(transform.position.x > 15.00f)
        {
            Debug.Log("A boat has passed far off to the right and has now been destroyed");
            Destroy(gameObject);
        }

        if (transform.position.x < -25.00f)
        {
            Debug.Log("A boat has passed far off to the left and has now been destroyed");
            Destroy(gameObject);
        }

        

    }


}
