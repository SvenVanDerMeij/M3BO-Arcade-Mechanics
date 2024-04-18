using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class ChangePostProcessing : MonoBehaviour
{
    [SerializeField] private PostProcessVolume ding;
    public float nicotine = 0f;
    void Start()
    {
       nicotine = 0f;
    }

    public void Sigaret(float add)
    {
        nicotine += add;
        if (ding.profile.TryGetSettings(out DepthOfField blurr))
        {
            
            
                Debug.Log("hallo");
                blurr.aperture.value = add;
            
        }
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.U))
        // {

        if (ding.profile.TryGetSettings(out DepthOfField blurr))
        {
            if (blurr.aperture > 0.0f)
            {
                //Debug.Log("hallo");
                blurr.aperture.value -= 0.001f;
            }
        }
      //  }
    }


}
