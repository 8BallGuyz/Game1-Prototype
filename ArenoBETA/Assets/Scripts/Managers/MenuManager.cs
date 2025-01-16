using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuUI;

    public float timer = 0;
    public float execute = 1;
    private bool Timercmd = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOver()
    {
        MainMenuUI.SetActive(true);
    }

    public void Restart()
    {
        Timercmd = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart");
    }

    public void mainMenu()
    {
        Timercmd = true;
        SceneManager.LoadScene("MainMenu");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        Debug.Log("Main Menu Clicked");
    }

    public void Quit()
    {
        Timercmd = true;
        Application.Quit();
        Debug.Log("quit");
    }

    public void StartGame()
    {
        Timercmd = true;
        Debug.Log("Timer Started");
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
