/*
 * (Noah Trillizio)
 * (Assignment 3)
 *  Adds to the players score when something this is attached to interacts with the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uiManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uiManager.score++;
        }
    }
}