using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundtile : MonoBehaviour
{
    zemin Groundspawner;
    // Start is called before the first frame update
    void Start()
    {
        Groundspawner = GameObject.FindObjectOfType<zemin>();
    }

    private void OnTriggerExit(Collider other)
    {
        Groundspawner.spawntile();
        Destroy(gameObject, 2);

    }
    void Update()
    {
        
    }
}
