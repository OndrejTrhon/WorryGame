using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public GameObject DialogObject;
    static bool ColliderLock;

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (!ColliderLock) { 
         Instantiate(DialogObject, new Vector3(transform.position.x, transform.position.y+2, 0), Quaternion.identity);
        Debug.Log("Instantiated");
            LockColliderLock();
        }
    }

    void LockColliderLock()
    {
        ColliderLock = true;
        Debug.Log("Locked");
        Invoke("UnlockColliderLock", 3);
    }

    void UnlockColliderLock()
    {
        Debug.Log("Unlocked");
        ColliderLock = false;
    }
}
