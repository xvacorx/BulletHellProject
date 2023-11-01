using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectilePrefab;

    float fireRate = 0.25f;

    float nextFireTime;

    private Transform player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out StatsManager playerLife))
        {
            playerLife.LoseHealth(1);
            Destroy(gameObject);
        }
    } //Daño a jugador

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 playerPosition = player.position;

        Vector2 shootDirection = (playerPosition - transform.position).normalized;

        transform.up = shootDirection;

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
    public void AttackSpeedIncrease(float increase)
    {
        fireRate = fireRate * increase;
    }
}