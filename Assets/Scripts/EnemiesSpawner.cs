using System;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour 
{
    public GameObject[] enemies;

    private float spawnRangeX = -7.4f;
    private float spawnRangeY = 1.9f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       SpawnEnemies();
       DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {


        Vector3 spawnPos = new Vector3(spawnRangeX, spawnRangeY, 0);
        foreach (var enemy in enemies)
        {
            for (int i = 0; i < 9; i++)
            {

                Instantiate(enemy, spawnPos, enemy.transform.rotation);
                spawnPos.x += 1.8f;

            }

            spawnPos.x = spawnRangeX;
            spawnRangeY += 0.8f;
            spawnPos.y = spawnRangeY;
        }





    }
}
