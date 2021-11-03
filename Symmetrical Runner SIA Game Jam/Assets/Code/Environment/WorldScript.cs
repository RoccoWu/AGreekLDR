using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScript : MonoBehaviour
{
    public float speed;
    public float acceleration;

    public GameManager gameManager;

    public float maxSpeed;
    void Start()
    {
        maxSpeed = 2.0f;
        acceleration = 1.0f;

        // starts out slowly, then gets faster from a speed of 0-3.
        speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime
    }
}
