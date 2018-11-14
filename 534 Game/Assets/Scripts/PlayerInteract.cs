using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public float length;
    private BoatsMove BoatsMoveScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
	}

     void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, length, 1);

        if(hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
            BoatsMoveScript = hit.collider.gameObject.GetComponent<BoatsMove>();
            Debug.Log("Press Spacebar");

            if(Input.GetKeyDown(KeyCode.Space))
            {
                BoatsMoveScript.entering = false;
                BoatsMoveScript = null;
            }
        }
        


        Debug.DrawRay(transform.position, Vector2.left * length, Color.black);
    }
}
