using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorValue3 : MonoBehaviour
{
    [SerializeField] TMP_Text DoorWorth3;
    [SerializeField] public int thing3; // The variable to display
    public TMP_Text numText3; // The TextMeshPro object to display
                              // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoorWorth3.text = thing3.ToString();
    }
}

