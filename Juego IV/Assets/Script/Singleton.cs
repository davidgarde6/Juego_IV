using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance;

    private bool gameActive = false;
    [SerializeField] private float cantidadVidas;
    [SerializeField] private float cantidadPuntos;

    private void Awake()
    {

        if (Singleton.Instance == null)
        {

            Singleton.Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {

            Destroy(gameObject);

        }
    }

    public void StartGame()
    {

        gameActive = true;

    }

    public bool IsActive()
    {

        return gameActive;

    }

    public float GetCantidadVidas()
    {

        return cantidadVidas;

    }

    public float GetCantidadPuntos()
    {

        return cantidadPuntos;

    }

    public void RestarVidas()
    {

        cantidadVidas--;

        if (cantidadVidas < 0)
        {

            cantidadVidas = 0;

        }

    }

    public void SumarPuntos(float puntos)
    {

        cantidadPuntos += puntos;

    }

}
