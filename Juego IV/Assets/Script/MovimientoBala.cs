using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    private bool chosenDirection = false;
    private Vector2 direction;

    private void FixedUpdate()
    {
        
        if(ControladorJugador.Instance.IsFlipped() && !chosenDirection)
        {

            direction = new Vector2(-1, 0);
            chosenDirection = true;

        }
        else if(!ControladorJugador.Instance.IsFlipped() && !chosenDirection)
        {

            direction = new Vector2(1, 0);
            chosenDirection = true;
        }

        rb.velocity = direction * speed;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemigo"))
        {
            Enemigo enemigo = other.gameObject.GetComponent<Enemigo>();

            if(enemigo != null)
            {
                enemigo.RecibirDaño();

            }

            chosenDirection = false;
            gameObject.SetActive(false);
        }else
        {

            chosenDirection = false;
            gameObject.SetActive(false);

        }
    }
}
