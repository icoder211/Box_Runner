using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool Ended = false;
    public float RestartDelay = 1f;
    public GameObject LevelCompleteUI;

    public GameObject GameOverUI;
    public void EndGame() {
        if(Ended) return;
        Ended = true;
        Debug.Log("GAME OVER");
        Invoke("Restart", RestartDelay);

        GameOverUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Level1Complete() {
        Debug.Log("Level1 COMPLETED");
        LevelCompleteUI.SetActive(true);
    }
}
