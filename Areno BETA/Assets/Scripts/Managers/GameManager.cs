using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        // Ensure only one instance of the GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Dead()
    {
        SceneManager.LoadScene("GameOver");
        Debug.Log("SceneSwitch");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Restart");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
