using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicio : MonoBehaviour
{
    [SerializeField] private GameObject MenuInicio;
    [SerializeField] private GameObject MenuCreditos;
    [SerializeField] private GameObject InterfazJuego;

    private void Start()
    {
        MenuInicio.SetActive(true);
        MenuCreditos.SetActive(false);
        InterfazJuego.SetActive(false);
        DontDestroyOnLoad(InterfazJuego);
    }

    public void Jugar()
    {
        Singleton.Instance.StartGame();
        MenuInicio.SetActive(false);
        InterfazJuego.SetActive(true);
    }
    public void Creditos()
    {
        MenuInicio.SetActive(false);
        MenuCreditos.SetActive(true);
    }
    public void RegresarAlMenu()
    {
        MenuCreditos.SetActive(false);
        MenuInicio.SetActive(true);
    }

    public void Salir()
    {
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
