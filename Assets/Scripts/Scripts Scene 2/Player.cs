using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject explosion;
    public float speed;
    public GameObject player;
    public Rigidbody rb;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float z = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(0, 0, z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bomb")) 
        {

            Destroy(this.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
        
        }

    }
}
