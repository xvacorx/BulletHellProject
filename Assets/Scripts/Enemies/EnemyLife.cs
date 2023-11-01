using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int hp = 1;

    private void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void LoseHealth(int health)
    {
        hp -= health;
    }
}
