using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.

 
    void Start()
    {
        
    
    }

    void FixedUpdate()
    {
        if (Input.GetKey("up")) { transform.Translate(0, speed, 0); }
        if (Input.GetKey("down")) { transform.Translate(0, -speed, 0); }
        if (Input.GetKey("left")) { transform.Translate(-speed, 0, 0); }
        if (Input.GetKey("right")) { transform.Translate(speed, 0, 0); }
    }


}
