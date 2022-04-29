using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu_hareket : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    public float horizontalInput;
    public float horizontalMultiplier = 2;
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove+ horizontalMove);
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("horizontal");
    }
}
