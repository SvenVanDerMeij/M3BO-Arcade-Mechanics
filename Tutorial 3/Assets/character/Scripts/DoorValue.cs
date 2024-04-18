using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorValue : MonoBehaviour
{
    
    [SerializeField] TMP_Text DoorWorth;
    [SerializeField] public int thing; // The variable to display
    public TMP_Text numText; // The TextMeshPro object to display
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoorWorth.text = thing.ToString();
    }
}
