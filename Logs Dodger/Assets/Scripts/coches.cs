using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stones : MonoBehaviour { 


    float speed;

    public Vector2 speedMinMax;

    float visibleHeightThreshold;


    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, dificultad.GetDifficultyPercent());

        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    void Update()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (transform.position.y < visibleHeightThreshold)
        {
            Destroy(gameObject);
        }
    }
}
