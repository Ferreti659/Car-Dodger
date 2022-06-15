using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirWeb : MonoBehaviour
{
    public string url = "http://localhost:4200";
    public void AbriWeb()
    {
        Application.OpenURL(url);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
