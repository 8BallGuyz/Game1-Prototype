using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float timer = 0;
    public float execute = 1;
    private bool Timercmd = false;

    public ScoreManager scoreManager;

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
        Timercmd = true;
        SceneManager.LoadScene("Main");
        Debug.Log("Restart");

        // Reset score
        ScoreManager.instance.scorecount = 0;
        ScoreManager.instance.score.text = "SCORE : " + ScoreManager.instance.scorecount;

        // Reset lives in ScoreManager and player
        ScoreManager.instance.ResetPlayerLives();  // This will reset player lives
        ScoreManager.instance.lives.text = "LIVES : " + ScoreManager.instance.player.Lives.ToString();
    }

    public void mainMenu()
    {
        Timercmd = true;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Main Menu");
    }

    public void Quit()
    {
        Timercmd = true;
        Application.Quit();
        Debug.Log("quit");
    }

    public void Update()
    {
        if (Timercmd)
        {
            timer = timer + Time.deltaTime;
            if (timer >= execute)
            {
                SceneManager.LoadScene("Main");
                Debug.Log("Scene Succesfully Loaded !");
                timer = 0;
                Timercmd = false;
            }
        }
    }
}

