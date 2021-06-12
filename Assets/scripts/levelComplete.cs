using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public void loadNextLevel() {
        SceneManager.LoadScene(0);
    }

    private void FixedUpdate() {
        
    }

}
