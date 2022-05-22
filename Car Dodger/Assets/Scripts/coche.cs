using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coche : MonoBehaviour
{
	public Vector2 speedMinMax;
	float speed;

	void Start()
	{
		speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, dificultad.GetDifficultyPercent());
	}

	void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
    }
}
