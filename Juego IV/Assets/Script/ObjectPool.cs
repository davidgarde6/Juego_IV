using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 20;

    [SerializeField] private GameObject bulletPrefab;

    private void Awake()
    {

        if(Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }

        SceneManager.sceneLoaded += OnLoadedScene;
    }

    public void RecargarPool()
    {

        pooledObjects.Clear();
        for (int i = 0; i < amountToPool; i++)
        {

            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);

        }
    }
    
    private void OnLoadedScene(Scene scene, LoadSceneMode mode)
    {

        RecargarPool();

    }
    public GameObject GetPooledObject()
    {

        for(int i = 0; i < pooledObjects.Count; i++)
        {

            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }

        }

        return null;

    }
}
