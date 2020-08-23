using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.
    public float thrust = 4.0f;
    public Rigidbody2D rb;
    private bool gameEnd;
    public static bool gameStarted = false;
    public FinalTextScript FinalScript;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       if (gameEnd != true && gameStarted == true) {
        rb.velocity = new Vector2(0.0f, -thrust);
        }

        if (transform.position.y <= -36 && gameEnd != true) {
            rb.velocity = Vector2.zero; 
            Debug.Log("stop");
            gameEnd = true;
            FinalScript.RunEnd();
        }

        if (gameEnd == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Intro");

        }
    }


}
