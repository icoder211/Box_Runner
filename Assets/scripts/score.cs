using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;
    public Transform UI;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = (UI.position.z - Player.position.z).ToString("0");
    }
}
