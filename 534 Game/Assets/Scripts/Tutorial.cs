using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tutorial : MonoBehaviour {

    public TimeManager timeManagerScript;
    public Pause pauseScript;
    public AudioSource audioSource;
    public GameObject[] TutObj;


	// Use this for initialization
	void Start () {
        timeManagerScript.enabled = false;
        pauseScript.enabled = false;
        Time.timeScale = 0.0f;
        audioSource.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Begin ()
    {
        timeManagerScript.enabled = true;
        pauseScript.enabled = true;
        audioSource.enabled = true;
        /*Destroy(TutObj[0]);
        Destroy(TutObj[1]);
        Destroy(TutObj[2]);*/

        foreach (GameObject obj in TutObj)
        {
            Destroy(obj);
        }
    }
}
