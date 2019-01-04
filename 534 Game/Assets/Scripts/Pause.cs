using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public bool isPaused;
    public GameObject canvas;

    private void Start()
    {
        isPaused = false;
        canvas.SetActive(false);
        
    }

    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if(isPaused == true)
        {
            Time.timeScale = 0.0f;
            canvas.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            canvas.SetActive(false);
        }


	}

    public void QuitGame ()
    {
        //Application.Quit();
        SceneManager.LoadSceneAsync(0);
        CountryStats.Population = 7000000;
        CountryStats.Healthcare = 75.00f;
        CountryStats.GDP = 1250.37f;
    }

    public void PlayGame ()
    {
        isPaused = false;
        Debug.Log("Game playing");
    }

    public void PauseGame ()
    {
        isPaused = true;
        Debug.Log("Game paused");
    }

    
}
