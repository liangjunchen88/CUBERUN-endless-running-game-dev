using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        // To get the next scene in Unity File -> Build Profile's build queue.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
