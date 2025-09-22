using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPuertaSalon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que entra es el jugador
        if (other.CompareTag("Jugador"))
        {
            
            SceneManager.LoadScene("cocina");

        }
    }
}
