using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public static int totalReward = 0;

    private void Awake()
    {
        //the collider becomes a trigger
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
       if (col.CompareTag("Player"))
        {
            //adds rewards to total, once collided
            totalReward++;
            Debug.Log("You have " + Reward.totalReward + "points");
            //destroy reward from scene
            Destroy(gameObject);
        }
    }
}
