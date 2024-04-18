using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lungcancer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private ChangePostProcessing raaf;
    private KeepScore kraai;
    private Renderer r;
   
    void Start()
    {
        r = GetComponent<Renderer>();
        kraai = FindObjectOfType<KeepScore>();
        raaf = FindObjectOfType<ChangePostProcessing>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.tag == "Player")
            {
                r.enabled = false;
                GameObject.Destroy(gameObject);
                kraai.Tumor(1);
                raaf.Sigaret(32f);
                source.PlayOneShot(clip);
            }
        }
    }

    void Update()
    {
        
    }
}

