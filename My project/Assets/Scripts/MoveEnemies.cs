using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemies : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] float velocidadRotacion; 
    //Tamaño de lista
    int index; 

    private void Update()
    {
        Movimiento();
    }
    void Movimiento()
    {
        //Se mueve en direccion hacia adelante, multiplicado por el time. deltatime por la velocidad
        transform.Translate(Vector3.forward * (Time.deltaTime * velocidad));

        //De la ecuacion, se quita el eje Y de la ecuacion, para que el personaje no se mueva hacia arriba o abajo. 
        Vector3 PosicionInicial = new Vector3(Camino.Instance.puntosCamino[index].x, transform.position.y, Camino.Instance.puntosCamino[index].z) - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(PosicionInicial, Vector3.up);

        //Slerp es interpolar un valor entre un min y un max. Es decir, hallar un valor medio. 
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * velocidadRotacion);

        //Si la distancia entre el punto A y el punto B es menor o igual a la distancia minima
        if (Vector3.Distance(Camino.Instance.puntosCamino[index], transform.position) <= Camino.Instance.disMin)
        {
            if (index < Camino.Instance.puntosCamino.Length - 1)
            {
                index += 1;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        
        


    }
   




}
