using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public GameObject prefEnemy;
    public List<GameObject> enemiesPool;
    public int cantEnemies;

    private void Awake()
    {
        //Necesita que se reconozca desde el comienzo.
        CreateEnemies();
        
    }

    void CreateEnemies()
    {
        for (int i = 0; i < cantEnemies; i++)
        {
            // el this.transform, es para duplicar el objeto y hacerlo en el padre. 
            GameObject ejecutar = Instantiate(prefEnemy, this.transform);
            enemiesPool.Add(ejecutar);
            ejecutar.SetActive(false);
        }
    }

    //public GameObject ObtenerEnemigo()
    //{
    //    for (int i = 0; i < enemiesPool.Count; i++)
    //    {
    //        if (!enemiesPool[i].activeSelf)
    //        {
    //            return enemiesPool[i];
    //        }
    //        enemiesPool = null; 
    //    }
    //}
}
