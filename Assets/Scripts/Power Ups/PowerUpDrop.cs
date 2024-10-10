using UnityEngine;

public class PowerUpDrop : MonoBehaviour
{
    PowerUpManager powerUpManager;

    public float dropProbability = 0.2f;

    [System.Obsolete]
    void Start()
    {
        powerUpManager = FindObjectOfType<PowerUpManager>();
    }

    private void OnDestroy()
    {
        if (Random.value < dropProbability)
        {
            powerUpManager.SpawnRandomPowerUp(transform.position);
        }
    }
}