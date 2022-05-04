using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int speed = 10;
    void Start()
    {
        this.transform.forward = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //this.GetComponent<Rigidbody>().AddRelativeForce(this.transform.forward * speed * Time.deltaTime);
            this.transform.position += this.transform.forward * speed *Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //this.GetComponent<Rigidbody>().AddRelativeForce(this.transform.back);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0,  Time.deltaTime * -5 * speed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0,  Time.deltaTime * 5 * speed, 0);
        }
    }
}
