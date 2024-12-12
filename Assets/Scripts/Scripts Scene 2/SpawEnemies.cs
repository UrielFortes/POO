using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawEnemies : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float spawRandomEnemies;
    private float minX = -15.0f;
    private float maxX = 15.0f;
    private Vector3 posToSpaw;
    private float timeSpaw = 0.5f;
    private float delaySpaw = 1.5f;
    public static bool  spawAllowed;
    public int randomMonster;

    private void Start()
    {
        spawAllowed = true;
        InvokeRepeating("SpawEnemie", timeSpaw, delaySpaw);
    }
    void Update()
    {
        
    }
    void SpawEnemie() 
    {        
            spawRandomEnemies = Random.Range(minX, maxX);
            posToSpaw = new Vector3(spawRandomEnemies, transform.position.y, 0);

        if (spawAllowed) 
        {

              randomMonster = Random.Range(0, enemyPrefab.Length);

              Instantiate(enemyPrefab[randomMonster], posToSpaw, transform.rotation);
        
        }            
              
        
    }
}
