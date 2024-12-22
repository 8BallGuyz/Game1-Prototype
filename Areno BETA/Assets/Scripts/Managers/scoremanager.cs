using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public enemy_spawner spawner;
    public enemy_spawner spawner2;
    public enemy_spawner spawner3;
    public enemy_spawner spawner4;
    public enemy_spawner spawner5;
    public enemyAI enemyAI;
    public Square_AI squareAI;
    public enemy3 enemy3;

    public player_control player;

    public Text score;
    public Text lives;

    public int scorecount = 0;
    public int highscore = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Update()
    {
        EnemyHealthManager();
        EnemySpeedManager();
        RemoveLive();
    }

    void Start()
    {
        // Load the high score from PlayerPrefs
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        score.text = "SCORE : " + scorecount.ToString();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        PlayerPrefs.Save();
    }

    public void AddPoint()
    {
        scorecount = scorecount + 1;
        score.text = "SCORE : " + scorecount.ToString();

        // Check if the current score is higher than the saved high score
        if (scorecount > highscore)
        {
            highscore = scorecount;
            PlayerPrefs.SetInt("HighScore", highscore);
            PlayerPrefs.Save();
        }
    }

    public void RemoveLive()
    {
        lives.text = "LIVES : " + player.Lives.ToString();
    }

    public int GetHighScore()
    {
        return highscore;
    }

    public int GetScore()
    {
        return scorecount;
    }

    public void EnemyHealthManager()
    {
        if(scorecount > 50)
        {
            enemyAI.Lives = 3;
            squareAI.Lives = 4;
            enemy3.Lives = 2;
        }
        if (scorecount > 100)
        {
            enemyAI.Lives = 4;
            squareAI.Lives = 5;
            enemy3.Lives = 3;
        }
        else
        {
            enemyAI.Lives = 2;
            squareAI.Lives = 3;
            enemy3.Lives = 1;
        }
    }

    public void EnemySpeedManager()
    {
        if (scorecount > 5f)
        {
            enemyAI.speed = 3.1f;
            squareAI.speed = 1.6f;
            enemy3.speed = 4.1f;
        }
        if (scorecount > 10f)
        {
            enemyAI.speed = 3.2f;
            squareAI.speed = 1.7f;
            enemy3.speed = 4.2f;
        }
        if (scorecount > 15f)
        {
            enemyAI.speed = 3.3f;
            squareAI.speed = 1.8f;
            enemy3.speed = 4.3f;
        }
        if (scorecount > 20f)
        {
            enemyAI.speed = 3.4f;
            squareAI.speed = 1.9f;
            enemy3.speed = 4.4f;
        }
        if (scorecount > 30f)
        {
            enemyAI.speed = 3.5f;
            squareAI.speed = 2f;
            enemy3.speed = 4.5f;
        }
        if (scorecount > 35f)
        {
            enemyAI.speed = 3.5f;
            squareAI.speed = 2f;
            enemy3.speed = 4.5f;
        }
        if (scorecount > 40f)
        {
            enemyAI.speed = 3.6f;
            squareAI.speed = 2.1f;
            enemy3.speed = 4.6f;
        }
        if (scorecount > 45f)
        {
            enemyAI.speed = 3.7f;
            squareAI.speed = 2.2f;
            enemy3.speed = 4.7f;
        }
        if (scorecount > 50f)
        {
            enemyAI.speed = 3.8f;
            squareAI.speed = 2.3f;
            enemy3.speed = 4.8f;
        }
        if (scorecount > 55f)
        {
            enemyAI.speed = 3.9f;
            squareAI.speed = 2.4f;
            enemy3.speed = 4.9f;
        }
        if (scorecount > 60f)
        {
            enemyAI.speed = 4f;
            squareAI.speed = 2.5f;
            enemy3.speed = 5f;
        }
        else
        {
            enemyAI.speed = 3f;
            squareAI.speed = 1.5f;
            enemy3.speed = 4f;
        }

    }
}

