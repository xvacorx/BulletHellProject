using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField] PlayerShooting shooting;
    [SerializeField] GameController gameController;

    int hp;

    private void Awake()
    {
        hp = 10;
    }

    private void Update()
    {
        //Debug.Log(hp);
        if (hp <= 0)
        {
            Destroy(gameObject);
            gameController.GameOver();
        }
    }
    public void AddHealth(int health)
    {
        hp += health;
    } //Recuperar vida

    public void LoseHealth(int health)
    {
        hp -= health;
    } //Perder vida

    public void AddAttackSpeed(float speed)
    {
        shooting.fireRate += speed;
    } //Aumentar velocidad de ataque
}
