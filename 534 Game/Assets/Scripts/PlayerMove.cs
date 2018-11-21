using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


        if(Input.GetKey(KeyCode.UpArrow) && transform.position.y < 5.00f)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if(Input.GetKey (KeyCode.DownArrow) && transform.position.y > -5.00f)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }

	}
}
