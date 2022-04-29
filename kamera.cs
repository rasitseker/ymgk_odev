using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{

    public Transform oyuncu;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - oyuncu.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hedefpoz= transform.position = oyuncu.position + offset;
        hedefpoz.x = 0;
        transform.position = hedefpoz;
    }
}
