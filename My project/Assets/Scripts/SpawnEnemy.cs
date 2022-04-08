using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    float m_refTiempo;
    public GameObject prefEnemigo;
    public float tiempoTotal;
    private float cantEnemigos =0;
    public float cantidadMAx;

    void Update()
    {
        //Si el tiempo de referencia es menos o igual al tiempo toal, entonces que los enemigos hagan Spawn y el tiempo total debe ser igual a 0.
        m_refTiempo += Time.deltaTime;
        if (m_refTiempo > tiempoTotal && cantEnemigos < cantidadMAx)
        {
            SpawnEnemigos();
            m_refTiempo = 0;
            cantEnemigos++;
        }
    }

    //Instancia de enemigos
    void SpawnEnemigos()
    {

        //Se usa el quaternion.identity, para que use su rotacion natural, en este caso 0,0,0
        GameObject moveEnemy = Instantiate (prefEnemigo, Camino.Instance.puntosCamino[0], Quaternion.identity); 
    }
}
