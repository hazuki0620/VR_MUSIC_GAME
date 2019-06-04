using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobo : MonoBehaviour
{
    private float nextTime;
    public GameObject gameObject;
    public float interval = 1.0f;

    private void Start()
    {
        nextTime = Time.time;
    }

    void Update()
    {
        if (nextTime % 2.0 == 0) 
        {
            gameObject.SetActive(true);
        }
        else{
            gameObject.SetActive(false);
        }
        nextTime += interval;
  
    }
}