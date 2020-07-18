using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartText;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PlayerController.gameStarted == false)
        {
            StartText.SetActive(false);
            PlayerController.gameStarted = true;
            UnityEngine.Debug.Log("StartScriptRun");
        }
    }

 
}
