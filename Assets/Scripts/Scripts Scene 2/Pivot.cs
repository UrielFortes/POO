using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    
    public GameObject bullet;   
        
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(bullet, transform.position, transform.rotation);
            
        }
        


    }
}
