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

        // Normaliza la dirección para obtener una unidad de dirección
        direction.Normalize();

        // Mueve al enemigo hacia el jugador
        transform.position += direction * speed * Time.deltaTime;

        // Alinea la rotación del enemigo con la dirección del jugador (opcional)
        transform.up = direction;
    }
}
