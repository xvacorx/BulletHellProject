using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeDrop : MonoBehaviour
{
    PowerUpManager powerUpManager;

    public float dropProbability = 0.5f;

    void Start()
    {
        powerUpManager = FindObjectOfType<PowerUpManager>();
    }

    private void OnDestroy()
    {
        if (Random.value < dropProbability)
        {
            powerUpManager.SpawnNuke(transform.position);
        }
    }
}