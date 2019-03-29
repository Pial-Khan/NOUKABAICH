using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause2 : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (SceneManager.LoadScene(2))
        //{
        //    if (GameIsPaused)
        //    {
        //        Resume();
        //    }
        //    else
        //    {
        //        Pause();
        //    }
        //}
		
	}

    void Resume()
    {

        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
}
