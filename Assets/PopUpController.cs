using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class PopUpController : MonoBehaviour
{
    void Start()
    {
        var kontroler = FindObjectOfType<SceneController>();
       TextMeshPro m_TextComponent = GetComponentInChildren<TextMeshPro>();
        m_TextComponent.text = kontroler.Texts[Random.Range(0, kontroler.Texts.Length)];
    }


}
