using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorDePuerta : MonoBehaviour
{
    // Definir una etiqueta para el jugador
    private const string etiquetaJugador = "Jugador";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que sale es el jugador
        if (other.CompareTag("Jugador"))
        {
            SceneManager.LoadScene("salon");
        }
    }


    private void Update()
    {

    }
}
