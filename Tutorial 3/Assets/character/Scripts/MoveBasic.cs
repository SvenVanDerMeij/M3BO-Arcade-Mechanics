using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 positionUpdate = rb.velocity + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        ////  rb.position = positionUpdate;
        ////  Vector3 move = Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        ////   Debug.Log(move);
        ////rb.velocity = move;
        //rb.velocity = positionUpdate;

       
        //transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));

        Vector3 newPosistion = new Vector3(0f, 0f, Input.GetAxis("Vertical")).normalized * speed;
        rb.MovePosition(rb.position + transform.TransformDirection(newPosistion) * Time.fixedDeltaTime);

        float horizontal = Input.GetAxis("Horizontal") * rotSpeed * Time.fixedDeltaTime;
        Quaternion rotation = Quaternion.Euler(Vector3.up * horizontal);
        rb.MoveRotation(rb.rotation * rotation);
    }
}
