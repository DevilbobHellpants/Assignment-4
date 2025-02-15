﻿/*
 * (Noah Trillizio)
 * (Assignment 3)
 *  For example: moves objects left and despawns them after moving to far
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Money"))
        {
            Destroy(gameObject);
        }
    }
}
