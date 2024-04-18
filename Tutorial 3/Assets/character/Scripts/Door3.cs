using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door3 : MonoBehaviour
{
    [SerializeField] private int thing3; // The variable to display
    public TMP_Text numText3; // The TextMeshPro object to display

    private Renderer r;
    KeepScore keepscore;
    int playernumber;
    DoorValue3 doorvalue3;
    int doornumber3;
    int solve3;
    void Start()
    {
        r = GetComponent<Renderer>();
        keepscore = GameObject.FindGameObjectWithTag("KaasKnabbel").GetComponent<KeepScore>();
        doorvalue3 = GameObject.FindGameObjectWithTag("HamKnabbeltjes").GetComponent<DoorValue3>();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            if (solve3 == 10)
            {

                r.enabled = false;

                GameObject.Destroy(gameObject);

            }
        }
    }
    void Update()
    {
        Debug.Log(solve3);
        playernumber = keepscore.score;
        doornumber3 = doorvalue3.thing3;
        solve3 = playernumber + doornumber3;
    }

}

