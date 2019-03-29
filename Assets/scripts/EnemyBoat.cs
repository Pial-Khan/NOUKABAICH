using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyBoat : MonoBehaviour {
    public float speed = 100000000f;
    public float delay;
    public float timer;
    private Rigidbody rbody;
    void Start()
    {
        timer = 0f;
        delay = 5f;
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > delay)
        {
            // transform.Translate(transform.forward * speed * Time.deltaTime);
            // rbody.AddTorque(0f, h * turnSpeed * Time.deltaTime, 0f);
            rbody.AddForce(transform.forward * speed * Time.deltaTime);
        }

    }
}
