using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{

    public  Score score;
    private TMP_Text scoreBoard;

    private void Start()
    {
        score.value = 0;
        scoreBoard = GetComponent<TMP_Text>();
        
    }

    private void Update()
    {
        scoreBoard.text = score.value.ToString();
    }
}
