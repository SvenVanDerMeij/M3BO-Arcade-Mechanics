using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    [SerializeField] private int worth = 0;
    private Renderer r;
    private KeepScore scoreScript;
    void Start()
    {
        r = GetComponent<Renderer>();
        scoreScript = FindObjectOfType<KeepScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.tag == "Player")
            {
                                 
                
                scoreScript.AddScore(worth);
            }
        }
    }

    void Update()
    {

    }
}

