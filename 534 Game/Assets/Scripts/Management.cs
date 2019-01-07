using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour
{

    public float timer;
    public float Level_Time;
    public SpriteRenderer backgroundRenderer;
    public Sprite[] sprites;
    public CountryStats stats;
    private bool newsUp;
    private Scene theScene;
    public bool attack;
    

    // Use this for initialization
    void Start()
    {
        timer = 0.0f;
        theScene = SceneManager.GetActiveScene();
        attack = false;
        newsUp = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Ryan is creating an animation for this.
        //This was for testing only. Add back if needed

        timer += Time.deltaTime;
        //Debug.Log(timer);

        /*if(timer >= 60.00f)
        {
            backgroundRenderer.sprite = sprites[1];
        }
        else
        {
            backgroundRenderer.sprite = sprites[0];
        }*/
        if (attack == true)
        {
            SceneManager.LoadSceneAsync("EndLevel");
        }


        
        if (timer >= Level_Time)
        {
            //Load level here.
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
