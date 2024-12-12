using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody rb;
    public float forcaTiro;
     
    public Score score;


    private void Start()
    {
        rb.GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        rb.velocity = transform.up * forcaTiro  ;

        Destroy(gameObject, 1f);

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("inimigo"))
        {
            
            score.value++;
            Destroy(this.gameObject);
            
        }
    }
    

    
}
