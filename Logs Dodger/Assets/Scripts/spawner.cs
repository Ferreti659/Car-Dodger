using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour { 

    public GameObject stonesPrefab;

    public float secondBetweenSpawns = 1;
    float nextSpawnTime;

    public Vector2 spawnSizeMinMax;

    Vector2 screenHalfSizeWorldUnits;


    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondBetweenSpawns;

            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);

            Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y + spawnSize/2f);
            GameObject newBlock = (GameObject)Instantiate(stonesPrefab, spawnPosition, Quaternion.identity);
            newBlock.transform.localScale = Vector2.one * spawnSize;
        }
    
    }
}
