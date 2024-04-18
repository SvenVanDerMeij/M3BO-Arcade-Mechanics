using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour

{
    Rigidbody rb;
    public float force = 50f;
    public bool onFloor = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onFloor = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {

            rb.AddForce(Vector3.up * force);
        }
    }
}
