using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;

    public GameObject[] enemies;
    public GameObject[] spawners;

    void Start()
    {
        // Find all enemies at the start of the game
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        spawners = GameObject.FindGameObjectsWithTag("spawner");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverUI.activeSelf)
        {
            DeactivateEnemies();
            DeactivateSpawners();
        }
        else
        {
            ReactivateEnemies();
            ReactivateSpawners();
        }
    }

    // Method to deactivate all enemies
    void DeactivateEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.SetActive(false);
            }
        }
    }

    // Method to reactivate all enemies
    void ReactivateEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.SetActive(true);
            }
        }
    }

    void DeactivateSpawners()
    {
        foreach (GameObject spawner in enemies)
        {
            if (spawner != null)
            {
                spawner.SetActive(false);
            }
        }
    }

    // Method to reactivate all enemies
    void ReactivateSpawners()
    {
        foreach (GameObject spawner in spawners)
        {
            if (spawner != null)
            {
                spawner.SetActive(true);
            }
        }
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
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
}
