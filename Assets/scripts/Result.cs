using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

	public void restart()
    {
        SceneManager.LoadScene(4);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
