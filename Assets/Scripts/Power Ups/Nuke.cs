using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuke : MonoBehaviour
{
    private Transform player;
    float speed = 0.5f;

    public string[] tagsToDestroy;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 playerPosition = player.position;
        Vector3 direction = playerPosition - transform.position;
        direction.z = 0;

        direction.Normalize();

        // Mueve al enemigo hacia el jugador
        transform.position += -direction * speed * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Elimina todos los objetos con las etiquetas especificadas
            foreach (string tagToDestroy in tagsToDestroy)
            {
                GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(tagToDestroy);
                foreach (GameObject obj in objectsToDestroy)
                {
                    Destroy(obj);
                }
            }

            Destroy(gameObject);
        }
    }
}