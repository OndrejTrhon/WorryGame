using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSkip : MonoBehaviour
{

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("SampleScene");
        }        
    }
}
