using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorValue2 : MonoBehaviour
{ 
 [SerializeField] TMP_Text DoorWorth2;
[SerializeField] public int thing2; // The variable to display
public TMP_Text numText2; // The TextMeshPro object to display
                         // Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    DoorWorth2.text = thing2.ToString();
}
}
