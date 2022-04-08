using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBala : MonoBehaviour
{
    public GameObject prefBala;
    public float velocidadBala;
    public float tiempodeREf;
    public float tiempototal; 

    void Update()
    {
        //Si el tiempo de referencia es menos o igual al tiempo toal, entonces que los enemigos hagan Spawn y el tiempo total debe ser igual a 0.
        tiempodeREf += Time.deltaTime;
        if (tiempodeREf > tiempototal)
        {
            SpawnEnemigos();
            tiempodeREf = 0;
            
        }
    }

    //Instancia de enemigos
    void SpawnEnemigos()
    {
        //Se usa el quaternion.identity, para que use su rotacion natural, en este caso 0,0,0
        GameObject Bala = Instantiate(prefBala, transform.position, Quaternion.identity);
    }
}
