using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text finalscore;

    public void Start()
    {
        // Optionally, you could initialize something here if needed
    }

    public void Update()
    {
        gameObject.SetActive(true);
        int highscore = PlayerPrefs.GetInt("HighScore", 0);
        finalscore.text = "HIGHSCORE : " + highscore;
    }
}


