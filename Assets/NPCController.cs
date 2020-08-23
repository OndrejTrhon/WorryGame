using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject SpeechObject;
    public GameObject PopUpObject;
    public Transform PlayerObject;
    private GameObject InstantiatedSpeechObject;
    private GameObject SelfReference;
    private Transform SelfParentReference;
    static bool ColliderLock;
    private float DistanceToPlayer;
    private bool IsOnCollision = false;
    private bool BubbleInstantiated = false;
    // Start is called before the first frame update
    
    void Update()
    {
        //if (IsOnCollision == true && Input.GetKeyDown(KeyCode.Space) && BubbleInstantiated == false)
        //{
        //    Instantiate(PopUpObject, new Vector3(transform.position.x, transform.position.y + 4f, 0), Quaternion.identity);
        //    SceneController.WorryCount++;
        //    BubbleInstantiated = true;
        //}

        //if (BubbleInstantiated == true)
        //{
        //    int VarChildCount = SelfReference.transform.childCount;
        //    for (int i = 0; i < VarChildCount; i++)
        //    {
        //        var child = SelfReference.transform.GetChild(i).gameObject;
        //        if (child != null)
        //            child.SetActive(false);
        //    }
        //}
        DistanceToPlayer = Vector3.Distance(PlayerObject.position, transform.position);

        if (Input.GetKeyDown(KeyCode.E)) { Debug.Log(DistanceToPlayer); };
    }

    private void Start()
    {
        SelfReference = this.gameObject;
        SelfParentReference = this.transform;

        float firstShowTime = Random.Range(1.0f, 10f);
        Invoke("InstantiateSpeech", firstShowTime);

        float secondShowTime = Random.Range(firstShowTime + 2f, 30f);
        Invoke("InstantiateSpeech", Random.Range(0f,50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));
        Invoke("InstantiateSpeech", Random.Range(0f, 50f));

    }


    void InstantiateSpeech()
    {
      if (DistanceToPlayer < 10 && transform.childCount < 1) {

        InstantiatedSpeechObject = Instantiate(SpeechObject, new Vector3(transform.position.x, transform.position.y + 2.5f, 0), Quaternion.identity, SelfParentReference);
        InstantiatedSpeechObject.transform.SetParent(this.gameObject.transform, true);
        }
    }

}