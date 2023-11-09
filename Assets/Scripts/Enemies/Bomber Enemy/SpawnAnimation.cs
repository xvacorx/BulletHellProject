using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimation : MonoBehaviour
{
    float tiempoDeAnimacionTotal = 2.0f; // Duración total de la animación
    Vector3 escalaInicial;
    Vector3 escalaObjetivo;
    float tiempoInicio;

    private void Start()
    {
        Destroy(gameObject, 5f);
        escalaInicial = Vector3.zero; // Escala inicial a 0,0,0
        transform.localScale = escalaInicial; // Establece la escala inicial
        escalaObjetivo = new Vector3(2.0f, 2.0f, 2.0f);

        IniciarAnimacion();
    }

    private void IniciarAnimacion()
    {
        tiempoInicio = Time.time;
        StartCoroutine(AnimacionEscala());
    }

    private IEnumerator AnimacionEscala()
    {
        float tiempoPasado = 0.0f;

        while (tiempoPasado < tiempoDeAnimacionTotal / 2.0f) // La mitad del tiempo para el aumento
        {
            float progreso = tiempoPasado / (tiempoDeAnimacionTotal / 2.0f);
            transform.localScale = Vector3.Lerp(escalaInicial, escalaObjetivo, progreso);
            tiempoPasado = Time.time - tiempoInicio;
            yield return null;
        }
        transform.localScale = escalaObjetivo;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(AnimacionDisminuirEscala());
    }

    private IEnumerator AnimacionDisminuirEscala()
    {
        float tiempoPasado = 0.0f;

        while (tiempoPasado < tiempoDeAnimacionTotal / 2.0f) // La mitad del tiempo para la disminución
        {
            float progreso = tiempoPasado / (tiempoDeAnimacionTotal / 2.0f);
            transform.localScale = Vector3.Lerp(escalaObjetivo, escalaInicial, progreso);
            tiempoPasado = Time.time - tiempoInicio;
            yield return null;
        }
        transform.localScale = escalaInicial;
    }
}
