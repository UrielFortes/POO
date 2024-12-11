using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo2 : Inimigo
{
  
    void Start()
    {
        velocidade = 4f;
        forcaPulo = 300f;
    }

  
    void Update()
    {
        Mover();
        Pular();
        MudarCorDoInimigo();
    }
}
