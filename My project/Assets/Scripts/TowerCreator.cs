using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    public GameObject prefTorre;
    public int cantTorres; 

    private void OnMouseDown()
    {
        if(cantTorres > 0)
        {
            TowerSpawn();
            cantTorres--;
        }
    }

    void TowerSpawn()
    {
        GameObject TowerInstance = Instantiate(prefTorre, transform.position, Quaternion.identity);
    }
}
