using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    public GameObject groundtile;
    Vector3 nextSpawnPoint;


    public void spawntile()
    {
        GameObject temp = Instantiate(groundtile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Update()
    {
        for (int i = 0; i< 50; i++)
        {
            spawntile();
        }
       
    }
}
