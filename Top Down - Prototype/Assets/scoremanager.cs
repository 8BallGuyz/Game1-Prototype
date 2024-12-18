using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    // Increments the score and updates the UI
    public void AddPoint()
    {
        score = score + 1;
        scoreText.text = "" + score;
    }
}
