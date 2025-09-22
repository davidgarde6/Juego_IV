using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionarPuntuacion : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        textMesh.text = "SCORE: " + Singleton.Instance.GetCantidadPuntos().ToString();

    }
}
