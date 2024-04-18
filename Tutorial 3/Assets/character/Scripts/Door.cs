using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
    
{
    [SerializeField] private int thing; // The variable to display
    public TMP_Text numText; // The TextMeshPro object to display
    
    private Renderer r;
    KeepScore keepscore;
    int playernumber;
    DoorValue doorvalue;
    int doornumber;
    int solve;
    void Start()
    {
        r = GetComponent<Renderer>();
        keepscore = GameObject.FindGameObjectWithTag("KaasKnabbel").GetComponent<KeepScore>();
        doorvalue = GameObject.FindGameObjectWithTag("HamKnabbel").GetComponent<DoorValue>();
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            if (solve == 10)
            {

                r.enabled = false;
               
                GameObject.Destroy(gameObject);

            }
        }
    }
    void Update()
    {
        //Debug.Log(solve);
        playernumber = keepscore.score;
        doornumber = doorvalue.thing;
        solve = playernumber + doornumber;
    }
   
}
