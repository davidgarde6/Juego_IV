using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    public static Enemigo Instance;
    public Animator animator;
    [SerializeField] private float cantidadPuntos;

    public float Salud
    {

        set
        {
            vida = value;

        }

        get
        {

            return vida;

        }
    }

    public float vida = 1;

    public void RecibirDaño()
    {

        Salud--;
        animator.SetBool("isHit", true);

    }
    
    public void Derrotado()
    {

        if(vida <= 0)
        {
            
            Singleton.Instance.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
        }

        animator.SetBool("isHit", false);
    }
}
