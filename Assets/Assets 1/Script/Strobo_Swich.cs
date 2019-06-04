using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobo_Swich : MonoBehaviour {
    public GameObject Strobo;

    public void OnClick()
    {
        
        Strobo.SetActive(!Strobo.activeSelf);
    }
}
