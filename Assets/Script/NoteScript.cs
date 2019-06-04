using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScript : MonoBehaviour {
	public GameObject per;
	private float speed=5.0f;
	private Mesh mesh;
    public static int Score=0;
	void Start(){
		//mesh = GetComponent<MeshFilter> ().mesh;
	}
	void Update () {
        transform.Rotate(new Vector3(0, 0, 5));
        transform.Rotate(new Vector3(0, 5, 0));
        this.transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
	}
    void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        if (other.gameObject.tag == "Player")
        {
            speed = 0.0f;
            per.SetActive(true);
            Score++;
            Invoke("Change", 0.2f);

        }
        if (other.gameObject.tag == "Wall")
        {
            speed = 0.0f;
            per.SetActive(true);
            Invoke("Change", 0.2f);
        }
    }
	void Change(){
		Destroy (this.gameObject);
	}
}
	