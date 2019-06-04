using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}

