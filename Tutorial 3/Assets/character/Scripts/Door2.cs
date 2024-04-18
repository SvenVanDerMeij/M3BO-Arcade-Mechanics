using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door2 : MonoBehaviour
{ 
[SerializeField] private int thing2; // The variable to display
public TMP_Text numText2; // The TextMeshPro object to display

private Renderer r;
KeepScore keepscore;
int playernumber;
DoorValue2 doorvalue2;
int doornumber2;
int solve2;
void Start()
{
    r = GetComponent<Renderer>();
    keepscore = GameObject.FindGameObjectWithTag("KaasKnabbel").GetComponent<KeepScore>();
    doorvalue2 = GameObject.FindGameObjectWithTag("HamKnabbels").GetComponent<DoorValue2>();

}


private void OnTriggerEnter(Collider other)
{
    if (other.tag == "Player")
    {

        if (solve2 == 10)
        {

            r.enabled = false;

            GameObject.Destroy(gameObject);

        }
    }
}
void Update()
{
       Debug.Log(solve2);
    playernumber = keepscore.score;
    doornumber2 = doorvalue2.thing2;
    solve2 = playernumber + doornumber2;
}
   
}
