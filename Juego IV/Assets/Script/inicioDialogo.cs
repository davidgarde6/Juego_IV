using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inicioDialogo : MonoBehaviour
{
    public GameObject PanelDialogo; // Asigna el panel desde el Inspector de Unity

    void Start()
    {
        MostrarDialogo();
    }

    void MostrarDialogo()
    {
        // Activa el panel para mostrar el di�logo
        PanelDialogo.SetActive(true);
        // Puedes agregar m�s l�gica aqu�, como animaciones, sonidos, etc.
    }
}
