using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausee : MonoBehaviour {

	public void pauseMenu()
    {
        Time.timeScale = 0.0f;
    }

    public void resumeMenu()
    {
        Time.timeScale = 1f;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(1);
    }
}
