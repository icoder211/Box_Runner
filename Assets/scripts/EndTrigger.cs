using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gamemanager;
    void OnTriggerEnter(Collider info) {
        if(info.tag == "Player") {
            gamemanager.Level1Complete();
        }
    }
}
