using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuke : MonoBehaviour
{
    private Transform player;
    float speed = 0.5f;

    public string[] tagsToDestroy;
    public AudioClip explosionSound;

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

        transform.position += -direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            // Reproduce el sonido
            if (explosionSound != null)
            {
                AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            }

            foreach (string tagToDestroy in tagsToDestroy)
            {
                GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(tagToDestroy);
                foreach (GameObject obj in objectsToDestroy)
                {
                    EnemyLife enemyHp = obj.GetComponent<EnemyLife>();
                    enemyHp.LoseHealth(500);
                }
            }

            StartCoroutine(DestroyAfterSound());
        }
    }

    IEnumerator DestroyAfterSound()
    {
        yield return new WaitForSeconds(explosionSound.length);
        Destroy(gameObject);
    }
}