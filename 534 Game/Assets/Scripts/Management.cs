using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour {

    public float timer;
    public SpriteRenderer backgroundRenderer;
    public Sprite[] sprites;

	// Use this for initialization
	void Start () {
        timer = 0.0f;
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Debug.Log(timer);

        if(timer >= 60.00f)
        {
            backgroundRenderer.sprite = sprites[1];
        }
        else
        {
            backgroundRenderer.sprite = sprites[0];
        }

        if(timer >= 120.00f)
        {
            //Load level here.
        }
	}
}
