// <copyright file="CameraController.cs" company="DIS Copenhagen">
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public LayerMask obstacleLayerMask;

    public float distance = 10;
    public float minPitch = -80;
    public float maxPitch = 80;

    public float rotationSpeed = 300;

    private float pitch;
    private float yaw;

    void Start()
    {
        pitch = 45;
        yaw = 0;
    }

    void Update()
    {
        
    }

}
