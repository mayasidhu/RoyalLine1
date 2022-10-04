using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;

    private Rigidbody2D rb2D;

    public GameObject bombPrefab;
    public GameObject explosionPrefab;

    
    private Vector2 moveVel;
    private Vector2 moveInput;
    private Vector2 direction = Vector2.zero;

    public float bombFuseTime = 2;
    public SpriteRenderer walkSprite1;
    public SpriteRenderer spriter1;
    public Sprite defaultSprite1;
    public Sprite upSprite1;
    public Sprite downSprite1;

    public GameObject player1;


    //public Transform Bomberman;

    private void Start()
    {
        rb2D = player1.GetComponent<Rigidbody2D>();
        spriter1 = player1.GetComponent<SpriteRenderer>();
        player1 = GameObject.FindWithTag("Player1");

    }


    private void Update()
    {
       
        float speedX = Input.GetAxis("Horizontal") * speed;
        float speedY = Input.GetAxis("Vertical") * speed;

        rb2D.velocity = new Vector2(speedX, speedY); 

         if (Input.GetKey(KeyCode.RightShift))
        {
            //Vector3 offset = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);
            //Vector3 pos = transform.position + offset;

            StartCoroutine(bombAndExplosion());

            //GameObject explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
            //Destroy(explosion, 1);


        }
            if (Input.GetKey(KeyCode.RightArrow))
            {
            
            SetDirection(Vector2.right);
                spriter1.sprite = defaultSprite1;
                spriter1.flipX = true;
                walkSprite1.flipX = false;
            }

            else if (Input.GetKey(KeyCode.LeftArrow))
            {
            
            SetDirection(Vector2.left);
                spriter1.sprite = defaultSprite1;
                spriter1.flipX = false;
                walkSprite1.flipX = true;

            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
            
            SetDirection(Vector2.left);
                spriter1.sprite = upSprite1;
                spriter1.flipX = false;
                walkSprite1.flipX = false;

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
            
            SetDirection(Vector2.left);
                spriter1.sprite = downSprite1;
                spriter1.flipX = false;
                walkSprite1.flipX = false;

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

    //place bomb in here


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }


    //float destroyTime = 2;
    //SpriteRenderer spriteRenderer;

    private IEnumerator bombAndExplosion()
    {



        Vector2 position = transform.position;
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);

        GameObject bomb = Instantiate(bombPrefab, position, Quaternion.identity);
        Destroy(bomb, 2);

        yield return new WaitForSeconds(bombFuseTime);

        GameObject explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
        Destroy(explosion, 1);
    }

}

