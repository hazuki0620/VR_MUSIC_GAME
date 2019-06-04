using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSong : MonoBehaviour
{
    public static int selectsong_counter;
    public GameObject NoteGene;
    public GameObject SelectSongCanvas;

    public void Song_1()
    {
        selectsong_counter = 1;
        Invoke("GameStart", 1.0f);
    }
    public void Song_2()
    {
        selectsong_counter = 2;
        Invoke("GameStart", 1.0f);
    }
    public void Song_3()
    {
        selectsong_counter = 3;
        Invoke("GameStart", 1.0f);
    }
    public void Song_4()
    {
        selectsong_counter = 4;
        Invoke("GameStart", 1.0f);
    }
    void GameStart()
    {
        NoteGene.SetActive(true);
        SelectSongCanvas.SetActive(false);
    }
}
