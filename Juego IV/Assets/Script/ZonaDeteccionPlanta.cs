using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaDeteccionPlanta : MonoBehaviour
{
    public Collider2D collider;
    public List<Collider2D> objetosDetectados = new List<Collider2D>();
    public float cargaAtaque = 2.0f;
    public float ataqueActivo = 3.0f;
    public float cooldownAtaque = 3.0f;
    public SpriteRenderer zona1, zona2;

    private bool ataca = false;
    private bool haAtacado = false;

    // Start is called before the first frame update
    void Start()
    {
        zona1.enabled = false;
        zona2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void FixedUpdate()
    {

        ReducirCooldowns();
        Atacar();
        

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Jugador")
        {

            objetosDetectados.Add(col);
            
            if(cooldownAtaque <= 0)
            {

                ataca = true;

            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "Jugador")
        {

            objetosDetectados.Remove(col);

        }
    }

    void Atacar()
    {

        if(cargaAtaque <= 0)
        {

            Debug.Log("Ha atacado");
            cooldownAtaque = 3.0f;
            cargaAtaque = 2.0f;
            ataca = false;
            zona1.enabled = true;
            zona2.enabled = true;
            haAtacado = true;

        }
    }

    void ReducirCooldowns()
    {

        if(cooldownAtaque > 0)
        {

            cooldownAtaque -= Time.deltaTime;

        }

        if (ataca)
        {

            cargaAtaque -= Time.deltaTime;


        }
        
        if(ataqueActivo > 0 && haAtacado)
        {

            ataqueActivo -= Time.deltaTime;

        }

        if(ataqueActivo <= 0 && haAtacado)
        {

            ataqueActivo = 3.0f;
            haAtacado = false;
            zona1.enabled = false;
            zona2.enabled = false;

        }

    }
    
}
