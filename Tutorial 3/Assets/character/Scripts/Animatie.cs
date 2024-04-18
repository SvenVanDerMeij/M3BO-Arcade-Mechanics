using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animatie : MonoBehaviour

{
    
    
    public bool onFloor = false;

    // Start is called before the first frame update
    private Animator animate;
    void Start()
    {
        animate = GetComponent<Animator>();
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
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("vertical"));
        //Check voor verticale input
        if (Input.GetAxis("Vertical") > 0)
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
            //Roep de juiste trigger aan!
            animate.SetTrigger("Walk");
            //SetTrigger is trigger activeren
            animate.ResetTrigger("Idle");
            animate.ResetTrigger("WalkR");
            //ResetTrigger is Trigger de-activeren
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            animate.SetTrigger("WalkR");
            animate.ResetTrigger("Idle");
            animate.ResetTrigger("Walk");
        }
        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            animate.SetTrigger("Idle");
            animate.ResetTrigger("Walk");
            animate.ResetTrigger("WalkR");
        }
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {

            animate.SetTrigger("Jump");
        }
    }
}
