using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Con : MonoBehaviour {

    int i = 0;
    public GameObject gameObject;
	void Update () {
        gameObject.transform.Rotate(0,i*0.01f, i*0.01f);
        i++;
        if (i == 360)
        {
            i = 0;
        }
	}
}
