using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Score scoreDegree;
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(this.gameObject, 1.9f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            scoreDegree.value--;
        }
    }
}
