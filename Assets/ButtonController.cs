using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonController : MonoBehaviour
{
    public GameObject DialogBubbleObject;
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            Destroy(gameObject);
            Instantiate(DialogBubbleObject, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            SceneController.WorryCount++;
            Debug.Log(SceneController.WorryCount);
        }
    }
}
