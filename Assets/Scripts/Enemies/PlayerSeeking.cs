using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeeking : MonoBehaviour
{
    private float movementSpeed = 5f;
    private GameObject player;
    private float rotationSpeed = 180f; // Velocidad de rotaci�n.

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        // Calcula la direcci�n hacia el jugador.
        Vector2 direction = (player.transform.position - transform.position).normalized;

        // Calcula el �ngulo hacia el jugador.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rota gradualmente hacia el �ngulo del jugador.
        float step = rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angle), step);

        // Mueve al enemigo hacia el jugador de frente.
        transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
    }
}
