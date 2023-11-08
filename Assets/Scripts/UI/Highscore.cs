using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;

    private bool highscoreDisplayed = false;

    void OnEnable()
    {
        if (!highscoreDisplayed)
        {
            int highscore = PlayerPrefs.GetInt("HighScore", 0);
            highscoreText.text = "Highscore: " + highscore.ToString();
            highscoreDisplayed = true;
        }
    }
}