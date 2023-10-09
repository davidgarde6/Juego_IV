using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo1 : MonoBehaviour
{
    public GameObject jugador;
    public float velocidad;
    public float distanciaPersecucion = 6.0f;
    public Rigidbody2D rb;
    public int vida = 1;

    private float horizontal;
    private float distancia;
    private float tiempoMovimiento;
    private Vector2 direccion;


    // Start is called before the first frame update
    void Start()
    {
        horizontal = Mathf.Round(Random.Range(0, 2));
        direccion = new Vector2(0, 0);
        tiempoMovimiento = Mathf.Round((Random.Range(1, 4)));

    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    void Mover()
    {

        distancia = Vector2.Distance(transform.position, jugador.transform.position);

        if(distancia < distanciaPersecucion)
        {
            
            velocidad = 3.0f;
            transform.position = Vector2.MoveTowards(this.transform.position, jugador.transform.position, velocidad * Time.deltaTime);

        }
        else
        {

            DecidirMovimiento();
            
        }


    }
    void DecidirMovimiento()
    {

        velocidad = 1.0f;

        if((int)tiempoMovimiento <= 0)
        {

            horizontal = Random.Range(0, 2);

            if (horizontal == 1)
            {
                float direccionHorizontal = Mathf.Round((Random.Range(-1, 2)));
                direccion = new Vector2(direccionHorizontal, 0);
                tiempoMovimiento = Mathf.Round((Random.Range(0, 4)));

            }
            else
            {
                float direccionVertical = Mathf.Round((Random.Range(-1, 2)));
                direccion = new Vector2(0, direccionVertical);
                tiempoMovimiento = Mathf.Round((Random.Range(0, 4)));

            }
        }
        else
        {

            rb.velocity = new Vector2(direccion.x * velocidad, direccion.y * velocidad);
            tiempoMovimiento -= Time.deltaTime;
            
        }
    }

    //private Vector2 ObtenerDireccion(int horizontal, int vertical)
    //{

    //    Vector2 direccionRandom = new Vector2(Random.Range(-horizontal, vertical), Random.Range(-horizontal, vertical)).normalized;

    //    return direccionRandom;

    //}

}
