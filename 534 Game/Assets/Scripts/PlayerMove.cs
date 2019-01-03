using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        Debug.Log("Game has started");
	}
	
	// Update is called once per frame
	void Update () {
		


        if(Input.GetKey(KeyCode.UpArrow) && gameObject.transform.position.y < 2.00f)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
        }

        if(Input.GetKey (KeyCode.DownArrow) && gameObject.transform.position.y > -3.00f)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }

	}
}
