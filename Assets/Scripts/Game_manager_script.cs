using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager_script : MonoBehaviour
{

    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("Quit", 5f);
    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER!");
            gameHasEnded = true;

            // Restart Game
            Invoke("Restart", 2f);
        }
    }


    public void Quit()
    {

        Debug.Log("i cannot use application.quit in unity so u can see this message");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
