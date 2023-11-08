using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int hp = 1;
    public int scoreValue = 10;
    Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        if (score != null)
        {
            score.AddScore(scoreValue);
        }
    }

    public void LoseHealth(int health)
    {
        hp -= health;
    }
}
