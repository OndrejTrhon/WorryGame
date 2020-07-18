using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{

    public void SetScoreRun() {
        var tmp = GetComponent<TextMeshPro>();
        tmp.text = SceneController.WorryCount.ToString();
    }
}
