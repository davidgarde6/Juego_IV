using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;

    [SerializeField] private GameObject MenuPausa;
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false); //se desactiva el boton de pausa
        MenuPausa.SetActive(true); //se activa el menu
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true); 
        MenuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Salir()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
