using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using static UnityEditor.Experimental.GraphView.GraphView;
using Input = UnityEngine.Input;

public class PlayerMovement : Controller
{

    public float jumpforce;
    public int lives = 5;
    private float inputX;
    private SpriteRenderer sRenderer;
    private bool invulnerable = false;

    //private Rigidbody2D rb2D;

    public SpriteRenderer spriter1;
    public Sprite defaultSprite1;


    private Vector2 moveVel;
    private Vector2 moveInput;
    private Vector2 direction = Vector2.zero;

    public GameObject Player;
    private static readonly Vector2 vector2 = new Vector2();

    //public float speed;

    //private Vector2 relativeVelocity = vector2;

    //protected Rigidbody2D rb2d;
    protected MovingPlatform onMovingPlatform;
    //private float inputX;


    //public Transform Bomberman;

    public override void Start()
    {
        rb2d = Player.GetComponent<Rigidbody2D>();
        spriter1 = Player.GetComponent<SpriteRenderer>();
        Player = GameObject.FindWithTag("Player");

    }


    void Update()
    { /*

        float speedX = Input.GetAxis("Horizontal") * speed;
        float speedY = Input.GetAxis("Vertical") * speed;

        rb2D.velocity = new Vector2(speedX, speedY);


        if (Input.GetKey(KeyCode.RightArrow))
        {

            SetDirection(Vector2.right);


        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            SetDirection(Vector2.left);



        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {

            SetDirection(Vector2.left);
            speedY = jumpforce;


        }

        //else
        //{

            //SetDirection(Vector2.zero);

        //}
    }*/

        inputX = Input.GetAxis("Horizontal") * speed;
        Vector2 vel = rb2d.velocity;
        vel.x = inputX;
        relativeVelocity = vel;

        UpdateGrounding();
        if (onMovingPlatform != null)
        {
            vel.x += onMovingPlatform.rb2d.velocity.x;
        }

        bool inputJump = Input.GetKeyDown(KeyCode.UpArrow);
        if (inputJump && grounded)
        {
            //audioSource.PlayOneShot(jumpsound);
            vel.y = jumpforce;
            relativeVelocity.y = vel.y;
        }
        rb2d.velocity = vel;

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
