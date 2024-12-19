using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOver()
    {
        MainMenuUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
