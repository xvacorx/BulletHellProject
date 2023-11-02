using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out StatsManager playerLife))
        {
            playerLife.LoseHealth(1);
        }
    } //Daño a jugador
}
