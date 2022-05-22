using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coche : MonoBehaviour
{
	public Vector2 speedMinMax;
	float speed;

	float visibleHighThresHold;

	void Start()
	{
		speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, dificultad.GetDifficultyPercent());

		visibleHighThresHold = -Camera.main.orthographicSize - transform.localScale.y;
	}

	void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
    
		if(transform.position.y < visibleHighThresHold)
        {
			Destroy(gameObject);
        }
	
	}
}
