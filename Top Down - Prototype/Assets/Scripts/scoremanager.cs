using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text score;

    int scorecount = 0;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        score.text = "SCORE : " + scorecount.ToString();
    }

    public void AddPoint()
    {
        scorecount = scorecount + 1;
        score.text = "SCORE : " + scorecount.ToString();
    }

}
