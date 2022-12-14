using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public static int totalReward = 0;
    public GameObject door1;
    public GameObject door2;
    


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
            
            //destroy reward from scene
            //if (col.CompareTag("reward")) { 
            totalReward++;
            Debug.Log("You have " + Reward.totalReward + "points");
            Destroy(gameObject);
            if (col.CompareTag("Door"))
            {
                totalReward--;

            }
            //Instantiate(door1);
            //Instantiate(door2);
            //}
        }
    }
    private void Update ()
    {
        if (totalReward == 5)
        {
            Destroy(door1);
            Destroy(door2);
            totalReward = 0;
        }
    }
}
