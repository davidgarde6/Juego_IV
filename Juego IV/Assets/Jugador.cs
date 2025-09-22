using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public static Jugador Instance;
    public float vida = 3;

    public Image[] corazones;

    void Awake()
    {

        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnLoadedScene;

    }

    private void OnLoadedScene(Scene scene, LoadSceneMode mode)
    {
        switch (SceneManager.GetActiveScene().name){

            case "salon":
                transform.position = new Vector2(-4.28f, -2.68f);
            break;
            case "cocina":
                transform.position = new Vector2(-4.4f, -2.91f);
            break;
        }
    }

    void Update()
    {

        if(vida <= 0)
        {

            Derrotado();

        }

        for (int i = 0; i < corazones.Length; i++)
        {

            corazones[i].enabled = false;

        }


        for (int i = 0; i < Singleton.Instance.GetCantidadVidas(); i++)
        {

            corazones[i].enabled = true;

        }
     
        
    }

    public void Derrotado()
    {

        if(vida == 0)
        {
            gameObject.SetActive(false);
            vida = 0;
        }
        

    }

}
