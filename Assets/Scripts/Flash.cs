using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    SpriteRenderer renderer;
    // Update is called once per frame
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {
        var color = GetComponent<SpriteRenderer>().color;
        color.a -= Time.deltaTime;

        renderer.color = color;
        
    }
}
