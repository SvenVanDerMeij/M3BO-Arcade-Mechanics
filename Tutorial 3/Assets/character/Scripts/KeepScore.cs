using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepScore : MonoBehaviour
{
    public bool badEnding = false;
    private TMP_Text scoreField;
    public int score = 0;
    private int auwiezowie;
    void Start()
    {
        scoreField = GetComponent<TMP_Text>();
        score = 0;
        scoreField.text = "" + score;
        auwiezowie = 0;
    }

    public void AddScore(int add)
    {
        score = add;
        scoreField.text = "" + score;
    }

    public void Tumor(int add) 
    {
        auwiezowie += add;

    }

    void Update()
    {
        if (auwiezowie > 0)
        {
            badEnding = true;
        }

        if (score == 10)
        {
            if (badEnding == true)
            {
                SceneManager.LoadSceneAsync(2);
            } else
            {
                SceneManager.LoadSceneAsync(3);
            }
        }
    }
}
