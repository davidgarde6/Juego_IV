using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspada : MonoBehaviour
{

    Vector2 posAtaqueDcho;
    public Collider2D collider;

    

    public void Start()
    {

        posAtaqueDcho = transform.position;

    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.tag == "Enemigo")
        {
            Debug.Log("Impacto");
            Enemigo enemigo = col.GetComponent<Enemigo>();

            if(enemigo != null)
            {

                enemigo.vida-=1;

            }
        }
    }

    public void AtaqueDcho()
    {


        collider.enabled = true;
        transform.localPosition = posAtaqueDcho;

    }

    public void AtaqueIzdo()
    {

        collider.enabled = true;
        transform.localPosition = new Vector2(posAtaqueDcho.x * -1, posAtaqueDcho.y);

    }

    public void PararAtaque()
    {

        collider.enabled = false;

    }
}
