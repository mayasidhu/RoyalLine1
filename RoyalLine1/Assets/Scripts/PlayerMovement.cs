using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody2D rb2D;

    public GameObject cookie;

    //private Rigidbody2D spriter1;


    private Vector2 moveVel;
    private Vector2 moveInput;
    private Vector2 direction = Vector2.zero;

    public GameObject Player;


    //public Transform Bomberman;

    private void Start()
    {
        rb2D = Player.GetComponent<Rigidbody2D>();
        //spriter1 = Player.GetComponent<SpriteRenderer>();
        Player = GameObject.FindWithTag("Player");

    }


    private void Update()
    {

        float speedX = Input.GetAxis("Horizontal") * speed;
        float speedY = Input.GetAxis("Vertical") * speed;

        rb2D.velocity = new Vector2(speedX, speedY);




    }

    private void SetDirection(Vector2 newDirect)
    {
        direction = newDirect;
    }

    //place bomb in here


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}


//float destroyTime = 2;
//SpriteRenderer spriteRenderer;



