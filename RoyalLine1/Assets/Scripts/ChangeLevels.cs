using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevels : MonoBehaviour
{
    // Start is called before the first frame update


    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PotOfGold"))
        {
            SceneManager.LoadScene(1);
        }
        //if (col.CompareTag("Carrot"))
        //{
            //SceneManager.LoadScene(2);
        //}
        //if (col.CompareTag("Pumpkin"))
        //{
            //SceneManager.LoadScene(3);
        //}
    }
}
