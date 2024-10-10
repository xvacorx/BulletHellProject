using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject hitEffect;
    float speed = 15f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyLife enemy))
        {
            enemy.LoseHealth(1);
            GameObject hit = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(hit, 1f);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
            GameObject hit = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(hit, 1f);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Terrain"))
        {
            Destroy(gameObject);
        }
    }
}