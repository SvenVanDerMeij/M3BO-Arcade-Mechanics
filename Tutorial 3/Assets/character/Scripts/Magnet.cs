using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
class Attracted : MonoBehaviour
{
    public GameObject attractedTo;
    public GameObject attractedTo2;
    public GameObject attractedTo3;
    public GameObject attractedTo4;
    public GameObject attractedTo5;
    public GameObject attractedTo6;
    public GameObject attractedTo7;
    public GameObject attractedTo8;
    public GameObject attractedTo9;
    public GameObject attractedTo10;
    public GameObject Player;
    public float DistanceObjects;
    public float DistanceObjects2;
    public float DistanceObjects3;
    public float DistanceObjects4;
    public float DistanceObjects5;
    public float DistanceObjects6;
    public float DistanceObjects7;
    public float DistanceObjects8;
    public float DistanceObjects9;
    public float DistanceObjects10;
    public float strengthOfAttraction = 5.0f;
    public float AttractRange = 6.0f;
    Rigidbody rb;


    void Start() 
    { 
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        
        if (attractedTo != null)
        {
            DistanceObjects = Vector3.Distance(attractedTo.transform.position, Player.transform.position);

            if (DistanceObjects < AttractRange)
            {
                Vector3 direction = attractedTo.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }
        }
        //Debug.Log(DistanceObjects);
        if (attractedTo2 != null)
        {
            DistanceObjects2 = Vector3.Distance(attractedTo2.transform.position, Player.transform.position);

            if (DistanceObjects2 < AttractRange)
            {
                Vector3 direction = attractedTo2.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }

        if (attractedTo3 != null)
        {
            DistanceObjects3 = Vector3.Distance(attractedTo3.transform.position, Player.transform.position);

            if (DistanceObjects3 < AttractRange)
            {
                Vector3 direction = attractedTo3.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo4 != null)
        {
            DistanceObjects4 = Vector3.Distance(attractedTo4.transform.position, Player.transform.position);

            if (DistanceObjects4 < AttractRange)
            {
                Vector3 direction = attractedTo4.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo5 != null)
        {
            DistanceObjects5 = Vector3.Distance(attractedTo5.transform.position, Player.transform.position);

            if (DistanceObjects5 < AttractRange)
            {
                Vector3 direction = attractedTo5.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo6 != null)
        {
            DistanceObjects6 = Vector3.Distance(attractedTo6.transform.position, Player.transform.position);

            if (DistanceObjects6 < AttractRange)
            {
                Vector3 direction = attractedTo6.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo7 != null)
        {
            DistanceObjects7 = Vector3.Distance(attractedTo7.transform.position, Player.transform.position);

            if (DistanceObjects7 < AttractRange)
            {
                Vector3 direction = attractedTo7.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo8 != null)
        {
            DistanceObjects8 = Vector3.Distance(attractedTo8.transform.position, Player.transform.position);

            if (DistanceObjects8 < AttractRange)
            {
                Vector3 direction = attractedTo8.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo9 != null)
        {
            DistanceObjects9 = Vector3.Distance(attractedTo9.transform.position, Player.transform.position);

            if (DistanceObjects9 < AttractRange)
            {
                Vector3 direction = attractedTo9.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
        if (attractedTo10!= null)
        {
            DistanceObjects10 = Vector3.Distance(attractedTo10.transform.position, Player.transform.position);

            if (DistanceObjects10 < AttractRange)
            {
                Vector3 direction = attractedTo10.transform.position - transform.position;
                gameObject.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);
            }

        }
    }
}