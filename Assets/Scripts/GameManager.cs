using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Spawner spawner;

    public GameObject gameOverScreen;
    public TextMeshProUGUI counterText;

    private void Start()
    {
        Time.timeScale = 1f;
        StartCoroutine(Counter());
    }

    IEnumerator Counter()
    {
        int count = 3;
        while (count > 0)
        {
            counterText.text = count.ToString();
            yield return new WaitForSeconds(1f);
            count--;
        }
        counterText.text = "Start!";
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1.0f;
        spawner.spawnerActive = true;
        StartCoroutine(spawner.timer());
        Destroy(counterText);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}