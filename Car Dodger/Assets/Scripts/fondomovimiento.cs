using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondomovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 vm;

    private Vector2 offset;

    private Material material;
    public void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    public void Update()
    {
        offset = vm * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
