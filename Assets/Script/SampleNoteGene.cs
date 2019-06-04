using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class SampleNoteGene : MonoBehaviour {
	private float songtime=0;
	private float Progresstime=0;
	public string filepass;
	public GameObject[] cube;
    private GameObject Cube_1;
	public AudioSource main;
	private float[] time={};
	private int[] note={};
	private int Notecnt=0;
	private float startTime=0;
    public static int normaconter=0;
    public static int finalscore;
    public GameObject resultCanvas;
    public AudioClip[] Song;
  
	int i = 0;
	void Start(){
		main = GetComponent<AudioSource> ();
        if (SelectSong.selectsong_counter == 1)
        {
            main.clip = Song[0];
            filepass = "CSV/JumpTest";
        }else if (SelectSong.selectsong_counter == 2)
        {
            main.clip = Song[1];
            filepass = "CSV/Ur";
        }
        else if (SelectSong.selectsong_counter == 3)
        {
            main.clip = Song[2];
            filepass = "CSV/Pixels";
        }
        else if (SelectSong.selectsong_counter == 4)
        {
            main.clip = Song[3];
            filepass = "CSV/Football";
        }
        time = new float[1024];
		note = new int[1024];
		startTime = Time.time;
		LoadCSV ();
		Invoke ("MusicPlay", 1.0f);
		songtime = main.clip.length;

	}
	void MusicPlay(){
		main.Play ();
	}
	void LoadCSV(){
		TextAsset csv = Resources.Load (filepass) as TextAsset;
		StringReader reader = new StringReader (csv.text);
		i = 0;
		while(reader.Peek()>-1){
			string line = reader.ReadLine ();
			string[] values = line.Split (',');
			for(int j=0;j<values.Length;j++){
				time[i]=float.Parse(values[0]);
				note[i]=int.Parse(values[1]);
			}
			i++;
		}
	}
	void Update(){
		CheckNote ();
		Progresstime += Time.deltaTime;
		if (songtime - 0.5f <= Progresstime) {
            finalscore = NoteScript.Score;
            resultCanvas.SetActive(true);
		}
	}

	void CheckNote(){
		while (time[Notecnt] < GetMusicTime () && time [Notecnt] != 0) {
			Note (note [Notecnt]);
			Notecnt++;
		}
	}
	void Note(int num){
        int i = UnityEngine.Random.Range(0, cube.Length);
        Cube_1 = cube[i];

		if (num == 0) {
			Instantiate (Cube_1, new Vector3 (0.5f, 2.0f, 5), Quaternion.identity);
			normaconter++;
		} else if (num == 1) {
			Instantiate (Cube_1, new Vector3 (0.5f, 1.4f, 5), Quaternion.identity);
			normaconter++;
		} else if (num == 2) {
			Instantiate (Cube_1, new Vector3 (-0.5f, 2.0f, 5), Quaternion.identity);	
			normaconter++;
		} else if (num == 3) {
			Instantiate (Cube_1, new Vector3 (-0.5f, 1.4f, 5), Quaternion.identity);
			normaconter++;
		}
	}
	float GetMusicTime(){
		return Time.time - startTime;
	}
}
