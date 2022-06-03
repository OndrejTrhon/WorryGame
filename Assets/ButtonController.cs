using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ButtonController : MonoBehaviour
{
    public GameObject DialogBubbleObject;
    public Transform NPC;
    private GameObject SelfReference;
    private bool IsOnCollision = false;
    private bool BubbleInstantiated = false;

    private void Start()
    {
        SelfReference = this.gameObject;
        NPC = transform.parent;

    }

    void Update()
    {
        if (IsOnCollision == true && Input.GetKeyDown(KeyCode.Space) && BubbleInstantiated == false)
        {
            Instantiate(DialogBubbleObject, new Vector3(transform.position.x, transform.position.y + 1f, 0), Quaternion.identity, NPC);
            SceneController.WorryCount = SceneController.TotalWorryCount - 1;
            Debug.Log(SceneController.WorryCount);
            this.gameObject.SetActive(false);
            BubbleInstantiated = true;
        }

       
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        IsOnCollision = true;
        SceneController.TotalWorryCount= SceneController.TotalWorryCount +1;
        Debug.Log(SceneController.WorryCount);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        IsOnCollision = false;
    }
}
