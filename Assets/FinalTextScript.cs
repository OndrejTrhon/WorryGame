﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTextScript : MonoBehaviour
{

    public GameObject TextPart1;
    public GameObject TextPart2;
    public GameObject TextPart3;
    public GameObject TextPart4;
    public SetScore scoreObj;


    public void Start()
    {
        TextPart1.gameObject.SetActive(false);
        TextPart2.gameObject.SetActive(false);
        TextPart3.gameObject.SetActive(false);
        TextPart4.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void RunEnd()
    {
        scoreObj.SetScoreRun();
        StartCoroutine(ShowText(TextPart1, 1));
        StartCoroutine(ShowText(TextPart2, 2));
        StartCoroutine(ShowText(TextPart3, 3));
        StartCoroutine(ShowText(TextPart4, 5));


    }

    IEnumerator ShowText(GameObject setObject, float time)
    {
        yield return new WaitForSeconds(time);
        setObject.SetActive(true);
    }
}
