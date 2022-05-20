using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stones : MonoBehaviour { 


    float speed = 7;

    public Vector2 speedMinMax;
    private void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, dificultad.GetDifficultyPercent());
    }

    void Update()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

    }
}
