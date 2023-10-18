using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject backgroundNight;
    public GameObject backgroundDay;
    // Start is called before the first frame update
    void Start()
    {
        var rnd = Random.Range(0f, 1f);
        if (rnd < 0.5)
        {
            backgroundDay.SetActive(true);
        }
        else
        {
            backgroundNight.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
