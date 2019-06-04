using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruiteGene : MonoBehaviour
{
    public GameObject[] Frute;
    private int i;
    int cnt_1=0;
    int cnt_2 = 0;
    bool triger = false;
    void Update()
    {
        cnt_1 = NoteScript.Score;
        if (cnt_1 - cnt_2 > 5)
        {
            triger = true;
            Debug.Log("Hit");
            cnt_2 = cnt_1;
        }
        
        if (triger == true)
        {
            Drop();
            triger = false;
        }
    }
    private void Drop()
    {
        i = Random.Range(0, Frute.Length);
        Instantiate(Frute[i],this.transform.position, Quaternion.identity);
    }
}

