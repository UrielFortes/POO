using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Score scoreDegree;
    public GameObject explosion;
    void Start()
    {
        
    }

    
    void Update()
    {
        Destroy(this.gameObject, 1.8f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            scoreDegree.value--;
        }
        if (collision.gameObject.CompareTag("missile"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
