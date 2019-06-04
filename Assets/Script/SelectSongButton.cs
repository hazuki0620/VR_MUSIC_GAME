using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSongButton : MonoBehaviour
{
    public AudioSource song_1;
    public void func()
    {
        song_1.Play();
    }
}