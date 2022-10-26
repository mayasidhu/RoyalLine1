using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody2D rb2D;

    public GameObject bombPrefab;
    public GameObject explosionPrefab;

    public SpriteRenderer spriter;
    public Sprite defaultSprite;
    public Sprite upSprite;
    public Sprite downSprite;

    private Vector2 moveVelocity;
    private Vector2 moveInput;
    //private Vector2 direction = Vector2.zero;

    public SpriteRenderer walkSprite;


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        float speedX = Input.GetAxis("Horizontal") * speed;
        float speedY = Input.GetAxis("Vertical") * speed;

        rb2D.velocity = new Vector2(speedX, speedY);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SetDirection(Vector2.right);
            spriter.sprite = defaultSprite;
            spriter.flipX = true;
            walkSprite.flipX = false;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            SetDirection(Vector2.left);
            spriter.sprite = defaultSprite;
            spriter.flipX = false;
            walkSprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            SetDirection(Vector2.up);
            spriter.sprite = upSprite;
            spriter.flipX = false;
            walkSprite.flipX = false;

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            SetDirection(Vector2.down);
            spriter.sprite = downSprite;
            spriter.flipX = false;
            walkSprite.flipX = false;
        }
        else
        {
            SetDirection(Vector2.zero);
        }

    }

    private void SetDirection (Vector2 newDirect)
    {
        Vector2 direction = Vector2.zero;
        direction = newDirect;
    }
    

}

