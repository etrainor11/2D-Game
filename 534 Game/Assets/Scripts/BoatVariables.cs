using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatVariables : MonoBehaviour {

    public int people;
    public float healthAffect;
    public float GDP_Affect;
    

	// Use this for initialization
	void Start () {
		if(gameObject.name == "RefugeeSprite(Clone)")
        {
            people = Random.Range(5, 15);
            healthAffect = Random.Range(0.1f, 0.5f);
            GDP_Affect = Random.Range(-0.0025f, 0.0025f);
        }

        if (gameObject.name == "RefugeeSprite2(Clone)")
        {
            people = Random.Range(30, 70);
            healthAffect = Random.Range(0.5f, 0.9f);
            GDP_Affect = Random.Range(-0.0050f, 0.010f);
        }

    }
	
	
}
