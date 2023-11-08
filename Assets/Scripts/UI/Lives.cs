using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour
{
    public TextMeshProUGUI lifeText;

    int life = 5;

    private void Start()
    {
        UpdateLife();
    }

    public void LoseLife(int ammount)
    {
        life -= ammount;
        UpdateLife();
    }
    public void AddLife(int ammount)
    {
        life += ammount;
        UpdateLife();
    }
    void UpdateLife()
    {
        lifeText.text = "Lives: " + life.ToString();
    }
}
