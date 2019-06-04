using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Switch : MonoBehaviour {
    public GameObject gameObject_1;
    public GameObject gameObject_2;
    public GameObject gameObject_3;

    public void OnClick()
    {
        gameObject_1.SetActive(!gameObject_1.activeSelf);
        gameObject_2.SetActive(!gameObject_2.activeSelf);
        gameObject_3.SetActive(!gameObject_3.activeSelf);
    }
}
