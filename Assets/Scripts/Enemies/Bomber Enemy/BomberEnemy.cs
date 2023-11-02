using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberEnemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;

    public float speed = 2.0f;
    private Rigidbody2D rb;

    float fireRate = 0.25f;

    float nextFireTime;

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();

        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        randomDirection.Normalize();

        rb.velocity = randomDirection * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out StatsManager playerLife))
        {
            playerLife.LoseHealth(1);
        }
    } //Daño a jugador
    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate; // Establece el tiempo del próximo disparo.
        }
    }
    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, transform.rotation);
    }
}
