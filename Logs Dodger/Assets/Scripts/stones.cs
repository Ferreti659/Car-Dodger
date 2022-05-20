using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stones : MonoBehaviour { 

    float speed = 7;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

    }
}
