using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Vector3[] arrowPositions;
    public Vector3[] tankPositions;
    public Vector3[] shooterPositions;
    public Vector3[] bomberPositions;

    int randomQuantity;

    bool spawnerActive = true;

    float delay;

    private void Start()
    {
        spawnerActive = true;

        delay = 10f;
        StartCoroutine(timer());
    }
    private IEnumerator timer()
    {
        while (spawnerActive)
        {
            Debug.Log(delay);
            Spawn();
            if (delay >= 3)
            {
                yield return new WaitForSeconds(delay);
                reduceDelay(0.5f);
            }
            else { yield return new WaitForSeconds(3f); }
        }
    } //Tiempo de spawneo

    public void reduceDelay(float reduction)
    {
        delay -= reduction;
    } //Disminuir tiempo de spawn

    public void addDelay(float add)
    {
        delay += add;
    } //Aumentar tiempo de spawn

    void Spawn()
    {   
        int mobToSpawn =  Random.Range(0, enemyPrefabs.Length);

        switch (mobToSpawn)
        {
            case 0:
                randomQuantity = Random.Range(2, 3);
                for (int i = 0; i < randomQuantity; i++)
                {
                    int randomPosition = Random.Range(0, arrowPositions.Length);
                    Instantiate(enemyPrefabs[mobToSpawn], arrowPositions[randomPosition], Quaternion.identity);
                } //Arrow Enemy
                break;
            case 1:
                randomQuantity = Random.Range(1, 2);
                for (int i = 0; i < randomQuantity; i++)
                {
                    int randomPosition = Random.Range(0, tankPositions.Length);
                    Instantiate(enemyPrefabs[mobToSpawn], tankPositions[randomPosition], Quaternion.identity);
                } //Tank Enemy
                break;
            case 2:
                randomQuantity = Random.Range(1, 3);
                for (int i = 0; i < randomQuantity; i++)
                {
                    int randomPosition = Random.Range(0, shooterPositions.Length);
                    Instantiate(enemyPrefabs[mobToSpawn], shooterPositions[randomPosition], Quaternion.identity);
                } //Shooter Enemy
                break;
            case 3:
                randomQuantity = Random.Range(1, 3);
                for (int i = 0; i < randomQuantity; i++)
                {
                    int randomPosition = Random.Range(0, bomberPositions.Length);
                    Instantiate(enemyPrefabs[mobToSpawn], bomberPositions[randomPosition], Quaternion.identity);
                } //Bomber Enemy
                break;
        }
    }
}
