using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velMovimiento = 10;
    public Rigidbody2D rb;
    public float cooldownGolpe = 2.0f;
    public float cooldownMovimiento = 0.25f;

    private Vector2 dirMovimiento;

    // Update is called once per frame
    void Update()
    {

        ProcesarEntradas();
        reducirCooldowns();
        
    }

    void FixedUpdate()
    {

        // Calcular físicas
        Mover();

    }

    void ProcesarEntradas()
    {

        float moverX = Input.GetAxisRaw("Horizontal");
        float moverY = Input.GetAxisRaw("Vertical");

        
        if (Input.GetKeyDown(KeyCode.Space) && cooldownGolpe <= 0)
        {

            detenerMovimiento();
            Golpear();

        }

        dirMovimiento = new Vector2(moverX, moverY).normalized;

    }

    void Golpear()
    {

        Debug.Log("Golpea");
        cooldownGolpe = 2.0f;

    }

    void detenerMovimiento()
    {

        cooldownMovimiento = 0.25f;
        

    }

    void reducirCooldowns()
    {

        if (cooldownGolpe > 0)
        {

            cooldownGolpe -= Time.deltaTime;

        }

        cooldownMovimiento -= Time.deltaTime;

    }

    void Mover()
    {

        if(cooldownMovimiento <= 0)
        {

            rb.velocity = new Vector2(dirMovimiento.x * velMovimiento, dirMovimiento.y * velMovimiento);

        }
    }
}
