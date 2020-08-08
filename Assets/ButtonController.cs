using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonController : MonoBehaviour
{
    public GameObject DialogBubbleObject;
    private GameObject SelfReference;
    private bool IsOnCollision = false;
    private bool BubbleInstantiated = false;

    private void Start()
    {
        SelfReference = this.gameObject;

    }

    void Update()
    {
        if (IsOnCollision == true && Input.GetKeyDown(KeyCode.Space) && BubbleInstantiated == false)
        {
            Instantiate(DialogBubbleObject, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity);
            SceneController.WorryCount++;
            BubbleInstantiated = true;
        }

       
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        IsOnCollision = true;
        SceneController.TotalWorryCount++;
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        IsOnCollision = false;
    }
}
