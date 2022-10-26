using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float acceleration = 10;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        float moveLeftRight = Input.GetAxis ("Horizontal");
        float moveForwardBack = Input.GetAxis ("Vertical");
    }
}