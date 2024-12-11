using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawRandomEnemies;
    private float minX = -15.0f;
    private float maxX = 15.0f;
    private Vector3 posToSpaw;
    private float timeSpaw = 0.5f;
    private float delaySpaw = 1.5f;
    

    private void Start()
    {
        InvokeRepeating("SpawEnemie", timeSpaw, delaySpaw);
    }
    void Update()
    {
        
    }
    void SpawEnemie() 
    {        
            spawRandomEnemies = Random.Range(minX, maxX);
            posToSpaw = new Vector3(spawRandomEnemies, transform.position.y, 0);
            Instantiate(enemyPrefab, posToSpaw, transform.rotation);  
        
        
    }
}
