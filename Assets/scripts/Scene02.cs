using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene02 : MonoBehaviour {

    public void chooseBoat()
    {
        SceneManager.LoadScene(3);

    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
}
