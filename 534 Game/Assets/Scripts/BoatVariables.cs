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
            people = Random.Range(25, 75);
            healthAffect = Random.Range(-0.005f, 0.005f);
            GDP_Affect = Random.Range(-0.0025f, 0.0025f);
        }

        if (gameObject.name == "RefugeeSprite2(Clone)")
        {
            people = Random.Range(80, 200);
            healthAffect = Random.Range(-0.010f, 0.015f);
            GDP_Affect = Random.Range(-0.0050f, 0.010f);
        }

    }
	
	
}
