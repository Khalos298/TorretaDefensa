using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Clase personalizada. A esta propiedad que se le asigna para que haga referencia al script que va a tomar de referencia.
[CustomEditor(typeof(Camino))]
//Clase que va a heredar propiedades del Editor. 
public class CaminoEditor : Editor
{
    //Se instancia el script como variable
    Camino camino;

    //El OnEnable se ejecuta una sola vez
    //La idea es que sea un vector 3 y no un transform
    private void OnEnable()
    {
        camino = target as Camino;
    }
    //Metodo que se ejecuta o se ve en la vista de la escena
    private void OnSceneGUI()
    {
        //La Varieble que almacena y recorre los puntos es la i del For
        for (int i = 0; i < camino.puntosCamino.Length; i++)
        {
            //Esta linea es para ponerles el nombre 
            Handles.Label(camino.puntosCamino[i], i.ToString());

            //Se reemplaza en los corchetes a los que hacemos referencia. De esta manera se dibujan los demas Handles
            //Esto permite la visualizacion de los puntos creados sin necesidad de crear objetos vacios para arrastrar en el inspector 
            camino.puntosCamino[i] = Handles.DoPositionHandle(camino.puntosCamino[i], Quaternion.identity);

            //En vez de poner la distancia minima en que el enemigo detecta los puntos en otro Script, se referencian en el Script camino y en este se llaman para dibujarles un disco alrededor que será referencia en los enemigos.
            Handles.DrawSolidDisc(camino.puntosCamino[i], Vector3.up, camino.disMin);

            if (i > 0)
            {
                //Dibujamos una linea para saber como se conectan. Es una ayuda visual
                Handles.DrawLine(camino.puntosCamino[i], camino.puntosCamino[i - 1]);
            }
        }
        
    }

}
