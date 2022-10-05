using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    void Awake ()
    {
        float width = GetComponent<SpriteRenderer>().size.x;
        float height = GetComponent<SpriteRenderer>().size.y;
        Transform top = transform.GetChild(0).transform;
        Transform bottom = transform.GetChild(1).transform;
        top.position = new Vector3(transform.position.x,transform.position.y + (height/2), 0);
        bottom.position = new Vector3(transform.position.x, transform.position.y - (height/2), 0);
        //GetComponent<BoxCollider2D>().offset = new Vector2.zero;
        GetComponent<BoxCollider2D>().size = new Vector2(width, height);


    }
    
}
