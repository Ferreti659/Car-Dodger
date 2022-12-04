using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour { 

    public GameObject cochePrefab;
    public Vector2 secondsBetweenSpawnsMinMax;
    float nextSpawnTime;
    public Vector2 screenHalfSizeWorldUnits;






    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {

            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, dificultad.GetDifficultyPercent());
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y);
            Instantiate (cochePrefab, spawnPosition, Quaternion.identity);
            //GameObject newBlock = (GameObject)Instantiate(stonesPrefab, spawnPosition, Quaternion.Euler(Vector3.forward));
            //newBlock.transform.localScale = Vector2.one;
        }
    
    }
}
