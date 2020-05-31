using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject SpeechObject;
    public GameObject PopUpObject;
    private GameObject InstantiatedSpeechObject;
    private GameObject SelfReference;
    static bool ColliderLock;
    private bool IsOnCollision = false;
    private bool BubbleInstantiated = false;
    // Start is called before the first frame update
    
    void Update()
    {
        if (IsOnCollision == true && Input.GetKeyDown(KeyCode.Space) && BubbleInstantiated == false)
        {
            Instantiate(PopUpObject, new Vector3(transform.position.x, transform.position.y + 3f, 0), Quaternion.identity);
            SceneController.WorryCount++;
            BubbleInstantiated = true;
        }

        if (BubbleInstantiated == true)
        {
            int VarChildCount = SelfReference.transform.childCount;
            for (int i = 0; i < VarChildCount; i++)
            {
                var child = SelfReference.transform.GetChild(i).gameObject;
                if (child != null)
                    child.SetActive(false);
            }
        }
    }

    private void Start()
    {
        SelfReference = this.gameObject;
        Invoke("InstantiateSpeech", Random.Range(1.0f, 10f));
        Invoke("InstantiateSpeech", Random.Range(1.0f, 10f));
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        IsOnCollision = true;
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        IsOnCollision = false;
    }

    void InstantiateSpeech()
    {
        InstantiatedSpeechObject = Instantiate(SpeechObject, new Vector3(transform.position.x, transform.position.y + 2, 0), Quaternion.identity);
        InstantiatedSpeechObject.transform.SetParent(this.gameObject.transform, true);
    }

}