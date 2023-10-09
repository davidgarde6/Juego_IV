using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaDeteccion : MonoBehaviour
{
    public Collider2D collider;
    public List<Collider2D> objetosDetectados = new List<Collider2D>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Jugador")
        {

            objetosDetectados.Add(col);

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "Jugador")
        {

            objetosDetectados.Remove(col);

        }
    }

    
}
