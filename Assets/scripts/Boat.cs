using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boat : MonoBehaviour {
    public float turnSpeed = 1000f;
    public float aceSpeed = 1000f;
    private Rigidbody rbody;
    public float delay;
    public float timer;

    void Start()
    {
        timer = 0f;
        delay = 5f;
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        //Increase the value of 'timer' by deltaTime:

        timer += Time.deltaTime;

        //Verify if the timer is greater than delay:
        if (timer > delay)
        {
            
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                int devX = Screen.width;
                int devY = Screen.height;
                int x = (int)touch.position.x;
                int y = (int)touch.position.y;
                //Debug.Log("devx = " + devX + " devY = " + devY + " x= " + x + " y= " + y);
                if (x > devX / 2)
                {
                    rbody.AddTorque(0f, .50f * turnSpeed * Time.deltaTime, 0f);
                    rbody.AddForce(transform.forward * aceSpeed * Time.deltaTime);
                   // rbody.AddForce(transform.right * aceSpeed * Time.deltaTime);
                }
                else
                {
                    rbody.AddTorque(0f, -.50f * turnSpeed * Time.deltaTime, 0f);
                    rbody.AddForce(transform.forward * 1 * aceSpeed * Time.deltaTime);

                    //rbody.AddForce(-transform.right * 1 * aceSpeed * Time.deltaTime);
                }

            }
        }


    }
}
