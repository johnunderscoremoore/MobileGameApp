using UnityEngine;
using System.Collections;

public class GameOverMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void gameovermusic () {
		GetComponent<AudioSource>().Play ();
	}
}
