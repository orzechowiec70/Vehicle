using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float speed=20.0f;
    private float turnSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey("down")){
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey("left")){
            transform.Rotate(Vector3.down, Time.deltaTime * turnSpeed);
        }
        if (Input.GetKey("right")){
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
        }
    }
}
