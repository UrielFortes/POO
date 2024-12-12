using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(this.gameObject, 1.85f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colidiu com o Player");
        };
    }
}
