using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int score;

    private void Start()
    {
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
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
