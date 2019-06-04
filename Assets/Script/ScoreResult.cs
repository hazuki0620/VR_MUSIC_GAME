using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreResult : MonoBehaviour
{
    public Text yourScore;
    public Text song;
    public Text highScoreText;
    private int[] highScore = new int[4];
   

    void Start()
    {  
        highScore[0] = PlayerPrefs.GetInt("Song_1", 0);
        highScore[1] = PlayerPrefs.GetInt("Song_2", 0);
        highScore[2] = PlayerPrefs.GetInt("Song_3", 0);
        highScore[3] = PlayerPrefs.GetInt("Song_4", 0);
    }
    private void Update()
    {
        yourScore.text = SampleNoteGene.finalscore.ToString();

        Debug.Log(highScore[3]);
        if (SelectSong.selectsong_counter == 1)
        {
            if (SampleNoteGene.finalscore > highScore[0])
            {
                song.text = "Song_1";
                highScore[0] = SampleNoteGene.finalscore;
                PlayerPrefs.SetInt("Song_1", highScore[0]);
            }
            highScoreText.text = "1. " + highScore[0].ToString();
         
        }
        if (SelectSong.selectsong_counter == 2)
        {
            if (SampleNoteGene.finalscore > highScore[1])
            {
                song.text = "Song_2";
                highScore[1] = SampleNoteGene.finalscore;
                PlayerPrefs.SetInt("Song_2", highScore[1]);
            }
            highScoreText.text = "1. " + highScore[1].ToString();
        
        }
        if (SelectSong.selectsong_counter == 3)
        {
            if (SampleNoteGene.finalscore > highScore[2])
            {
                song.text = "Song_3";
                highScore[2] = SampleNoteGene.finalscore;
                PlayerPrefs.SetInt("Song_3", highScore[2]);
            }
            highScoreText.text = "1. " + highScore[2].ToString();
           
        }
        if (SelectSong.selectsong_counter == 4)
        {
    
            if (SampleNoteGene.finalscore > highScore[3])
            {
                song.text = "Song_4";
                highScore[3] = SampleNoteGene.finalscore;
                PlayerPrefs.SetInt("Song_4", highScore[3]);
            }
            highScoreText.text = "1. " + highScore[3].ToString();

        }
    }

    public void Onclick() {
        SceneManager.LoadScene("VRMUSIC");
    }
}
