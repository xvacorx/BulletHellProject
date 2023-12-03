using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberShoot : MonoBehaviour
{
    float speed = -0.2f;
    float initialSize;
    float targetSize;
    float elapsedTime = 0f;
    float growthDuration = 3f;
    float shrinkDuration = 4f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;

        initialSize = transform.localScale.x;
        targetSize = initialSize * 1.75f;

        Destroy(gameObject, 7f);
    }

    void Update()
    {
        // Actualiza el tiempo transcurrido
        elapsedTime += Time.deltaTime;

        // Aplica el aumento de tamaño durante los primeros 3 segundos
        if (elapsedTime < growthDuration)
        {
            float t = elapsedTime / growthDuration;
            float newSize = Mathf.Lerp(initialSize, targetSize, t);
            transform.localScale = new Vector3(newSize, newSize, 1f);
        }

        // Aplica la reducción de tamaño durante los siguientes 3 segundos
        else if (elapsedTime < growthDuration + shrinkDuration)
        {
            float t = (elapsedTime - growthDuration) / shrinkDuration;
            float newSize = Mathf.Lerp(targetSize, 0f, t);
            transform.localScale = new Vector3(newSize, newSize, 1f);
        }
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
