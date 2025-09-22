using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaDeteccionPlanta : MonoBehaviour
{

    public static ZonaDeteccionPlanta Instance;
    public List<Collider2D> objetosDetectados = new List<Collider2D>();
    public float cooldownAtaque = 0f;
    public Animator[] animator;

    private bool ataca = false;
    private bool haAtacado = false;

    // Start is called before the first frame update
    void Awake()
    {

        Instance = this;

    }

    void FixedUpdate()
    {

        ReducirCooldowns();
        Debug.Log(cooldownAtaque);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Jugador")
        {

            objetosDetectados.Add(col);
            
            if(cooldownAtaque <= 0)
            {

                for(int i = 0; i < animator.Length; i++){

                    animator[i].SetBool("isAtacking", true);
                    animator[i].SetBool("reset", false);

                }  
                

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

    void ReducirCooldowns()
    {

        if(cooldownAtaque > 0)
        {

            cooldownAtaque -= Time.deltaTime;

        }

    }
    
}
