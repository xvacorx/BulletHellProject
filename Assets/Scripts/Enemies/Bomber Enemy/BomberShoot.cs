using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberShoot : MonoBehaviour
{
    float speed = -0.2f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        Destroy(gameObject, 7f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out StatsManager playerLife))
        {
            playerLife.LoseHealth(1);
            Destroy(gameObject);
        }
    }
}
