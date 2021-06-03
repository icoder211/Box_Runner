﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision info) {
        if(info.collider.tag == "Obstacle") {
            Debug.Log("Hit Obstacle");
            FindObjectOfType<Gamemanager>().EndGame();
            movement.enabled = false;
        }

        
    }
}
