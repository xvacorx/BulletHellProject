using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyLife : MonoBehaviour
{
    public GameObject explotion;
    public int hp = 1;
    public int scoreValue = 10;
    Score score;

    [System.Obsolete]
    void Start()
    {
        score = FindObjectOfType<Score>();
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
        if (hp <= 0)
        {
            Instantiate(explotion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
