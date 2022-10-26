using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxPrefab;

    public void Pop() { 
    if (boxPrefab != null) {
            Destroy(gameObject);
        }

    }
}
