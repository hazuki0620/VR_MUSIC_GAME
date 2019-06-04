using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject SelectSong;
    public GameObject StartCanvas;
    
    public void Onclick()
    {
        StartCanvas.SetActive(false);
        SelectSong.SetActive(true);
    }

}
