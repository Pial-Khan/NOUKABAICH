using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finihsing : MonoBehaviour {
    //private readonly object theCollision;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision theCollision)
    {  //Unity's built in collision function

        if (theCollision.gameObject.name == "Cube")
        {
            Application.LoadLevel(6);
        }

        //if (theCollision.gameObject.name == "Cube")
        //{
        //    Application.LoadLevel(6);
        //}
        if(theCollision.gameObject.name == "Ponkhi Raj")
        {
            Application.LoadLevel(5);
        }
    }
}
