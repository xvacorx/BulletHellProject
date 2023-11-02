using UnityEngine;

public class PowerUpDrop : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    public float dropProbability = 0.2f;

    private void OnDestroy()
    {
        if (Random.value < dropProbability)
        {
            SpawnRandomPowerUp();
        }
    }

    private void SpawnRandomPowerUp()
    {
        int randomIndex = Random.Range(0, powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[randomIndex], transform.position, Quaternion.identity);
    }
}