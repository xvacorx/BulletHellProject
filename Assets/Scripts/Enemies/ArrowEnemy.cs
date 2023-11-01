using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEnemy : MonoBehaviour
{
    public StatsManager playerLife;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            playerLife.LoseHealth(1);
            Destroy(gameObject);
        }
    }
}
