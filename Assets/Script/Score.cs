using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text tex;
    private void Start()
    {
        NoteScript.Score =0;
    }
    void Update () {
        tex.text = "Score:" + NoteScript.Score;
	}
}
