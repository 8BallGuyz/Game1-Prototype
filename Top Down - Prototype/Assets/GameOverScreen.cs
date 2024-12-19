using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text finalscore;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        int highScore = ScoreManager.instance.GetHighScore();
        finalscore.text = "HIGHSCORE : " + highScore.ToString();
    }
}

