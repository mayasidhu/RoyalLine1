using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    
    public float speed = 10;
    public float bombFuseTime = 2;

    //private Rigidbody2D rb2D;

    public GameObject bombPrefab;
    public GameObject explosionPrefab;
    public GameObject boxPrefab;

    public void Start()
    {
        
    }

    public void Update()
    {
        //player1
        if (Input.GetKey(KeyCode.RightShift))
        {
            StartCoroutine(bombAndExplosion());
        }
        //player2
        if (Input.GetKey(KeyCode.LeftShift))
        {
            StartCoroutine(bombAndExplosion());
        }

    }

    private IEnumerator bombAndExplosion()
    {

        Vector2 position = transform.position;
        position.x = Mathf.Round(position.x);
        position.y = Mathf.Round(position.y);

        GameObject bomb = Instantiate(bombPrefab, position, Quaternion.identity);
        Destroy(bomb, 2);
        
        yield return new WaitForSeconds(bombFuseTime);

        RaycastHit2D up = Physics2D.Raycast(position, Vector2.up, 1);
        if (up.collider != null)
        {
            if (up.collider.gameObject.tag == "boxPrefab")
            {
                Destroy(up.transform.gameObject);
            }
            if (up.collider.gameObject.tag == "Player")
            {
                ResetGame();
            }


        }

        RaycastHit2D down = Physics2D.Raycast(position, Vector2.down, 1);
        if (down.collider != null)
        {
            if (down.collider.gameObject.tag == "boxPrefab")
            {
                Destroy(down.transform.gameObject);
            }
            if(down.collider.gameObject.tag == "Player")
            {
                ResetGame();
            }


        }

        RaycastHit2D left = Physics2D.Raycast(position, Vector2.left, 1);
        if (left.collider != null)
        {
            if (left.collider.gameObject.tag == "boxPrefab")
            {
                Destroy(left.transform.gameObject);
            }
            if (left.collider.gameObject.tag == "Player")
            {
                ResetGame();
            }
        }

        RaycastHit2D right = Physics2D.Raycast(position, Vector2.right, 1);
        if (right.collider != null)
        {
            if (right.collider.gameObject.tag == "boxPrefab")
            {
                Destroy(right.transform.gameObject);
            }
            if(right.collider.gameObject.tag == "Player")
            {
                ResetGame();
            }

        }

        GameObject explosion = Instantiate(explosionPrefab, position, Quaternion.identity);
        Destroy(explosion, 1);

    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
