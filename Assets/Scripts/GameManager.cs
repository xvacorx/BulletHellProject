using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}