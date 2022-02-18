/*
 * (Noah Trillizio)
 * (Assignment 3)
 *  moves objects left and despawns them after moving to far
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -15;

    private PlayerContorller playerContorllerScript;

    private void Start()
    {
       playerContorllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerContorller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerContorllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        
        // if we are out of bounds to the left and the gameObject is an obstacle destroy this gameObject
        if (transform.position.x < leftBound && gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
