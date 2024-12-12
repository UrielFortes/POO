using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody rb;
    public float strengthVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Destroy(this.gameObject, 0.85f);

        rb.velocity =  transform.up * strengthVelocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colidiu no Player");
        };
    }

}
