using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public GameObject prefTorre;
    public GameObject prefEnemy; 
    public float tamañoGizmo;
    float perimetroZona; 
  
    private void Update()
    {
        zonaAtaque();
    }
    void zonaAtaque()
    {
        if (Vector3.Distance(prefEnemy.transform.position,prefTorre.transform.position) < tamañoGizmo)
        {
            Debug.Log("Ataque");
           
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, tamañoGizmo);
    }


}
