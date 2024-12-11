using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo3 : Inimigo
{
    
    void Start()
    {
        velocidade = 6f;
        forcaPulo = 250f;
    }

   
    void Update()
    {
        Mover();
        Pular();
        MudarCorDoInimigo();
    }
}
