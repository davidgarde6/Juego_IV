using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float velMovimiento = 6;
    public Rigidbody2D rb;
    public float cooldownGolpe = 2.0f;

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

            Golpear();
            
        }

        dirMovimiento = new Vector2(moverX, moverY).normalized;

    }

    void Golpear()
    {

        Debug.Log("Golpea");
        cooldownGolpe = 2.0f;

    }

    void reducirCooldowns()
    {

        if(cooldownGolpe > 0)
        {

            cooldownGolpe -= Time.deltaTime;

        }
    }

    void Mover()
    {

        rb.velocity = new Vector2(dirMovimiento.x * velMovimiento, dirMovimiento.y * velMovimiento);

    }
}
