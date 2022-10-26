using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player2Script : MonoBehaviour
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
    private Vector2 direction = Vector2.zero;

    public SpriteRenderer walkerSprite;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {

        float speedX = Input.GetAxis("Horizontal") * speed;
        float speedY = Input.GetAxis("Vertical") * speed;

        rb2D.velocity = new Vector2(speedX, speedY);

        if (Input.GetKey(KeyCode.D))
        {
            SetDirection(Vector2.right);
            spriter.sprite = defaultSprite;
            spriter.flipX = true;
            walkerSprite.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            SetDirection(Vector2.left);
            spriter.sprite = defaultSprite;
            spriter.flipX = false;
            walkerSprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            SetDirection(Vector2.up);
            spriter.sprite = upSprite;
            spriter.flipX = false;
            walkerSprite.flipX = false;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            SetDirection(Vector2.down);
            spriter.sprite = downSprite;
            spriter.flipX = false;
            walkerSprite.flipX = false;
        }
        else
        {
            SetDirection(Vector2.zero);
        }

    }

    private void SetDirection(Vector2 newDirect)
    {
        direction = newDirect;
    }


}


