using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    [SerializeField] PlayerShooting shooting;
    [SerializeField] GameManager gameController;
    [SerializeField] Lives life;
    [SerializeField] GameObject hitEffect;

    int hp;

    private void Awake()
    {
        hp = 5;
    }

    private void Update()
    {
        //Debug.Log(hp);
        if (hp <= 0)
        {
            gameController.GameOver();
        }
    }
    public void AddHealth(int health)
    {
        hp += health;
        life.AddLife(health);
    } //Recuperar vida

    public void LoseHealth(int health)
    {
        hp -= health;
        life.LoseLife(health);
        GameObject hit = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(hit, 1f);
    } //Perder vida

    public void AddAttackSpeed(float speed)
    {
        shooting.fireRate += speed;
    } //Aumentar velocidad de ataque
}
