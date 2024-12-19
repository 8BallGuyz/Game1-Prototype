using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text score;
    private int scorecount = 0;
    public int highscore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Load the high score from PlayerPrefs
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        score.text = "SCORE : " + scorecount.ToString();
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

    public int GetHighScore()
    {
        return highscore;
    }

    public int GetScore()
    {
        return scorecount;
    }
}

