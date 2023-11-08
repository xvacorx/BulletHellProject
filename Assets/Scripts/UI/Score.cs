using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int score;
    int highScore;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateScore();
    }

    public void LoseScore(int ammount)
    {
        score -= ammount;
        UpdateScore();
    }

    public void AddScore(int ammount)
    {
        score += ammount;
        UpdateScore();

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
