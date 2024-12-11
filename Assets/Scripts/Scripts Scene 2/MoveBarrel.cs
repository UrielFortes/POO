using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrel : MonoBehaviour
{
    
    Vector2 mousePosition;
   

    void Update()
    {
       
        mousePosition = Input.mousePosition;
        transform.LookAt(mousePosition);
    }

}
