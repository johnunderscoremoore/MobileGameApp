using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	
	public Text scoreText;
	public int ballValue;
	
	public static int score;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "points") {
			GameObject.Find ("PointSound").GetComponent<AudioSource> ().Play ();
			score += ballValue;
			UpdateScore ();
			Destroy(other.gameObject);
		}
	}
	// Update is called once per frame
	void UpdateScore () {
		scoreText.text = "Score:\n" + score;
	}
}
