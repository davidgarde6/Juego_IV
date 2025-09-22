using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionarDañoPlanta : MonoBehaviour
{
    public Collider2D collider;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Jugador") && collider.enabled)
        {

            Singleton.Instance.RestarVidas();

        }


    }
}
