using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    public GameObject Nuke;
    public void SpawnRandomPowerUp(Vector3 position)
    {
        int randomIndex = Random.Range(0, powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[randomIndex], position, Quaternion.identity);
    }
    public void SpawnNuke(Vector3 position)
    {
        Instantiate(Nuke, position, Quaternion.identity);
    }
}
