using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camino : MonoBehaviour
{
    //Ya que es estatico, cualquiera lo puede referenciar
    public static Camino Instance; 
    //Estos puntos son de referencia para el Script de CaminoEditor
    public Vector3[] puntosCamino;
    public float disMin;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
