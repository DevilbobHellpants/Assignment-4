﻿/*
 * (Noah Trillizio)
 * (Assignment 3)
 *  Controls the spawning of the obstcals
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public PlayerContorller playerControllerScript;

    public bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerContorller>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        // Win Condition: 10 points
        if (score>= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;

            //Stop player running



            scoreText.text = "You Win!\n Press R to Try Again";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
