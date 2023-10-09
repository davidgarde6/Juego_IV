using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float Salud
    {

        set
        {
            vida = value;

            if(vida <= 0)
            {

                Derrotado();
            }
        }

        get
        {

            return vida;

        }
    }

    public float vida = 1;
    
    public void Derrotado()
    {

        Destroy(gameObject);

    }
}
