using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    int sceneIndex = 0;
    public GameObject LevelCompleteUI;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", 1f);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
