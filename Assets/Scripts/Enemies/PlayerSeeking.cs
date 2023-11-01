using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSeeking : MonoBehaviour
{
    private Transform player;
    [SerializeField] float speed = 2.5f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 playerPosition = player.position;
        Vector3 direction = playerPosition - transform.position;
        direction.z = 0;

        // Normaliza la direcci�n para obtener una unidad de direcci�n
        direction.Normalize();

        // Mueve al enemigo hacia el jugador
        transform.position += direction * speed * Time.deltaTime;

        // Alinea la rotaci�n del enemigo con la direcci�n del jugador (opcional)
        transform.up = direction;
    }
}
